create database Udemy
go

use Udemy
go

create table Estudiante(
	idEst int primary key identity,
	nombres varchar(60),
	apellidos varchar(70),
	telefono varchar(9),
	correo varchar(70),
	contrasennia varchar(100) 
)
go

create table Categoria(
	idCategoria int primary key identity,
	nomCat varchar(60)
)
go

create table Curso(
	idCurso int primary key identity,
	idCategoria int,
	nomCurso varchar(60),
	descripcion varchar(300),
	profesor varchar(70),
	fechaPublicacion date,
	videoUrl varchar(200),
	imagenUrl varchar(200),
	foreign key(idCategoria)references Categoria(idCategoria)
)
go

create table Favoritos(
	idFavorito int primary key identity,
	idCurso int,
	idEst int,
	foreign key(idCurso)references Curso(idCurso),
	foreign key(idEst)references Estudiante(idEst)
)
go

insert into Estudiante values('Juan Carlos' , 'Gomez Palacios' , '985478563', 'juan.gomez@gmail.com' , '123456')
insert into Estudiante values('Luciana' , 'Fernandez Carbajal' , '965412563', 'luciana.fernandez@gmail.com' , '123456')

insert into Categoria values('Desarrollo')
insert into Categoria values('Negocios')
insert into Categoria values('Informatica y Software')
insert into Categoria values('Diseño')
insert into Categoria values('Marketing')

insert into Curso values(1 , 'Curso Completo Python 3 - Desde las Bases hasta Django','Django,Flask,Bases del lenguaje, Programación Orientada a Objetos, Lectura y Escritura de Archivos y Bases de Datos','Lucas Moy', '2022-01-12','https://www.youtube.com/watch?v=swdcD6OPMlk' ,'https://s3-us-west-2.amazonaws.com/devcodepro/media/courses/opengraph_curso_python.png')
insert into Curso values(1 , 'React - Pruebas unitarias y de integracio?n','Context API, MERN, Hooks, Firestore, y mucho más','Fernando Herrera', '2021-05-12','https://www.youtube.com/watch?v=qqvDmYA5fuk' ,'https://cdn-thumbs.comidoc.net/750/3096364_6113_3.jpg')

insert into Favoritos values(1,2)

select * from Categoria
