## Navigacija

1. [Login](#login)
2. [Kreiranje Naloga](#kreiranje-naloga)
3. [Sigurnosne mjere](#sigurnosne-mjere)

## Login

Za implementaciju funkcionalnosti Login koristen je [2fa authentication](https://authy.com/what-is-2fa/), koji se sastoji iz sljedece dvije faze:
- [**_Form based authentication_**](#form-based-authentication)
- [**_QR token_**](#qr-token)

### Form based authentication

Potrebno je da imate odgovarajuci **_username_** i **_password_**(kao i da se nalaze u istoj n-torki). Ukoliko se ove vrijednosti nalaze u bazi podataka **_Dentil_**, tabeli **_Working_** tada ste prosli prvi korak autentifikacije. Naravno ukoliko ovakve vrijednosti nisu pronadjene onda se od vas ponovo trazi da unesete te vrijednosti. Ukoliko ste 3 puta uzastopno pogrijesili pri unosu vrijednosti onda morate odgovarajuce vrijeme da sacekate kako biste mogli ponovo da pokusate.
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

<br />
<br />
Pogledajte vise na <a href="https://en.wikipedia.org/wiki/QR_code">here</a>.

### Kreiranje Naloga


### Sigurnosne mjere
