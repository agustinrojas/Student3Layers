use StudentDB;
GO

create table Students(
	UUID nvarchar(30),
	Id int identity (1,1) primary key,
	Nombre nvarchar(15),
	Apellido nvarchar(50),
	Dni nvarchar(25),
	DateRegistry nvarchar(20),
	DateBorn nvarchar(20),
	Edad int
);
GO