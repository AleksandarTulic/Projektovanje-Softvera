create user if not exists 'admin'@'localhost' identified by 'Admin#219A912';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Working TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Personal TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Admin TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Dentist TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Counter TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Shift TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Schedule TO 'admin'@'localhost';

create user if not exists 'counter'@'localhost' identified by 'Counter#719C917';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Patient TO 'counter'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Appointment TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Working TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Personal TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Counter TO 'counter'@'localhost';
GRANT SELECT ON Dentil.Dentist TO 'counter'@'localhost'; ### input appointment we need idDentist

#only admin can do updates and delete on admin, personal, dentist, counter because they created them