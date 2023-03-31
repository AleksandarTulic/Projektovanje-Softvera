create user if not exists 'admin'@'localhost' identified by 'Admin#219A912';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Worker TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Personal TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Admin TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Dentist TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Counter TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Shift TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Schedule TO 'admin'@'localhost';
GRANT SELECT, UPDATE, DELETE ON Dentil.Appointment TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.HistoryVisit TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.Problem TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.VisitService TO 'admin'@'localhost';
GRANT SELECT, UPDATE, DELETE ON Dentil.Visit TO 'admin'@'localhost';
GRANT SELECT ON Dentil.Patient TO 'admin'@'localhost';
GRANT SELECT ON Dentil.Service TO 'admin'@'localhost';
GRANT SELECT ON Dentil.TypeProblem TO 'admin'@'localhost';

create user if not exists 'counter'@'localhost' identified by 'Counter#719C917';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Patient TO 'counter'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Appointment TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Worker TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Personal TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Counter TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Dentist TO 'counter'@'localhost'; ### input appointment we need idDentist
GRANT SELECT ON Dentil.Schedule TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Shift TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.HistoryVisit TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.Problem TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.VisitService TO 'counter'@'localhost';
GRANT SELECT, UPDATE, DELETE ON Dentil.Visit TO 'counter'@'localhost';

CREATE USER IF NOT EXISTS 'dentist'@'localhost' IDENTIFIED BY 'Dentist#459B945';

GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.admin TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.appointment TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.counter TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.dentist TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.historyvisit TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.patient TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.personal TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.problem TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.schedule TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.service TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.shift TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.tooth TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.typeproblem TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.visit TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.visitservice TO 'dentist'@'localhost';
GRANT CREATE, INSERT, UPDATE, DELETE, SELECT on Dentil.worker TO 'dentist'@'localhost';

#only admin can do updates and delete on admin, personal, dentist, counter because they created them