create database Biblioteca

use Biblioteca

create table libros(
Cod_Libro bigint identity (1,1) primary key not null,
Nombre_Libro nvarchar (50),
Genero nvarchar (25),
Fecha_Edicion smalldatetime not null,
Precio_Libro money,
Cantidad int,													/*Talvez*/
)

create table Usuarios(
Cod_Usuario bigint identity (1,1) primary key not null,
Nombre nvarchar (25), 
Apellido nvarchar (25),  
Telefono int,
Pais nvarchar (50),
Domicilio nvarchar (50),
Email nvarchar (25),
Fecha_Nac smalldatetime 
)

create table Prestamos(
NumOrden bigint identity (1,1) primary key not null,
Fecha_Salida smalldatetime not null,
Fecha_MaxDevolucion smalldatetime not null,
Fecha_Devolucion smalldatetime not null,
Cantidad_Prestada int,											 /*Talvez*/
Cod_Libro bigint not null foreign key references Libros (Cod_Libro),
Cod_Usuario bigint not null foreign key references Usuarios (Cod_Usuario)
)

create table Autor(
Cod_autor bigint identity (1,1) primary key not null,
Nombre nvarchar (25), 
Telefono int,
Pais nvarchar (50),
Email nvarchar (25),
)

create table Libro_Autor(

Cod_Libro bigint not null foreign key references Libros (Cod_Libro),
Cod_autor bigint not null foreign key references Autor (Cod_autor)

)

