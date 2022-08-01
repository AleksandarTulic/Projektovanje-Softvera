CREATE SCHEMA IF NOT EXISTS Dentil DEFAULT CHARACTER SET utf8 ;
use Dentil;

CREATE USER IF NOT EXISTS 'newuser'@'localhost' IDENTIFIED BY 'localhost';
GRANT ALL PRIVILEGES ON * . * TO 'newuser'@'localhost';

create table if not exists Working(
	jmb CHAR(13) NOT NULL check(length(jmb)=13),
	name VARCHAR(50) NOT NULL check(length(name)>=2),
	surname VARCHAR(100) NOT NULL check(length(surname)>=2),
	email VARCHAR(200) NULL,
	phone VARCHAR(100) NULL,
	city VARCHAR(100) NULL,
	street VARCHAR(100) NULL,
	streetNum INT UNSIGNED NULL,
	gender TINYINT NOT NULL,
	hash VARCHAR(128) NOT NULL,
	userName VARCHAR(50) unique NOT NULL,
	bank VARCHAR(100) NOT NULL check(length(bank)>=2),
	numAccount VARCHAR(100) NOT NULL check(length(numAccount)>=1),
    primary key(jmb)
);

create table if not exists Patient(
	jmb CHAR(13) NOT NULL check(length(jmb)=13),
	name VARCHAR(50) NOT NULL check(length(name)>=2),
	surname VARCHAR(100) NOT NULL check(length(surname)>=2),
	email VARCHAR(200) NULL,
	phone VARCHAR(100) NULL,
	city VARCHAR(100) NULL,
	street VARCHAR(100) NULL,
	streetNum INT UNSIGNED NULL,
	gender TINYINT NOT NULL,
    primary key(jmb)
);

create table if not exists Admin(
	jmb char(13) not null check(length(jmb)=13),
    foreign key(jmb) references Working(jmb),
    primary key(jmb)
);

create table if not exists Personal(
	jmb char(13) not null check(length(jmb)=13),
    jobStart date not null,
    jobEnd date,
    foreign key(jmb) references Working(jmb),
    primary key(jmb)
);

create table if not exists Dentist(
	jmb char(13) not null,
    educationPlace varchar(300) not null check(length(educationPlace)>=2),
    title varchar(200) not null check(length(title)>=2),
    foreign key(jmb) references Personal(jmb),
    primary key(jmb)
);

create table if not exists Shift(
	id int unsigned auto_increment not null,
    begin time not null,
    end time not null,
    primary key(id)
);

create table if not exists Schedule(
	adminJmb char(13) not null,
    personalJmb char(13) not null,
    date Date not null,
    id int unsigned not null,
    foreign key(id) references Shift(id)
    on update cascade
    on delete restrict,
    foreign key(adminJmb) references Admin(jmb)
    on update cascade
    on delete restrict,
    foreign key(personalJmb) references Personal(jmb)
    on update cascade
    on delete restrict,
    primary key(id, date, personalJmb)
);

### Ovo je appointment samo modifikovan
/*
create table if not exists Termin(
	id int unsigned auto_increment not null,
    timeWhen time not null,
    dateWhen date not null,
    note text,
    patientJmb char(13) ,
    personalJmb char(13) not null,
    foreign key(personalJmb) references Personal(jmb)
    on update cascade
    on delete restrict,
    foreign key(patientJmb) references Patient(jmb)
    on update cascade
    on delete set null,
    primary key(id)
);
*/

create table if not exists Teeth(
	numTeeth int unsigned not null check(numTeeth<=32),
    primary key(numTeeth)
);

create table if not exists TypeProblem(
	name varchar(100) not null check(length(name)>=2),
    descr text,
    picture varchar(100),
    primary key(name)
);

