create user if not exists 'admin'@'localhost' identified by 'Admin#219A912';

GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Working TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Personal TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Admin TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Dentist TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Counter TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Shift TO 'admin'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON Dentil.Schedule TO 'admin'@'localhost';