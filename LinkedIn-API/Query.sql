USE Radar;
SELECT * FROM Usuarios;

USE Radar;
INSERT INTO Usuarios VALUES
(NEWID(), 'Lauro', 'lauro@email.com', '-23.618810', 0, GETDATE());
SELECT * FROM Usuarios;