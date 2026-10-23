CREATE DATABASE optica_test;
USE optica_test;

CREATE TABLE clientes (
	cliente_id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    edad INT,
    correo VARCHAR(150) NOT NULL UNIQUE,
    telefono VARCHAR(20),
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP
    );
    
SELECT * FROM clientes;    

INSERT INTO clientes (nombre, apellido, edad, correo, telefono)
VALUES
	('Jose', 'Elpro', 31, 'joseelpro2026@gmail.com', 6865555555);