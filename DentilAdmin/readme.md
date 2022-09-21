## Navigacija

1. [Login](#login)
2. [Kreiranje Naloga](#kreiranje-naloga)
3. [Sigurnosne mjere](#sigurnosne-mjere)

## Login

Za implementaciju funkcionalnosti ulogovanja koristen je [2fa authentication](https://authy.com/what-is-2fa/), koji se sastoji iz sljedece dvije faze:
- [**_Form based authentication_**](#form-based-authentication)
- [**_QR token_**](#qr-token)

### Form based authentication

Potrebno je da imate odgovarajuci **_username_** i **_password_**(kao i da se nalaze u istoj n-torki). Ukoliko se ove vrijednosti nalaze u bazi podataka **_Dentil_**, tabeli **_Working_** tada ste prosli prvi korak autentifikacije. Naravno ukoliko ovakve vrijednosti nisu pronadjene onda se od vas ponovo trazi da unesete te vrijednosti. Ukoliko ste 3 puta uzastopno pogrijesili pri unosu vrijednosti onda morate odgovarajuce vrijeme da sacekate kako biste mogli ponovo da pokusate.
\nPogledajte vise na [here](https://docs.oracle.com/cd/E19798-01/821-1841/6nmq2cpki/index.html).

### QR token

Kada se kreira nalog za tipa korisnika **_admin_** onda se takodje kreira i QR token koji se salje na njihovu email adresu. Koristeci aplikaciju [**_Google Authenticator_**](https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&hl=en&gl=US)skenirate QR token i dobijete vrijednost koja se mijenja svakih 30s. Ta vrijednost je kod od 6 cifara. Ukoliko vrijednost koju vi unesete je pogresna onda ponovo morate da prodjete [prvi korak](#form-based-authentication). Ukoliko i ovaj korak uspjesno prodjete onda mozete da koristite funkcionalnosti koje vam aplikacija nudi.
\nPogledajte vise na [here](https://en.wikipedia.org/wiki/QR_code).

### Kreiranje Naloga


### Sigurnosne mjere