create database Tienda
go

use Tienda
go

create table Producto (
id int identity (1,1) primary key,
nombre varchar(50),
precio decimal (8,2),
idCategoria int
foreign key (idCategoria) references Categoria (id_Categoria)
);
go

create table Categoria(
id_Categoria int identity (1,1) primary key,
nombre_Categoria varchar(50),
);
go

insert into Producto values ('Manzana', 8, 1),
('Regriferador', 150, 2),
('Vestido', 15, 3)

insert into Categoria values ('Comida'),
('Electrodomestico'),
('Vestuario')

create view VerProductos as
select id, nombre, precio, nombre_Categoria as categoria from Producto
inner join
Categoria on Categoria.id_Categoria=Producto.idCategoria

select *from VerProductos
where nombre like '%es%'