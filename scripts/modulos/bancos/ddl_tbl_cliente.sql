-- ================================================================
-- Área   : Bancos
-- Autor  : André De Jesús Gonzalez Camey
-- Carné  : 9959-23-3117
-- Fecha  : 24/11/2026
-- ================================================================
-- Propósito :
--  LDD de la tabla tbl_cliente, usada por el mantenimiento de
--  Clientes del módulo Bancos (aplicación 8014).
-- ================================================================

CREATE TABLE IF NOT EXISTS tbl_cliente (
    pk_idCliente int NOT NULL,
    nombreCliente varchar(50),
    direccionCliente varchar(30),
    telefonoCliente varchar(20),
    estadoCliente int,
    PRIMARY KEY (pk_idCliente)
);
