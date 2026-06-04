-- Insertar cursos primero
INSERT INTO CURSOS (CICLO, ALIAS, NOMBRECURSO)
VALUES 
(1, 'DAM', 'Desarrollo de Aplicaciones Multiplataforma'),
(2, 'ASIR', 'Administracion de Sistemas Informaticos en Red');

-- Insertar 5 alumnos
INSERT INTO ALUMNOS 
(DNI, HORASTOTALES, NOMBRE, [APELLIDO 1], [APELLIDO 2], CICLO, ALIAS)
VALUES
('06729414M', 120, 'Carlos', 'Perez', 'Lopez', 1, 'DAM'),
('94354779Q', 95, 'Lucia', 'Martinez', 'Sanchez', 1, 'DAM'),
('76128156L', 150, 'Javier', 'Gomez', 'Ruiz', 2, 'ASIR'),
('33664295T', 80, 'Marta', 'Fernandez', 'Gil', 1, 'DAM'),
('04678273G', 110, 'Pablo', 'Navarro', 'Diaz', 2, 'ASIR');
