## Navigacija

1. [Login](#login)
2. [Kreiranje Naloga](#kreiranje-naloga)
3. [Sertifikat](#sertifikat)

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
<br />
<br />
Pogledajte vise na [here](https://docs.oracle.com/cd/E19798-01/821-1841/6nmq2cpki/index.html).

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

### Kreiranje Naloga


### Sertifikat

Da bi korisnici koji dolaze na nasu stranicu preneseno receno "mogli vjerovari" da smo mi kao aplikacija zapravo prava verzija a ne neka kopija potrebno je da se korisnickom pretrazivacu kao i samom korisniku prestavimo koristeci sertifikat: 
```xml
<Connector SSLEnabled="true" clientAuth="false" maxThreads="500" port="8443" protocol="org.apache.coyote.http11.Http11NioProtocol">
    <SSLHostConfig>
        <Certificate certificateKeystoreFile="${catalina.home}\server.jks" certificateKeystorePassword="sigurnost" type="RSA"/>
    </SSLHostConfig>
</Connector>
```
Sertifikat koji smo ovdje koristili je samopotpisani sto naravno predstavlja problem za vise pogledajte [ovde](https://en.wikipedia.org/wiki/Public_key_infrastructure). Ovo se nalazi u fajlu **_C:Program Files\apache-tomcat-10.0.21\conf\server.xml_**, pri cemu **_C:Program Files\apache-tomcat-10.0.21_** je u mom slucaju mjesto gdje sam instalirao apache tomcat server.
