create database if not exists Dentil;
use Dentil;

create table if not exists Worker(
	id char(13) not null,
    name varchar(100) not null check(length(name)>=2),
    surname varchar(100) not null check(length(surname)>=2),
    email varchar(200) not null check(length(email)>=3),
    phone varchar(30) not null check(length(phone)>=2),
    address varchar(250) not null check(length(address)>=2),
    username varchar(100) unique not null check(length(username)>=2),
    password char(64) not null check(length(password)=64),
    role_name varchar(20) not null,
    active tinyint not null default 1,
    primary key(id)
);

create table if not exists Admin(
	id char(13) not null,
    secretKey varchar(100) not null check(length(secretKey)>=2),
    foreign key(id) references Worker(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Personal(
	id char(13) not null,
    jobStart DATE not null,
    jobEnd DATE,
    foreign key(id) references Worker(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Dentist(
	id char(13) not null,
    foreign key(id) references Personal(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Counter(
	id char(13) not null,
    foreign key(id) references Personal(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Patient(
	id char(13) not null,
    name varchar(100) not null check(length(name)>=2),
    surname varchar(100) not null check(length(surname)>=2),
    email varchar(200),
    phone varchar(30),
    address varchar(250),
    active tinyint not null default 1,
    primary key(id)
);

create table if not exists Shift(
	id int auto_increment not null,
    begin TIME not null,
    end TIME not null,
    primary key(id)
);

create table if not exists Schedule(
	idShift int not null,
    date DATE not null,
    idPersonal char(13) not null,
    idAdmin char(13), #if he/she is deleted the shift will stand
    foreign key(idShift) references Shift(id)
    on update cascade
    on delete cascade,
    foreign key(idAdmin) references Admin(id)
    on update cascade
    on delete set null,
    foreign key(idPersonal) references Personal(id)
    on update cascade
    on delete restrict,
    primary key(date, idPersonal)
);

create table if not exists Appointment(
	uniquevalue BIGINT not null unique auto_increment,
	idDentist char(13) not null,
    startDate DATE not null,
    startTime TIME not null,
    idPatient char(13) not null,
    howLong int unsigned not null check(howLong>0),
    idWorker char(13) not null,
    active tinyint not null default 1,
    foreign key(idWorker) references Personal(id)
    on update cascade
    on delete restrict,
    foreign key(idPatient) references Patient(id)
    on update cascade
    on delete restrict,
    foreign key(idDentist) references Dentist(id)
    on update cascade
    on delete restrict,
    primary key(idDentist, startDate, startTime, uniquevalue)
);

create table if not exists Visit(
	id int auto_increment not null,
    idPatient char(13) not null,
    date DATE not null,
    idDentist char(13) not null,
    active tinyint not null default 1,
    foreign key(idDentist) references Dentist(id)
    on update cascade
    on delete restrict,
    foreign key(idPatient) references Patient(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists HistoryVisit(
	idVisit int not null,
    dateWhen DATE not null,
    timeWhen TIME not null,
    idDentist char(13) not null,
    foreign key(idDentist) references Dentist(id)
    on update cascade
    on delete restrict,
    foreign key(idVisit) references Visit(id)
    on update cascade
    on delete restrict,
    primary key(idVisit, dateWhen, timeWhen, idDentist)
);

create table if not exists Tooth(
	id int unsigned not null,
    active tinyint not null default 1,
    #babyTooth tinyint not null default(false),
    primary key(id)
);

create table if not exists TypeProblem(
	id int auto_increment not null,
    name varchar(200) not null check(length(name)>=2),
    active tinyint not null default 1,
    primary key(id)
);

create table if not exists Problem(
	idTypeProblem int not null,
    idTooth int unsigned, #ovo cu vjerojatno morati promijeniti da je moguce null
    idVisit int not null,
    foreign key(idVisit) references Visit(id)
    on update cascade
    on delete restrict,
    foreign key(idTypeProblem) references TypeProblem(id)
    on update cascade
    on delete restrict,
    foreign key(idTooth) references Tooth(id)
    on update cascade
    on delete restrict,
    primary key(idVisit, idTypeProblem)
);

create table if not exists Service(
	id int auto_increment not null,
    name varchar(200) not null check(length(name)>=2),
    cost double not null check(cost>=0.0),
    active tinyint not null default 1,
    primary key(id)
);

create table if not exists VisitService(
	idVisit int not null,
    idService int not null,
    description varchar(1000),
    foreign key(idService) references Service(id)
    on update cascade
    on delete restrict,
    foreign key(idVisit) references Visit(id)
    on update cascade
    on delete restrict,
    primary key(idService, idVisit)
);

#sifra ista kao i username
#password=korisnikAdmin
insert into Worker(id, name, surname, email, phone, address, username, password, role_name, active) values('1111111111111', 'Jovana', 'Jovanovic', 'a1@gmail.com', '11111', 'Ulica 1', 'korisnikAdmin', 'c9becaa0c96a9c1fe6ef464c01a7bbba9190cd8e78e2eb659137c6e604ddcc2c', 'admin', 1);

#password=korisnikCounter
insert into Worker(id, name, surname, email, phone, address, username, password, role_name, active) values('2222222222222', 'Aleksandar', 'Tulic', 'a2@gmail.com', '22222', 'Ulica 2', 'korisnikCounter', '3ce7aa4880c825464cae462a135108656f9c6bc9d2624a3adc791b506ddd5f43', 'counter', 1);

#password=korisnikDentist
insert into Worker(id, name, surname, email, phone, address, username, password, role_name, active) values('3333333333333', 'Bojan', 'Jazic', 'a3@gmail.com', '33333', 'Ulica 3', 'korisnikDentist', '6838fdbef998cc68f69455ee75c5f956a0ea183d4036407977de1e1f61f7e51d', 'dentist', 1);

insert into Patient(id, name, surname, email, phone, address) values('4444444444444', 'Mladen', 'Grbic', 'a4@gmail.com', '44444', 'Ulica 4');

insert into Personal values('2222222222222', '2019-02-05', null);
insert into Personal values('3333333333333', '2020-05-02', null);

insert into admin values('1111111111111', 'FTQCYXSCL7MKI7PHW5SU7UIFY7G5C2A7');
insert into counter values('2222222222222');
insert into dentist values('3333333333333');

insert into shift values(1, '08:00:00', '16:00:00');
insert into shift values(2, '14:00:00', '22:00:00');

insert into schedule values(1, '2022-10-22', '2222222222222', '1111111111111');
insert into schedule values(2, '2022-10-23', '3333333333333', '1111111111111');

insert into Tooth(id) values(1);
insert into Tooth(id) values(2);
insert into Tooth(id) values(3);
insert into Tooth(id) values(4);
insert into Tooth(id) values(5);
insert into Tooth(id) values(6);
insert into Tooth(id) values(7);
insert into Tooth(id) values(8);
insert into Tooth(id) values(9);
insert into Tooth(id) values(10);
insert into Tooth(id) values(11);
insert into Tooth(id) values(12);
insert into Tooth(id) values(13);
insert into Tooth(id) values(14);
insert into Tooth(id) values(15);
insert into Tooth(id) values(16);
insert into Tooth(id) values(17);
insert into Tooth(id) values(18);
insert into Tooth(id) values(19);
insert into Tooth(id) values(20);
insert into Tooth(id) values(21);
insert into Tooth(id) values(22);
insert into Tooth(id) values(23);
insert into Tooth(id) values(24);
insert into Tooth(id) values(25);
insert into Tooth(id) values(26);
insert into Tooth(id) values(27);
insert into Tooth(id) values(28);
insert into Tooth(id) values(29);
insert into Tooth(id) values(30);
insert into Tooth(id) values(31);
insert into Tooth(id) values(32);

insert into TypeProblem(id, name) values(1, 'Split tooth');
insert into TypeProblem(id, name) values(2, 'Cracked cusp');
insert into TypeProblem(id, name) values(3, 'Cracked tooth');
insert into TypeProblem(id, name) values(4, 'Craze lines');
insert into TypeProblem(id, name) values(5, 'Dental decay');
insert into TypeProblem(id, name) values(6, 'Gum disease');

#www.dentalhealth.org/dental-decay
#https://www.carecredit.com/dentistry/costs/

insert into Service(id, name, cost) values(1, 'Dental Implants', 3000.00);
insert into Service(id, name, cost) values(2, 'Dental Crown', 500.00);
insert into Service(id, name, cost) values(3, 'Tooth Extraction', 219.00);
insert into Service(id, name, cost) values(4, 'Teeth Cleaning', 75.00);
insert into Service(id, name, cost) values(5, 'Root Canal', 300.00);
insert into Service(id, name, cost) values(6, 'Wisdom Teeth Removal (impacted tooth)', 225.00);
insert into Service(id, name, cost) values(7, 'Professional Teeth Whitening', 300.00);
insert into Service(id, name, cost) values(8, 'Full Mouth Dental Reconstruction', 30000.00);