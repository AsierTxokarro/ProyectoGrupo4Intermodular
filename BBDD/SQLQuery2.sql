INSERT INTO JORNADAS (FECHA, DNI, DURACION)
VALUES 
('20260518', '06729414M', 8), -- Jornada para Carlos
('20260519', '06729414M', 6), -- Otra jornada para Carlos
('20260519', '94354779Q', 7), -- Jornada para Lucía
('20260519', '33664295T', 5); -- Jornada para Marta


INSERT INTO TAREASREALIZADAS (CODIGOTAREA, FECHAJORNADA, DNI, DESCRIPCION, DURACION)
VALUES 
(1, '20260518', '06729414M', 'Diseño del modelo entidad-relación', 4),
(2, '20260518', '06729414M', 'Creación de tablas en SQL Server', 4),
(1, '20260519', '06729414M', 'Pruebas de sentencias INSERT y SELECT', 6),
(1, '20260519', '94354779Q', 'Desarrollo de la interfaz de login', 7),
(1, '20260519', '33664295T', 'Documentación técnica del proyecto', 5);

-- 1. Primero un módulo de ejemplo (usando el ciclo '1' y alias 'DAM' que tienen tus alumnos)
INSERT INTO MODULOS (CodigoModulo, NombreM, Ciclo, Alias)
VALUES ('0481', 'Bases de Datos', '1', 'DAM'),
('0482', 'Programación', '1', 'DAM'),
('0483', 'Lenguaje de Marcas', '1', 'DAM'),
('0381', 'Servicios de red e internet', '2', 'ASIR'),
('0382', 'Implantación de aplicaciones web', '2', 'ASIR');

-- 2. Un Resultado de Aprendizaje (RA) para ese módulo
INSERT INTO RAS (Ra, Descripcion, CodigoModulo, Ciclo, Alias)
VALUES
(1, 'Realización de consultas', '0481', '1', 'DAM'),
(2, 'Crear bases de datos a través de lenguaje SQL', '0481', '1', 'DAM'),
(3, 'Realizar diagramas ER', '0481', '1', 'DAM'),
(1, 'Reconocer la estructura de un programa informático', '0482', '1', 'DAM'),
(2, 'Escribir y depurar código', '0482', '1', 'DAM'),
(3, 'Gestionar información almacenada en bases de datos relacionales', '0482', '1', 'DAM'),
(1, 'Reconocer las características de lenguajes de marcas', '0483', '1', 'DAM'),
(2, 'Utilizar lenguajes de marcas para la transmisión de información a través de la web', '0483', '1', 'DAM'),
(3, 'Establecer mecanismos de validación', '0483', '1', 'DAM'),
(1, 'Instalar y administrar servicios de resolución de nombres', '0381', '2', 'ASIR'),
(2, 'Administrar servicios de configuración y asignación de direcciones IP', '0381', '2', 'ASIR'),
(3, 'Configurar y administrar servicios de transferencia de archivos y servidores web', '0381', '2', 'ASIR'),
(1, 'Instalar, configurar e integrar servidores web y de bases de datos', '0382', '2', 'ASIR'),
(2, 'Seleccionar y desplegar plataformas de gestión de contenido', '0382', '2', 'ASIR'),
(3, 'Desplegar e integrar aplicaciones en red', '0382', '2', 'ASIR');

-- 3. Vincular la tarea de Carlos en la tabla INCLUYEN
INSERT INTO INCLUYEN (CodigoTarea, FechaJornada, Dni, CodigoModulo, Ciclo, Alias, RA)
VALUES (1, '20260518', '06729414M', '0481', '1', 'DAM', 3);

INSERT INTO INCLUYEN (CodigoTarea, FechaJornada, Dni, CodigoModulo, Ciclo, Alias, RA)
VALUES 
(1, '20260518', '06729414M', '0481', '1', 'DAM', 2),
(1, '20260518', '06729414M', '0482', '1', 'DAM', 1),
(2, '20260518', '06729414M', '0481', '1', 'DAM', 3),
(1, '20260519', '06729414M', '0481', '1', 'DAM', 3);
