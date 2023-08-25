create database Practica
go
use Practica
create table Productos 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)
insert into Productos 
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)
go

create proc InsertarProductos
@nombre nvarchar(100),
@desc nvarchar(100),
@marca nvarchar(100),
@precio float,
@stock int
as
insert into Productos 
values
(
@nombre,
@desc,
@marca,
@precio,
@stock
)
go

create proc EditarProductos
@id int,
@nombre nvarchar(100),
@desc nvarchar(100),
@marca nvarchar(100),
@precio float,
@stock int
as
update Productos set
Nombre = @nombre,
Descripcion = @desc,
Marca = @marca,
Precio = @precio,
Stock = @stock
where Id = @id
go

create procedure eliminarProcducto
@id int
as
delete from Productos
where Id = @id
go

create Proc MostrarProductos
as
select * from Productos

