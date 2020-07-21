--Create Database ReporteEntid
 --use ReporteEntid
-- go


 Create Table Beneficiarios4

(	Num_Correlativo Numeric (3,0)  NOT NULL,
	RUT_CAUSANTE CHAR(50) not NULL,
	NOMBRE_CAUSANTE VARCHAR (50) NOT NULL,
	CODIGO_TIPO_CAUSANTE VARCHAR (50)  NOT NULL,
	TIPO_CAUSANTE VARCHAR (200) NOT NULL,
	Rut_Beneficiario VARCHAR (12) NOT NULL ,---CLAVE PRIMARIA-------------------
	NOMBRE_BENEFICIARIO VARCHAR(50) NOT NULL,
	CODIGO_TIPO_BENEFICIARIO VARCHAR (200) NOT NULL,
	TIPO_BENEFICIARIO VARCHAR (50) NOT NULL,
	CODIGO_TIPO_BENEFICIO VARCHAR (50)NOT NULL,
	TIPO_BENEFICIO VARCHAR(50) NOT NULL,
	RUT_EMPLEADOR VARCHAR(50) NOT NULL,
	NOMBRE_EMPLEADOR VARCHAR (200) NOT NULL,
	FECHA_RECONOCIMIENTO date  NULL,
	TRAMO VARCHAR (200) NOT NULL,
	MONTO_BENEFICIO VARCHAR (200) NOT NULL,
	CODIGO_ESTADO_TUPLA VARCHAR (200) NOT NULL,
	GLOSA_ESTADO_TUPLA VARCHAR(200) NOT NULL,
	RentaPromedio int  NULL
						
)



CREATE TABLE Renta
(

[Id_Funcionario] [smallint] NOT NULL,---CLAVE PRIMARIA
	[Activo] [smallint] NULL,
	[Rut_Beneficiario] [varchar](12) NULL,
	[Apellidos] [varchar](40) NULL,
	[Nombres] [varchar](40) NULL,
	[Sexo] [smallint] NULL,--1 MASCULINO ,2 FEMENINO
	[EstadoCivil] [smallint] NULL,---1, CASADO ,2 SOLTERO
	[Fec_Nacimiento] [datetime] NULL,
	[Direccion] [varchar](40) NULL,
	[RentaPromedio] [int] NULL
)

create table Usuario1
(
	ID VARCHAR (50) NOT NULL,
	nombre_causante varchar (50)  not null,---BORRAR EL CAUSANTE, SOLO DEBE QUEDAR NOMBRE
	Contraseña CHAR (10) NOT NULL,
   
)

----Creando las Primary Keys 
ALTER TABLE Beneficiarios4
ADD CONSTRAINT PK_Beneficiarios4 PRIMARY KEY (Rut_Beneficiario);

ALTER TABLE Renta
ADD CONSTRAINT PK_Renta PRIMARY KEY (Id_Funcionario);

ALTER TABLE Usuario1
add constraint PK_Usuario1 PRIMARY KEY (ID);

---CREANDO ENTIDAD DE DOMINIO--

ALTER TABLE RENTA
ADD CONSTRAINT CK_EstadoCivil CHECK (EstadoCivil in(1,2));

ALTER TABLE RENTA
ADD CONSTRAINT CK_Sexo CHECK (Sexo in(1,2));

----Creando Entidad Referencial (FK)

ALTER TABLE Renta
ADD CONSTRAINT FK_Beneficiarios4_Renta FOREIGN KEY (Rut_Beneficiario)
REFERENCES Beneficiarios4 (Rut_Beneficiario)


select * from Beneficiarios4



----DATOS---

INSERT INTO Usuario1 VALUES ('1','Felipe Acevedo','1234');
INSERT INTO Usuario1 VALUES ('2','Maria Olivares','12345');

---CONSULTA

Select RENTA.RentaPromedio FROM Beneficiarios4 INNER JOIN Renta ON Beneficiarios4.RUT_BENEFICIARIO=Renta.Rut_Beneficiario;

select * from Beneficiarios4

drop table beneficiarios4
drop table renta

--select * from renta

---select * from beneficiarios4