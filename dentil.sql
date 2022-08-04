create database if not exists Dentil;
use Dentil;

create table if not exists Working(
	id char(13) not null,
    name varchar(100) not null check(length(name)>=2),
    surname varchar(100) not null check(length(surname)>=2),
    email varchar(200) not null check(length(email)>=3),
    phone varchar(30) not null check(length(phone)>=2),
    address varchar(250) not null check(length(address)>=2),
    username varchar(100) unique not null check(length(username)>=2),
    password char(64) not null check(length(password)=64),
    role_name varchar(20) not null,
    primary key(id)
);

create table if not exists Admin(
	id char(13) not null,
    secretKey varchar(100) not null check(length(secretKey)>=2),
    foreign key(id) references Working(id)
    on update cascade
    on delete restrict
);

create table if not exists Personal(
	id char(13) not null,
    jobStart DATE not null,
    jobEnd DATE,
    foreign key(id) references Working(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Dentist(
	id char(13) not null,
    foreign key(id) references Personal(id)
    on update cascade
    on delete restrict
);

create table if not exists Counter(
	id char(13) not null,
    foreign key(id) references Personal(id)
    on update cascade
    on delete restrict
);

create table if not exists Patient(
	id char(13) not null,
    name varchar(100) not null check(length(name)>=2),
    surname varchar(100) not null check(length(surname)>=2),
    email varchar(200),
    phone varchar(30),
    address varchar(250),
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
    on delete restrict,
    foreign key(idAdmin) references Admin(id)
    on update cascade
    on delete set null,
    foreign key(idPersonal) references Personal(id)
    on update cascade
    on delete restrict,
    primary key(idShift, date, idPersonal)
);

create table if not exists Appointment(
	idDentist char(13) not null,
    startDate DATE not null,
    startTime TIME not null,
    IdPatient char(13) not null,
    howLong int unsigned not null check(howLong>0),
    idPersonal char(13) not null,
    foreign key(idPersonal) references Personal(id)
    on update cascade
    on delete restrict,
    foreign key(idPatient) references Patient(id)
    on update cascade
    on delete restrict,
    foreign key(idDentist) references Dentist(id)
    on update cascade
    on delete restrict,
    primary key(idDentist, startDate, startTime)
);

create table if not exists Visit(
	id int auto_increment not null,
    idPatient char(13) not null,
    date DATE not null,
    idDentist char(13) not null,
    foreign key(idDentist) references Dentist(id)
    on update cascade
    on delete restrict,
    foreign key(idPatient) references Patient(id)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists LastSeen(
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
	id int auto_increment not null,
    #babyTooth tinyint not null default(false),
    primary key(id)
);

create table if not exists TypeProblem(
	id int not null,
    name varchar(200) not null check(length(name)>=2),
    primary key(id)
);

create table if not exists Problem(
	idTypeProblem int not null,
    idTooth int not null,
    IdVisit int not null,
    foreign key(idVisit) references Visit(id)
    on update cascade
    on delete restrict,
    foreign key(idTypeProblem) references TypeProblem(id)
    on update cascade
    on delete restrict,
    foreign key(idTooth) references Tooth(id)
    on update cascade
    on delete restrict,
    primary key(idVisit, idTypeProblem, idTooth)
);

create table if not exists Treatment(
	id int auto_increment not null,
    name varchar(200) not null check(length(name)>=2),
    primary key(id)
);

create table if not exists VisitTreatment(
	idVisit int not null,
    idTreatment int not null,
    description varchar(1000),
    foreign key(idTreatment) references Treatment(id)
    on update cascade
    on delete restrict,
    foreign key(idVisit) references Visit(id)
    on update cascade
    on delete restrict,
    primary key(idTreatment, idVisit)
);

insert into Working(id, name, surname, email, phone, address, username, password, role_name) values('1111111111111', 'A1', 'A11', 'a1@gmail.com', '11111', 'Ulica 1', 'a1', 'f55ff16f66f43360266b95db6f8fec01d76031054306ae4a4b380598f6cfd114', 'admin');
insert into Working(id, name, surname, email, phone, address, username, password, role_name) values('2222222222222', 'A2', 'A22', 'a2@gmail.com', '22222', 'Ulica 2', 'a2', 'f55ff16f66f43360266b95db6f8fec01d76031054306ae4a4b380598f6cfd114', 'counter');
insert into Working(id, name, surname, email, phone, address, username, password, role_name) values('3333333333333', 'A3', 'A33', 'a3@gmail.com', '33333', 'Ulica 3', 'a3', 'f55ff16f66f43360266b95db6f8fec01d76031054306ae4a4b380598f6cfd114', 'dentist');

insert into Patient(id, name, surname, email, phone, address) values('4444444444444', 'A4', 'A44', 'a4@gmail.com', '44444', 'Ulica 4');

insert into Personal values('2222222222222', '2019-02-05', null);
insert into Personal values('3333333333333', '2020-05-02', null);

insert into admin values('1111111111111', 'aaaaaaaaaaaaa');
insert into counter values('2222222222222');
insert into dentist values('3333333333333');

insert into shift values(1, '08:00:00', '16:00:00');
insert into shift values(2, '14:00:00', '22:00:00');

insert into schedule values(1, '2022-10-22', '2222222222222', '1111111111111');
insert into schedule values(2, '2022-10-23', '3333333333333', '1111111111111');

insert into Tooth values(1);
insert into Tooth values(2);
insert into Tooth values(3);
insert into Tooth values(4);
insert into Tooth values(5);
insert into Tooth values(6);
insert into Tooth values(7);
insert into Tooth values(8);
insert into Tooth values(9);
insert into Tooth values(10);
insert into Tooth values(11);
insert into Tooth values(12);
insert into Tooth values(13);
insert into Tooth values(14);
insert into Tooth values(15);
insert into Tooth values(16);
insert into Tooth values(17);
insert into Tooth values(18);
insert into Tooth values(19);
insert into Tooth values(20);
insert into Tooth values(21);
insert into Tooth values(22);
insert into Tooth values(23);
insert into Tooth values(24);
insert into Tooth values(25);
insert into Tooth values(26);
insert into Tooth values(27);
insert into Tooth values(28);
insert into Tooth values(29);
insert into Tooth values(30);
insert into Tooth values(31);
insert into Tooth values(32);

insert into TypeProblem values(1, 'Split tooth');
insert into TypeProblem values(2, 'Cracked cusp');
insert into TypeProblem values(3, 'Cracked tooth');
insert into TypeProblem values(4, 'Craze lines');
insert into TypeProblem values(5, 'Dental decay');
insert into TypeProblem values(6, 'Gum disease');

#www.dentalhealth.org/dental-decay

insert into Treatment values(1, 'Bonding');
insert into Treatment values(2, 'Cosmetic contouring');
insert into Treatment values(3, 'Crowns');
insert into Treatment values(4, 'Veneers');
insert into Treatment values(5, 'Remove all plaque and tartar from your teeth');
