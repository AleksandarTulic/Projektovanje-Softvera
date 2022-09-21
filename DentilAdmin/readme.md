## Navigacija

1. Login(#login)
2. Kreiranje Naloga(#kreiranje-naloga)
3. Sigurnosne mjere(#sigurnosne-mjere)

## Login

Za implementaciju funkcionalnosti ulogovanja koristen je [2fa authentication](https://authy.com/what-is-2fa/), koji se sastoji iz sljedece dvije faze:
- [**_Form based authentication_**](#form-based-authentication)
- [**_QR token_**](qr-token)

### Form based authentication

Potrebno je da imate odgovarajuci **_username_** i **_password_**(kao i da se nalaze u istoj n-torki). Ukoliko se ove vrijednosti nalaze u bazi podataka **_Dentil_**, tabeli **_Working_** tada ste prosli prvi korak autentifikacije. Naravno ukoliko ovakve vrijednosti nisu pronadjene onda se od vas ponovo trazi da unesete te vrijednosti. Ukoliko ste 3 puta uzastopno pogrijesili pri unosu vrijednosti onda morate odgovarajuce vrijeme da sacekate kako biste mogli ponovo da pokusate, [vise](#sigurnosne-mjere).
Pogledajte vise na [link](https://docs.oracle.com/cd/E19798-01/821-1841/6nmq2cpki/index.html).

### QR token


Ukoliko Zelite da se ulogujete potrebno je da znate sljedece:
- **_username_**
- **_password_** 

### Kreiranje Naloga


### Sigurnosne mjere