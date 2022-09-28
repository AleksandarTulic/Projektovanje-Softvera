create user if not exists 'admin'@'localhost' identified by 'Admin#219A912';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Working TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Personal TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Admin TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Dentist TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Counter TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Shift TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Schedule TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.Appointment TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.LastSeen TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.Problem TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.VisitTreatment TO 'admin'@'localhost';
GRANT SELECT, DELETE ON Dentil.Visit TO 'admin'@'localhost';

create user if not exists 'counter'@'localhost' identified by 'Counter#719C917';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Patient TO 'counter'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Appointment TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Working TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Personal TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Counter TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Dentist TO 'counter'@'localhost'; ### input appointment we need idDentist
GRANT SELECT ON Dentil.Schedule TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Shift TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.LastSeen TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.Problem TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.VisitTreatment TO 'counter'@'localhost';
GRANT SELECT, DELETE ON Dentil.Visit TO 'counter'@'localhost';

#only admin can do updates and delete on admin, personal, dentist, counter because they created them