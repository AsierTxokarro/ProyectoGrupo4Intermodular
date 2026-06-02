Select * From Alumnos
INSERT INTO JORNADAS (FECHA, DNI, DURACION)
VALUES 
('20260518', '06729414M', 8), -- Jornada para Carlos
('20260519', '06729414M', 6), -- Otra jornada para Carlos
('20260519', '23456789B', 7), -- Jornada para Lucía
('20260519', '45678901D', 5); -- Jornada para Marta


INSERT INTO TAREASREALIZADAS (CODIGOTAREA, FECHAJORNADA, DNI, DESCRIPCION, DURACION)
VALUES 
(1, '20260518', '06729414M', 'Diseño del modelo entidad-relación', 4),
(2, '20260518', '06729414M', 'Creación de tablas en SQL Server', 4),
(3, '20260519', '06729414M', 'Pruebas de sentencias INSERT y SELECT', 6),
(4, '20260519', '23456789B', 'Desarrollo de la interfaz de login', 7),
(5, '20260519', '45678901D', 'Documentación técnica del proyecto', 5);

-- 1. Primero un módulo de ejemplo (usando el ciclo '1' y alias 'DAM' que tienen tus alumnos)
INSERT INTO MODULOS (CodigoModulo, NombreM, Ciclo, Alias)
VALUES ('0484', 'Bases de Datos', '1', 'DAM');
-- 2. Un Resultado de Aprendizaje (RA) para ese módulo (ahora con el número 3)
INSERT INTO RAS (Ra, Descripcion, CodigoModulo, Ciclo, Alias)
VALUES (3, 'Realización de consultas', '0484', '1', 'DAM');

-- 3. Vincular la tarea de Carlos en la tabla INCLUYEN (usando el número 3)
INSERT INTO INCLUYEN (CodigoTarea, FechaJornada, Dni, CodigoModulo, Ciclo, Alias, RA)
VALUES (1, '20260518', '12345678A', '0484', '1', 'DAM', 3);

INSERT INTO INCLUYEN (CodigoTarea, FechaJornada, Dni, CodigoModulo, Ciclo, Alias, RA)
VALUES 
(2, '20260518', '12345678A', '0484', '1', 'DAM', 3), -- Tarea 2 de Carlos
(3, '20260519', '12345678A', '0484', '1', 'DAM', 3); -- Tarea 3 de Carlos

select * from TAREASREALIZADAS
