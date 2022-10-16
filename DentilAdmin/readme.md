## Navigacija

1. [Login](#login)
2. [Kreiranje Naloga](#kreiranje-naloga)
3. [Brisnaje Naloga](#brisanje-naloga)
4. [Azuriranje Naloga](#azuriranje-naloga)
5. [Dodavanje Rasporeda](#dodavanje-rasporeda)
6. [Brisanje Rasporeda](#brisanje-rasporeda)
7. [Dodavanje Smjene](#dodavanje-smjene)
8. [Brisanje Smjene](#brisanje-smjene)
9. [Sertifikat](#sertifikat)
10. [Potvrda Operacije](#potvrda-operacije)

## Login

Za implementaciju funkcionalnosti Login koristen je [2fa authentication](https://authy.com/what-is-2fa/), koji se sastoji iz sljedece dvije faze:
- [**_Form based authentication_**](#form-based-authentication)
- [**_QR token_**](#qr-token)

### Form based authentication

Potrebno je da imate odgovarajuci **_username_** i **_password_**(kao i da se nalaze u istoj n-torki). Ukoliko se ove vrijednosti nalaze u bazi podataka **_Dentil_**, tabeli **_Working_** tada ste prosli prvi korak autentifikacije. Naravno ukoliko ovakve vrijednosti nisu pronadjene onda se od vas ponovo trazi da unesete te vrijednosti. Ukoliko ste 3 puta uzastopno pogrijesili pri unosu vrijednosti onda morate odgovarajuce vrijeme da sacekate kako biste mogli ponovo da pokusate.

Za implementaciju **_Form based Authentication_** koristio sam postojece mehanizme apache tomcat servera:
```xml
    <Realm className="org.apache.catalina.realm.LockOutRealm" failureCount="3" lockOutTime="180">
        <Realm className="org.apache.catalina.realm.DataSourceRealm" dataSourceName="jdbc/dms" roleNameCol="role_name" userCredCol="password" userNameCol="username" userRoleTable="Working" userTable="Working">
            <CredentialHandler algorithm="sha256" className="org.apache.catalina.realm.MessageDigestCredentialHandler"/>
        </Realm>
    </Realm>
```
Ove vrijednosti se postavljaju unutar fajla **_C:Program Files\apache-tomcat-10.0.21\conf\server.xml_**, pri cemu **_C:Program Files\apache-tomcat-10.0.21_** je u mom slucaju mjesto gdje sam instalirao apache tomcat server. Takodje odavde mozete da vidite da smo ovu aplikaciju razvijali sa verzijom **_apache tomcat 10.0.21_**, tako da bi bilo pozeljno da i vi ukoliko zelite da koristite ovu aplikaciju, da koristite ovu verziju apache tomcat servera.
<br />
<br />
Mozemo da vidimo na osnovu **_Credential Handlera_** da vrijednost koju vi unesete u textbox forme login se zapravo prevodi u njegovu **_SHA256_** ekvivalentnu vrijednost. Pa se onda poredi sa odgovarajucim poljem unutar baze podataka. Kazem ekvivalentnu jer nije koristen [salt](https://en.wikipedia.org/wiki/Salt_(cryptography)).

Da bi se koristili authentication mehanizmi apache tomcat servera potrebno je da imamo standardnu formu za login samo sto moramo postaviti sljedece vrijednosti unutar odgovarajucih atributa:
- j_security_check
- j_username
- j_password
```html
<div class="container">
    <div class="row">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-8">
            <h2>Login Admin</h2>
            <form name="loginForm" method="POST" action="j_security_check">
                <div class="form-group">
                    <p>Username: <input type="text" name="j_username" class="form-control"/></p>
                </div>
                
                <div class="form-group">
                    <p>Password: <input type="password" class="form-control" name="j_password"/></p>
                </div>
                <p>  <input style="width: 50%;margin-right: 25%;margin-left: 25%;" type="submit" value="Login" class="btn btn-default"/></p>
            </form>
        </div>
        <div class="col-sm-2">
        </div>
    </div>
</div>
```

Pored toga potrebno je u fajlu **_web.xml_** da postavimo sljedece vrijednosti:
```xml
<security-constraint>
    <display-name>Form-Based Authentication Constraint</display-name>
    <web-resource-collection>
        <web-resource-name>Form-Based Authentication</web-resource-name>
        <description></description>
        <url-pattern>/*</url-pattern>
    </web-resource-collection>
    <auth-constraint>
        <description></description>
        <role-name>admin</role-name>
    </auth-constraint>
    <user-data-constraint>
        <transport-guarantee>CONFIDENTIAL</transport-guarantee>
    </user-data-constraint>
</security-constraint>
<login-config>
    <auth-method>FORM</auth-method>
    <realm-name>Form-Based Authentication</realm-name>
    <form-login-config>
        <form-login-page>/login.jsp</form-login-page>
        <form-error-page>/error.jsp</form-error-page>
    </form-login-config>
</login-config>
<security-role>
    <description></description>
    <role-name>admin</role-name>
</security-role>
```

<br />
<br />
Pogledajte vise na <a href="https://docs.oracle.com/cd/E19798-01/821-1841/6nmq2cpki/index.html">here</a>.

### QR token

Kada se kreira nalog za tipa korisnika **_admin_** onda se takodje kreira i QR token koji se salje na njihovu email adresu. Koristeci aplikaciju [**_Google Authenticator_**](https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&hl=en&gl=US) skenirate QR token i dobijete vrijednost koja se mijenja svakih 30s. Ta vrijednost je kod od 6 cifara. Ukoliko vrijednost koju vi unesete je pogresna onda ponovo morate da prodjete [prvi korak](#form-based-authentication). Ukoliko i ovaj korak uspjesno prodjete onda mozete da koristite funkcionalnosti koje vam aplikacija nudi.

<br />
Da bi QR token koji se generise za svakog korisnika tipa admin bio jedinstven koristimo sljedecu funkcionalnost:

```java
private String generateSecretKey() {
    SecureRandom random = new SecureRandom();
    byte[] bytes = new byte[20];
    random.nextBytes(bytes);
    Base32 base32 = new Base32();
    return base32.encodeToString(bytes);
}
```
- [SecureRandom](https://docs.oracle.com/javase/8/docs/api/java/security/SecureRandom.html)
- [Base32](https://commons.apache.org/proper/commons-codec/apidocs/org/apache/commons/codec/binary/BaseNCodec.html#encodeToString-byte:A-)

Mjesto gdje se na serveru skladiste tokeni je:

```java
public static final String SAVE_PATH = System.getProperty("catalina.home") + File.separator + "Dentil" + File.separator + "qr"
```

Mozemo da vidimo da ovde ulogu ima varijabla <b>CATALINA_HOME</b>, pa je samim tim potrebno da je ona definisana. Ukoliko niste sigurni da li je onda definisana ili zelite da postavite njenu vrijednost onda mozete da pratite korake sa sljedece stranice <a href="https://docs.oracle.com/en/database/oracle/machine-learning/oml4r/1.5.1/oread/creating-and-modifying-environment-variables-on-windows.html#GUID-DD6F9982-60D5-48F6-8270-A27EC53807D0">here</a>. Takodje obratite paznju da je potrebno postojanje foldera:
<ul>
    <li>Dentil</li>
    <li>qr</li>
</ul>

Metoda koja se poziva iz ostalih servisa aplikacije za kreiranje QR koda jeste sljedeca:
```java
public String generateQR(String id) {
    String secretKey = "AAAAAAAAAAAAAAAAAAAAAAAAAA";
    try {
        secretKey = generateSecretKey();
        String email = "test@gmail.com";
        String companyName = "Korisnici";
        String barCodeUrl = getGoogleAuthenticatorBarCode(secretKey, email, companyName);
        createQRCode(barCodeUrl, SAVE_PATH + File.separator + id + ".png", 400, 400);
    }catch (Exception e) {
        MyLogger.logger.log(Level.SEVERE, e.getMessage());
    }

    return secretKey;
}
```
Vrijednosti kao sto su <i>"AAAAAAAAAAAAAAAAAAAAAAAAAA"</i>, <i>"test@gmail.com"</i> i <i>"Korisnici"</i> su samo neke default vrijednosti u nasem slucaju nisu nam trenutno vazne.

<br />
<br />
Pogledajte vise na <a href="https://en.wikipedia.org/wiki/QR_code">here</a>.

## Kreiranje Naloga

Bezobzira koju vrstu naloga kreiramo **potrebno** je da unesemo sljedece vrijednosti:
- id
- name
- surname
- email
- phone
- address
- username
- password
- usertype

Ukoliko je usertype tipa _counter_ ili _dentist_ onda je potrebno da unesemo i jobStartDate atribut. Forma za njihovo popunjavanje je data u nastavku.

Selektovan Admin           |  Selektovan Counter
:-------------------------:|:-------------------------:
![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl1.png)  |  ![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl2.png)

Kada se uspjesno kreira nalog tipa _Admin_ tada se na njegovu email adresu posalje QR token koji onda treba da se skenira sa **_Google Authenticator_** mobilnom aplikacijom. Nakon toga dobijete kod koji se vremenski mijenja i koji vam je potreban za autentikaciju. Za vise pogledajte [prethodno](#form-based-authentication).

## Brisanje Naloga

Prije nego sto zapravo obrisete nekog korisnika od vas se trazi da potvrdite tu operaciju. Ovo radimo jer operacija brisanja korisnika je veoma destruktivna(_od korisnika zavisi mnogo drugih elemenata_).

Prije                      |  Poslije
:-------------------------:|:-------------------------:
![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl13.png)  |  ![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl14.png)

Kod koji zahtijeva potvrdu:
```js
function areYouSure(){
	if (confirm("Are you sure?") == true){
		return true;
	}else{
		return false;
	}
}
```

## Azuriranje Naloga

Kada pritisnete dugme **_Update_** onda vam se pojavi _Form-Modal_ u kome su vec polja forme popunjena vrijednosti korisnika koga update-ujete. Jedino _password_ nije popunjen i vi morate da za to unesete vrijednost ako zelite da izvrsite azuriranje. Naravno vi mozete da unesete staru sifru. Sad se mozda pitate zasto je ovo ovako radjeno? Pa zato sto mi ne znamo koja je sifra korisnika mi samo znamo njenu hash vrijednost, a i predstavlja sigurnosni rizik da mi ucitavamo tu vrijednost unutar ove aplikacije. Za vise pogledajte <a href="#login">ovde</a>.

Prije                      |  Poslije
:-------------------------:|:-------------------------:
![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl6.png)  |  ![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl8.png)

|Forma Za Azuriranje|
|-------------------|
|![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl7.png)|

## Dodavanje Rasporeda

Da bismo dodali raspored potrebno je da odradimo sljedece:
- Potrebno je da cekiranjem checkBox-ova odaberemo kojim korisnicima zelimo da dodamo raspored
- Potrebno je da odaberemo koju smjenu rade
- Potrebno je da odaberemo dan na koji primjenjujemo odabranu smjenu

Vazno je da napomenemo da jedan korisnik moze maksimalno da ima jednu smjenu u jednom danu sto se moze primjetiti iz analiziranjem koda baze podataka.

|Forma Za Unos|
|-------------|
|![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl3.png)|

```sql
create table if not exists Schedule(
	idShift int not null,
    date DATE not null,
    idPersonal char(13) not null,
    idAdmin char(13),
    foreign key(idShift) references Shift(id)
    on update cascade
    on delete restrict,
    foreign key(idAdmin) references Admin(id)
    on update cascade
    on delete set null,
    foreign key(idPersonal) references Personal(id)
    on update cascade
    on delete restrict,
    primary key(idShift, date, idPersonal)
);
```

## Brisanje Rasporeda

Da biste obrisali neki raspored potrebno je da selektujete checkBox i da onda pritisnete dugme delete. Takodje mozete vise checkBox-ova da selektujete i da istovremeno obrisete sve selektovane rasporede. Pored toga mozete klikom na checkBox _Select All_ da selektujete sve rasporede rada.

Selektovanje Pojedinih Rasporeda                                                                        |  Selektovanje Koristenjem _Select All_
:------------------------------------------------------------------------------------------------------:|:-----------------------------------------:
![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl4.png)     |    ![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl5.png)

## Dodavanje Smjene

## Brisanje Smjene

## Sertifikat

Da bi korisnici koji dolaze na nasu stranicu preneseno receno "mogli vjerovati" da smo mi kao aplikacija zapravo prava verzija a ne neka kopija potrebno je da se korisnickom pretrazivacu kao i samom korisniku prestavimo koristeci sertifikat: 
```xml
<Connector SSLEnabled="true" clientAuth="false" maxThreads="500" port="8443" protocol="org.apache.coyote.http11.Http11NioProtocol">
    <SSLHostConfig>
        <Certificate certificateKeystoreFile="${catalina.home}\server.jks" certificateKeystorePassword="sigurnost" type="RSA"/>
    </SSLHostConfig>
</Connector>
```
Sertifikat koji smo ovdje koristili je samopotpisani sto naravno predstavlja problem za vise pogledajte [ovde](https://en.wikipedia.org/wiki/Public_key_infrastructure). Ovo se sve nalazi u fajlu **_C:Program Files\apache-tomcat-10.0.21\conf\server.xml_**, pri cemu **_C:Program Files\apache-tomcat-10.0.21_** je u mom slucaju mjesto gdje sam instalirao apache tomcat server.

## Potvrda Operacije

Kada odradimo neku operaciju potrebno je da potvrdimo korisniku da li je uspjesno ili neuspjesno izvrsio operaciju. Jer zamislimo da dodajemo neki raspored za nekog korisnika a vec postoji stotine rasporeda. Nije lako da se uoci u listi da li smo uspjesno dodali raspored za nekog korisnika.

Uspjesno Izvrsavanje Operacije                                                                          |  Neuspjesno Izvrsavanje Operacije
:------------------------------------------------------------------------------------------------------:|:-----------------------------------------:
![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl9.png)     |    ![](https://github.com/AleksandarTulic/Projektovanje-Softvera/blob/main/DentilAdmin/images/sl10.png)