create table if not exists Visit(
	id int unsigned auto_increment not null,
    date date not null,
    patientJmb char(13),
    dentistJmb char(13) not null,
    foreign key(patientJmb) references Patient(jmb)
    on update cascade
    on delete set null,
    foreign key(dentistJmb) references Dentist(jmb)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists Problem(
	id int unsigned not null,
    name varchar(100) not null,
    numTeeth int unsigned,
    foreign key(id) references Visit(id)
    on update cascade
    on delete restrict,
    foreign key(name) references TypeProblem(name)
    on update cascade
    on delete restrict,
    foreign key(numTeeth) references Teeth(numTeeth)
    on update cascade
    on delete restrict,
    primary key(id, name)
);

create table if not exists LastSeen(
	visitId int unsigned not null,
    jmb char(13) not null,
    dateWhen date not null,
    timeWhen time not null,
    foreign key(visitId) references Visit(id)
    on update cascade
    on delete restrict,
    foreign key(jmb) references Dentist(jmb)
    on update cascade
    on delete restrict,
    primary key(visitId, jmb, dateWhen, timeWhen)
);

create table if not exists ItemAndServices(
	id int unsigned auto_increment not null,
    name varchar(200) not null check(length(name)>=2),
    cost double not null check(cost>=0.0),
    descr text,
    path varchar(200),
    type ENUM('service', 'item') not null,
    primary key(id)
);

create table if not exists Bill(
	id int unsigned auto_increment not null,
    dateWhen date not null,
    timewhen time not null,
    cost double not null check(cost>=0.0),
    personalJmb char(13) not null,
    foreign key(personalJmb) references Personal(jmb)
    on update cascade
    on delete restrict,
    primary key(id)
);

create table if not exists ItemBill(
	id int unsigned not null,
    idIS int unsigned not null,
    foreign key(id) references Bill(id)
    on update cascade
    on delete restrict,
    foreign key(idIS) references ItemAndServices(id)
    on update cascade
    on delete restrict,
    primary key(id, idIS)
);

create table if not exists appointment(
	startDate date not null,
    startTime time not null,
    howLong int unsigned not null,
    personalJmb char(13) not null,
    patientJmb char(13) not null,
    note text,
    foreign key(personalJmb) references personal(jmb)
    on update cascade
    on delete restrict,
    foreign key(patientJmb) references patient(jmb)
    on update cascade
    on delete restrict,
    primary key(startDate, startTime, personalJmb)
);

###########################
### VIEW
###########################

create view getalldentist as
select w.jmb, w.name, w.surname
from Dentist as d inner join Working as w on w.jmb=d.jmb;

create view getalllastseen as
select ls.visitId, w.name, w.surname, ls.dateWhen, ls.timeWhen
from LastSeen as ls inner join Working as w on w.jmb=ls.jmb;

create view getallvisits as
select v.id, v.date, p.name, tp.descr, tp.picture, p.numTeeth, v.patientJmb
from Problem as p inner join Visit as v on v.id=p.id
				inner join TypeProblem tp on p.name=tp.name;
                
create view getspecificinformation as
select p.jmb, p.jobStart, p.jobEnd, d.educationPlace, d.title
from (Personal as p inner join Dentist as d on d.jmb=p.jmb) union
	 (	select p.jmb, p.jobStart, p.jobEnd, null, null
		from (
				select p.jmb, p.jobStart, p.jobEnd
                from Personal as p
                where p.jmb in (select d.jmb from Dentist as d) is false
			 ) as p
     );
     
create view getuserspecificinfo as
select w.jmb, w.name, w.surname, w.email, w.phone, w.city, w.street, w.streetNum, w.gender, w.userName, w.bank, w.numAccount, sp.jobStart, sp.JobEnd, sp.educationPlace, sp.title
from Working as w inner join Personal as p on w.jmb=p.jmb
				  inner join getspecificinformation as sp on sp.jmb=w.jmb;

###########################
### STORED PROCEDURES
###########################

DELIMITER //
CREATE PROCEDURE checkDentistWorks(in personalJmb char(13), in startDate date, in startTime time, in howLong int, out flag bit)
BEGIN
	declare numIte int default (select count(*) from schedule as s where s.date=startDate and s.personalJmb=personalJmb);
    declare i int default 1;
    declare Abegin datetime default addtime(convert(startDate, datetime), startTime);
    declare Aend datetime default addtime(addtime(convert(startDate, datetime), startTime), sec_to_time(howLong*60));
    declare Nbegin datetime;
    declare Nend datetime;
    declare NBeginTime time;
    declare NEndTime time;
    declare idIte int;
    declare br int default 0;
    set flag = 0;
    
    foreach: loop
		set @rn = 0;
		set idIte = (select s.id from (select @rn:=@rn+1 as ind, s.id from schedule as s where s.date=startDate and s.personalJmb=personalJmb) as s where s.ind=i);
        set NBeginTime = (select s.begin from shift as s where s.id=idIte);
        set NEndTime = (select s.end from shift as s where s.id=idIte);
        
        set Nbegin = addtime(convert(startDate, datetime), NBeginTime);
        
        set Nend = addtime(convert(startDate, datetime), NEndTime);
        if (select timediff(NBeginTime, NEndTime) <= 0)
        then
			set Nend = addtime(convert(startDate, datetime), '24:00:00');
        end if;
        
        if Abegin >= Nbegin and Abegin <= Nend and Aend <= Nend and Aend >= Nbegin
        then
			set flag = 1;
        end if;
        
        set i = i + 1;
        if i > numIte
        then
			leave foreach;
        end if;
    end loop;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `checkHash`(in hash varchar(128), in userName varchar(50), in typePersonal ENUM('admin', 'dentist', 'other'),out flag bit)
BEGIN
	set flag = 0;
	if ( select count(*) from working as w where w.hash = hash and w.userName=userName) > 0
    then
		set flag = 1;
    end if;
    
    if typePersonal = 'admin'
    then
		if (select count(*) from admin as a inner join working as w on w.jmb=a.jmb where w.userName=userName) = 0
        then
			set flag = 0;
        end if;
    end if;
    
    if typePersonal = 'dentist'
    then
		if (select count(*) from dentist as d inner join working as w on w.jmb=d.jmb where w.userName=userName) = 0
        then
			set flag = 0;
        end if;
    end if;
    
    if typePersonal = 'other'
    then
		if (select count(*) from personal as p inner join working as w on w.jmb=p.jmb where w.userName=userName) = 0
        then
			set flag = 0;
        end if;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deleteAppointment`(in startDate date, in startTime time, in personalJmb char(13), out flag bit)
BEGIN
	set flag = 0;
    
    if (select count(*) from appointment as a where a.startDate=startDate and a.startTime=startTime and a.personalJmb=personalJmb) > 0
    then
		delete from appointment as a where a.startDate=startDate and a.startTime=startTime and a.personalJmb=personalJmb;
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deleteElement`(in id int, out flag bit)
BEGIN
	set flag = 0;
	if (select count(*) from ItemAndServices) > 0 then
		delete from ItemAndServices as ias where ias.id=id;
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deletePersonal`(in id char(13), out flag bit)
BEGIN
	set flag = 0;
    
    if (select count(*) from personal as p where p.jmb=id) > 0 and (select jobEnd from personal where jmb=id) is null
    then
        update personal as p
        set p.jobEnd = date(now())
        where p.jmb=id;
        
        delete from schedule as s where s.personalJmb=id;
        delete from appointment as t where t.personalJmb=id;
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deleteSchedule`(in idPersonal char(13), in id int, in dateWhen date, out flag bit)
BEGIN
	set flag = 0;
    
    if ( select count(*) from schedule as s where s.personalJmb=idPersonal and s.id=id and s.date=dateWhen ) > 0
    then
		delete from schedule as s where s.id=id and s.personalJmb=idPersonal and s.date=dateWhen;
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deleteShift`(in id int, out flag bit)
BEGIN
	set flag = 0;
    if ( select count(*) from shift as s where s.id=id ) > 0
    then
		delete from schedule as s where s.id=id;
		delete from shift as s where s.id=id;
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getAppointments`(in startDate varchar(20), in personalJmb char(13), in jmb varchar(13), in name varchar(50), in surname varchar(100))
BEGIN
	select ap.startDate, ap.startTime, ap.howLong, ap.personalJmb, ap.patientJmb, ap.note  from appointment as ap inner join patient as p on p.jmb=ap.patientJmb
    where ap.startDate like concat('%', startDate, '%') and ap.personalJmb like concat('%', personalJmb, '%')
    and ap.patientJmb like concat('%', jmb, '%') and p.name like concat('%', name,'%') and p.surname like concat('%', surname, '%');
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getDateTimeBill`(in id int)
BEGIN
	select dateWhen, timeWhen
    from bill as b
    where b.id=id;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getLastSeen`(in visitId int)
BEGIN
	select ls.name, ls.surname, ls.dateWhen, ls.timeWhen from getalllastseen as ls
    where ls.visitId=visitId;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getShiftAdmin`(in idPersonal char(13), in id int, in dateWhen date)
BEGIN
	select w.name, w.surname
    from schedule as s inner join working as w on w.jmb=adminJmb
    where s.personalJmb=idPersonal and s.id=id and s.date=dateWhen;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getUser1`(in hash varchar(128), in userName varchar(50), in jmb varchar(13), in name varchar(50),
in surname varchar(100), in email varchar(200), in phone varchar(100), in city varchar(100), in testGender int)
BEGIN
	if testGender < 0 then
		select w.jmb, w.name, w.surname, w.email, w.phone, w.city, w.street, w.streetNum,
        w.gender, w.userName, w.bank, w.numAccount from working as w where w.jmb like concat('%',jmb,'%') and
		w.name like concat('%', name, '%') and w.surname like concat('%', surname, '%') and w.email like concat('%', email, '%')
		and w.phone like concat('%', phone, '%') and w.city like concat('%', city, '%') and w.hash like concat('%', hash, '%') and
		w.userName like concat('%', userName, '%');
    else
		select w.jmb, w.name, w.surname, w.email, w.phone, w.city, w.street, w.streetNum,
        w.gender, w.userName, w.bank, w.numAccount from working as w where (w.jmb like concat('%',jmb,'%') and
		w.name like concat('%', name, '%') and w.surname like concat('%', surname, '%') and w.email like concat('%', email, '%')
		and w.phone like concat('%', phone, '%') and w.city like concat('%', city, '%') and w.hash like concat('%', hash, '%') and
		w.userName like concat('%', userName, '%')) and w.gender=testGender;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getUser2`(in jmb varchar(13), in name varchar(50), in surname varchar(100))
BEGIN
	select * from
    patient as p
    where p.jmb like concat('%', jmb, '%') and p.name like concat('%', name, '%') and p.surname like concat('%', surname, '%');
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getUserScheduleDates`(in idPersonal char(13))
BEGIN
	select distinct(s.date) from schedule as s where s.personalJmb=idPersonal;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `getUserScheduleDatesShifts`(in idPersonal char(13), in dateWhen date)
BEGIN
	select sh.id, sh.begin, sh.end from schedule as s inner join shift as sh on sh.id=s.id
    where s.date=dateWhen and s.personalJmb=idPersonal;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertAppointment`(in startDate date, in startTime time, in howLong int, in personalJmb char(13), in patientJmb char(13), in note text, out flag bit)
BEGIN
	declare i int default 1;
    declare numIte int default (select count(*) from appointment as a where a.startDate=startDate and a.personalJmb=personalJmb);
	declare Abegin datetime default addtime(convert(startDate, datetime), startTime);
    declare Aend datetime default addtime(addtime(convert(startDate, datetime), startTime), sec_to_time(howLong*60));
    declare Nbegin datetime;
    declare Nend datetime;
    declare howMuchTime int default 0;
    set flag = 1;
    
    foreach: loop
		set @rn = 0;
        set Nbegin = addtime(convert(startDate, datetime), (select a.startTime from (select @rn:=@rn+1 as ind, a.startTime from appointment as a where a.startDate=startDate and a.personalJmb=personalJmb)
        as a where a.ind=i));
        set @rn = 0;
        set Nend = addtime(convert(startDate, datetime), (select a.startTime from (select @rn:=@rn+1 as ind, a.startTime from appointment as a where a.startDate=startDate and a.personalJmb=personalJmb)
        as a where a.ind=i));
        set @rn = 0;
        set howMuchTime = (select a.howLong from (select @rn:=@rn+1 as ind, a.howLong from appointment as a where a.startDate=startDate and a.personalJmb=personalJmb)
        as a where a.ind=i);
        set Nend = addtime(Nend, sec_to_time(howMuchTime*60));
        
        if Abegin <= Nbegin and Aend > Nbegin and Aend > Nbegin
        then
			set flag = 0;
			leave foreach;
		end if;
        
        if Abegin > Nbegin and Abegin < Nend
        then
			set flag = 0;
            leave foreach;
        end if;
        
        set i = i + 1;
        if i > numIte
        then
			leave foreach;
        end if;
    end loop;
    
    if flag = 1
    then
		insert into appointment values(startDate, startTime, howLong, personalJmb, patientJmb, note);
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertBill`(in id int, in cost double, in personalJmb char(13), out flag bit)
BEGIN
	set flag = 1;
    if (select count(*) from bill as b where b.id=id) = 0
    then
		insert into bill values(id, date(now()), time(now()), cost, personalJmb);
    else
		update bill as b 
        set b.dateWhen=date(now()), b.timeWhen=time(now()), b.cost=cost, b.personalJmb=personalJmb
        where b.id=id;
        delete from itembill as ib where ib.id=id;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertBillItem`(in id int, in idIS int)
BEGIN
	insert into ItemBill values(id, idIS);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertElement`(in name varchar(200), in cost double, in descr text, in path varchar(200), in type Enum('service', 'item'))
BEGIN
	if descr = '' then
		set descr = null;
	end if;
    
    insert into ItemAndServices(name, cost, descr, path, type) values(name, cost, descr, path, type);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertLastSeen`(in jmb char(13), in visitId int)
BEGIN
	insert into lastseen values(visitId, jmb, date(now()), time(now()));
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertPatient`(in jmb char(13), in name varchar(50), in surname varchar(100), in email varchar(200),
in phone varchar(100), in city varchar(100), in street varchar(100), in streetNum int, in gender tinyint, out flag bit)
BEGIN
	set flag = 0;
    if ( select count(*) from patient as p where p.jmb=jmb ) = 0 and length(jmb)=13 and length(name)>=2 and length(surname) >=2
    then
		insert into Patient values(jmb, name, surname, email, phone, city, street, streetNum, gender);
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertPersonal`(in jmb char(13), in name varchar(50), in surname varchar(100), in email varchar(100), in phone varchar(100),
in city varchar(100), in street varchar(100), in streetNum int, in gender tinyint, in hash varchar(128), in userName varchar(50), in bank varchar(100),
in numAccount varchar(100), in title varchar(200), in educationPlace varchar(300), out flag bit)
BEGIN
	set flag = 0;
	if (select count(*) from working as w where w.jmb=jmb) = 0 and ((title != '' and educationPlace != '') or (title='' and educationPlace=''))
    then
		insert into working values(jmb, name, surname, email, phone, city, street, streetNum, gender, hash, userName, bank, numAccount);
        insert into personal values(jmb, date(now()), null);
        
        if title!="" and educationPlace!=""
        then
			insert into dentist values(jmb, educationPlace, title);
        end if;
        
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertSchedule`(in idAdmin char(13), in idPersonal char(13), in id int, in dateWhen date, out flag bit)
BEGIN
	declare x int default 1;
    declare rn int default 0;
    declare maxLook int default (select count(*) from schedule as s where s.personalJmb=idPersonal);
    declare Abegin datetime; #a = alredy
    declare Aend datetime;
    declare Nbegin datetime;
    declare Nend datetime; #n = now
	declare flagInput bit default 1;
    set flag = 0;
    
    foreach: loop
        set @rn1 = 0;
        set @rn2 = 0;
        set Abegin = addtime(
			convert(
				(select s.date from
				(select @rn1:=@rn1+1 as ind, s.date from schedule as s where s.personalJmb=idPersonal) as s
                where s.ind=x), datetime
            ), 
            (select sh.begin from
			(select @rn2:=@rn2+1 as ind, s.date, s.id from schedule as s where s.personalJmb=idPersonal) as s inner join shift as sh on sh.id=s.id
			where s.ind=x)
        );
        
        set @rn1 = 0;
        set @rn2 = 0;
        if (select sh.begin from
			(select @rn1:=@rn1+1 as ind, s.date, s.id from schedule as s where s.personalJmb=idPersonal) as s inner join shift as sh on sh.id=s.id
			where s.ind=x) > (select sh.end from
			(select @rn2:=@rn2+1 as ind, s.date, s.id from schedule as s where s.personalJmb=idPersonal) as s inner join shift as sh on sh.id=s.id
			where s.ind=x)
		then
        set @rn1 = 0;
        set @rn2 = 0;
			set Aend = addtime(
			convert(
				(select date_add(s.date, interval 1 day) as days from
				(select @rn1:=@rn1+1 as ind, s.date from schedule as s where s.personalJmb=idPersonal) as s
                where s.ind=x), datetime
            ), 
            (select sh.end from
			(select @rn2:=@rn2+1 as ind, s.date, s.id from schedule as s where s.personalJmb=idPersonal) as s inner join shift as sh on sh.id=s.id
			where s.ind=x)
        );
        else
        set @rn1 = 0;
        set @rn2 = 0;
			set Aend = addtime(
			convert(
				(select s.date from
				(select @rn1:=@rn1+1 as ind, s.date from schedule as s where s.personalJmb=idPersonal) as s
                where s.ind=x), datetime
            ), 
            (select sh.end from
			(select @rn2:=@rn2+1 as ind, s.date, s.id from schedule as s where s.personalJmb=idPersonal) as s inner join shift as sh on sh.id=s.id
			where s.ind=x)
        );
        end if;
        
        set Nbegin = addtime(
			convert(
				dateWhen, datetime
            ), 
            (select sh.begin from
			shift as sh
			where sh.id=id)
        );

        if (select time_to_sec(s.begin)>time_to_sec(s.end) from shift as s where s.id=id)=1
		then
			set Nend = addtime(
			convert(
				date_add(dateWhen, interval 1 day), datetime
            ), 
            (select sh.end from
			shift as sh
			where sh.id=id)
			);
        else
			set Nend = addtime(
			convert(
				dateWhen, datetime
            ), 
            (select sh.end from
			shift as sh
			where sh.id=id)
			);
        end if;
        
        if Abegin > Nbegin and Nend > Abegin
        then
			set flagInput = 0;
            leave foreach;
		end if;
        if Abegin < Nbegin and Aend > Nbegin
        then
			set flagInput = 0;
            leave foreach;
        end if;
        
        set x = x + 1;
        
        if x > maxLook
        then
			leave foreach;
        end if;
    end loop;

	if ( select count(*) from admin as a where a.jmb=idAdmin ) > 0 and flagInput=1
    then
		if ( select count(*) from personal as p where p.jmb=idPersonal ) > 0
        then
			if ( select count(*) from shift as s where s.id=id ) > 0
            then
				insert into schedule values(idAdmin, idPersonal, dateWhen, id);
                set flag = 1;
            end if;
        end if;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertShift`(in begin time, in end time, out flag bit)
BEGIN
	set flag = 0;
    if (select count(*) from shift as s where s.begin=begin and s.end=end ) <= 0 then
		insert into shift(begin, end) values(begin, end);
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertTypeProblem`(in name varchar(100), in descr text, in picturePath varchar(100), out flag bit)
BEGIN
	set flag = 0;
    if (select count(*) from TypeProblem as tp where tp.name=name) = 0
    then
		insert into TypeProblem values(name, descr, picturePath);
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertVisit`(in pJmb char(13), in dJmb char(13), out idOut int)
BEGIN
	if (select max(v.id) from visit as v ) is null
    then 
		set idOut = 1;
    else
		set idOut = (select max(v.id) from visit as v) + 1;
    end if;

    insert into visit(id, patientJmb, dentistJmb, date) values(idOut, pJmb, dJmb, date(now()));
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `insertVisitProblems`(in visitId int, in numTeeth int, in name varchar(100), out flag bit)
BEGIN
	declare num int default 1;
	set flag = 0;

    if ( select count(*) from visit as v where v.id=visitId ) > 0 and (select count(*) from typeproblem as tp where tp.name=name) > 0
    and ((select count(*) from teeth as t where t.numTeeth=numTeeth) > 0 or numTeeth = -1)
    then
		if numTeeth = -1
        then
			insert into problem values(visitId, name, null);
		else
			insert into problem values(visitId, name, numTeeth);
		end if;
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `modifyElement`(in id int, in name varchar(200), in cost double, in descr text, in path varchar(200), in type Enum('service', 'item'), out flag bit)
BEGIN
	set flag = 0;
	if ( select count(*) from ItemAndServices as i where i.id=id ) > 0
    then
		update ItemAndServices as i
        set i.name=name,i.cost=cost,i.descr=descr,i.path=path,i.type=type
        where i.id=id;
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `modifyPatient`(in jmbOld char(13), in jmb char(13), in name varchar(50), in surname varchar(100),
in email varchar(200), in phone varchar(100), in city varchar(100), in street varchar(100), in streetNum int, in gender tinyint, out flag bit)
BEGIN
	set flag = 0;
    if ( select count(*) from patient as p where p.jmb=jmbOld) > 0
    then
		update patient as p
        set p.jmb=jmb, p.name=name, p.surname=surname, p.email=email,p.phone=phone, p.city=city, p.street=street, p.streetNum=streetNum, p.gender=gender
        where p.jmb=jmbOld;
		set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `modifyPersonal`(in jmbOld char(13), in jmb char(13), in name varchar(50), in surname varchar(100), in email varchar(100), in phone varchar(100),
in city varchar(100), in street varchar(100), in streetNum int, in gender tinyint, in userName varchar(50), in bank varchar(100),
in numAccount varchar(100), in title varchar(200), in educationPlace varchar(300), out flag bit)
BEGIN
	set flag = 0;
    if ( select count(*) from working as w where w.jmb=jmbOld ) > 0 and (select count(*) from personal as p where p.jmb=jmbOld) > 0
    then
		update working as w 
		set w.jmb=jmb, w.name=name, w.surname=surname, w.email=email, w.phone=phone, w.city=city, w.street=street, w.streetNum=streetNum, w.gender=gender, w.userName=userName, w.bank=bank, w.numAccount=numAccount
        where w.jmb=jmbOld;
        
        if ( select count(*) from dentist as d where d.jmb=jmbOld )
        then
			update dentist as d
            set d.title=title, d.educationPlace=educationPlace
            where d.jmb=jmbOld;
        end if;
        
        set flag = 1;
    end if;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `selectAppointments`(in startDate date, in dentistJmb char(13), in jmb varchar(13), in name varchar(50), in surname varchar(100))
BEGIN
	select * from appointments as ap inner join patient as p on p.jmb=ap.patientJmb
    where ap.startDate like concat('%', startDate, '%') and ap.dentistJmb like concat('%', dentistJmb, '%')
    and ap.patientJmb like concat('%', jmb, '%') and p.name like concat('%', name,'%') and p.surname like concat('%', surname, '%');
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE `deletePatient` (in id char(13), out flag bit)
BEGIN
	set flag = 0;
    if (select count(*) from patient as p where p.jmb=id) > 0
    then
		delete from patient as p where p.jmb=id;
        set flag = 1;
    end if;
END //
DELIMITER ;


###############
### INSERT
###############

insert into shift(begin, end) values('07:00:00','15:00:00');
insert into shift(begin, end) values('15:00:00','10:00:00');
insert into shift(begin, end) values('10:00:00','16:00:00');

insert into working values('1508997144445', 'Mirko', 'Mirkovic', 'mirko@gmail.com', '066204402', 'Banja Luka', 'jevrejska', 41, 0, 'ae82c59905cdb071b1010be81f0cca7e681775971d34f5452c9cc8bdff09073009583df06f32234bc3f7464310197703413aee7b1f44d32370d77fff6585ede6', 'mirko', 'Sberbank' ,'1111444455551111');
insert into working values('2901997100115', 'Jelena', 'Jelenovic', 'jelena@gmail.com', '066214402', 'Banja Luka', 'Kralja Alfonsa XIII', 11, 1, '24de20a5a7d837c5b7eaaaa73d38013d142d94f5d01862af7d01913f19375a6b4218a2cb2ffff03a8ecb66dd48944341dcdbf7cbd525f30db3d8ee7348d04cbe', 'jelena', 'Sberbank' ,'1111222222221111');
insert into working values('2111997111005', 'Dusko', 'Duskovic', 'dusko@gmail.com', '065901456', 'Banja Luka', 'Zmaj Jovina', 41, 0, 'c6cf9558c99b1ab7b4679368357d7cd0d79dcfedf54aec685a9726108f38b7523f0a519a94dbc75db5fefba3e85d3428fa0c2fc68a987e0309722d2fe001fb52', 'dusko', 'UniCredit' ,'4444444455551111');
insert into working values('2212997994445', 'Lasta', 'Lastovic', 'lasta@outlook.com', '066204991', 'Prnjavor', 'Beogradska', 64, 0, '64f2a60a1868bfd0c5e39f26f06a1bee02781c21ced879dde52e8c2738a88db7b4854dbe8d48d049aae37bfe841d1e70726c51bfc34040a740edd265d7bca24b', 'lasta', 'UniCredit' ,'1111444455559999');
insert into working values('0108997177005', 'Venera', 'Venerovic', 'venera@gmail.com', '066204119', 'Derventa', 'Beogradska', 18, 1, '6f33f3f8375f6e5da41ac55fceae4bcedcf0f657895d3d157313811bd9099935ed34fca170552bc9820a130d6813e37a909fea761cea9af0d9ad0ba813fc60cf', 'venera', 'UniCredit' ,'1111444499991111');
insert into working values('1112997100775', 'Petar', 'Petrovic', 'petar@gmail.com', '066887412', 'Doboj', 'Vojvode Radmora Putnika', 119, 0, 'f6f087a75fc385e944e08b24014345b014d63bf76dca64288438913c3ff1e484ff9d28574e1fb825b66ba2f04743c4109f9b245a978b4391a8f18516388dc986', 'petar', 'Sberbank' ,'7777444455551111');

insert into patient values('0202997101711', 'Augustus', 'Ceaser', 'augustus@outlook.com', '066447412', 'Bijeljina', 'Vojvode Radmora Putnika', 19, 0);
insert into patient values('0201997111111', 'Justinian', 'Ptolomej', 'justinia@outlook.com', '066887412', 'Banja Luka', 'Vojvode Radmora Putnika', 19, 0);
insert into patient values('0204997121711', 'Isabela', 'of Castill', 'isabela@gmail.com', '34610878440 ', 'Doboj', 'Vojvode Radmora Putnika', 46, 1);
insert into patient values('1205997112711', 'Catherine', 'Romanov', 'catherine@outlook.com', '066991199', 'Banja Luka', 'Vojvode Radmora Putnika', 99, 1);

insert into admin values('2111997111005');
insert into admin values('2212997994445');

insert into personal values('1508997144445', '2020-06-19', null);
insert into personal values('0108997177005', '2019-11-17', null);
insert into dentist values('1508997144445', 'Banja Luka of Med', 'Endodontist');
insert into dentist values('0108997177005', 'Dublin of Med', 'General Dentist');
insert into personal values('1112997100775', '2020-12-01', null);
insert into personal values('2901997100115', '2020-12-01', null);

insert into schedule values('2111997111005', '1508997144445', '2022-01-30', 1);
insert into schedule values('2111997111005', '1508997144445', '2022-01-29', 2);
insert into schedule values('2212997994445', '0108997177005', '2022-01-29', 2);
insert into schedule values('2111997111005', '0108997177005', '2022-01-30', 1);
insert into schedule values('2212997994445', '2901997100115', '2022-01-29', 2);
insert into schedule values('2111997111005', '2901997100115', '2022-01-30', 1);
insert into schedule values('2212997994445', '1112997100775', '2022-01-29', 2);
insert into schedule values('2212997994445', '1112997100775', '2022-01-30', 1);

#insert into termin values(1, '14:00:00', '2020-01-29', 'Osoba zeli da pregleda zube.', '0202997101711', '1508997144445');
#insert into termin values(2, '11:00:00', '2020-01-30', 'Wisdom Tooth Extraction', '0201997111111', '0108997177005');
#insert into termin values(3, '11:55:00', '2022-01-30', null, '0204997121711', '0108997177005');

insert into appointment values('2021-01-29', '14:00:00', 45, '0108997177005', '0202997101711', 'Osoba Zeli pregled zuba.');
insert into appointment values('2021-01-30', '9:00:00', 120, '0108997177005', '0201997111111', 'Wisdom Tooth Extraction');
insert into appointment values('2021-01-30', '13:30:00', 30, '1508997144445', '0204997121711', null);

insert into TypeProblem values('Gum Pain', null, null);
insert into TypeProblem values('Jaw popping', 'Jaw popping refers to a clicking sound from the jaw, which can be accompanied by sensations of pain.', null);
insert into TypeProblem values('Tooth erosion', null, null);

insert teeth values(1);
insert teeth values(2);
insert teeth values(3);
insert teeth values(4);
insert teeth values(5);
insert teeth values(6);
insert teeth values(7);
insert teeth values(8);
insert teeth values(9);
insert teeth values(10);
insert teeth values(11);
insert teeth values(12);
insert teeth values(13);
insert teeth values(14);
insert teeth values(15);
insert teeth values(16);
insert teeth values(17);
insert teeth values(18);
insert teeth values(19);
insert teeth values(20);
insert teeth values(21);
insert teeth values(22);
insert teeth values(23);
insert teeth values(24);
insert teeth values(25);
insert teeth values(26);
insert teeth values(27);
insert teeth values(28);
insert teeth values(29);
insert teeth values(30);
insert teeth values(31);
insert teeth values(32);

insert into Visit values(1, '2021-12-15', '0202997101711', '1508997144445');
insert into Visit values(2, '2021-11-15', '0202997101711', '1508997144445');

insert into Problem values(1, 'Gum Pain', null);
insert into Problem values(1, 'Jaw popping', null);
insert into Problem values(2, 'Jaw popping', 16);

insert into ItemAndServices values(1, 'Teeth Check', 19.99, 'Dentist check the teeth if there is some kind of damage or other negativ stuff.', null, 'service');
insert into ItemAndServices values(2, 'Removing Teeth', 29.99, null, null, 'service');
insert into ItemAndServices values(3, 'Cleaning Teeth', 49.99, null, null, 'service');
insert into ItemAndServices values(4, 'Teeth', 299.99, 'New teeth with given dimension.', null, 'item');
insert into ItemAndServices values(5, 'Prosthesis', 179.99, null, null, 'item');

insert into Bill values(1, '2021-12-15', '11:05:56', 199.98, '1508997144445');
insert into Bill values(2, '2021-11-15', '19:45:11', 19.99, '2901997100115');

insert into ItemBill values(1, 1);
insert into ItemBill values(1, 5);
insert into ItemBill values(2, 1);















