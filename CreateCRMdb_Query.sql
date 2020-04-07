create database CRMdb
go

use CRMdb
go

--User module - base

create table Roles
(
	RoleValue nvarchar(100) primary key
)

insert into Roles(RoleValue) values ('UserM')

create table Users
(
	Id uniqueidentifier default newsequentialid() primary key,
	[Login] nvarchar(100) not null unique,
	[Password] nvarchar(100) not null,

	Phone nvarchar(100) null unique,
	Email nvarchar(100) null unique
)

create table UserRoles
(
	UserId uniqueidentifier foreign key references Users(Id) on delete cascade on update cascade not null,
	RoleId nvarchar(100) foreign key references Roles(RoleValue) on delete cascade  on update cascade not null,
	constraint PK_UserRole primary key clustered (UserId, RoleId)
)

go

--Customer module 

insert into Roles(RoleValue) values ('CustomerM')

create table Customers
(
	Id uniqueidentifier default newsequentialid() primary key,

	UserId uniqueidentifier foreign key references Users(Id) on delete set null on update cascade null, -- This client's current manager
	
	FirstName nvarchar(100) not null,
	SecondName nvarchar(100) not null,
	LastName nvarchar(100) null,
	Phone nvarchar(100) null unique,
	Email nvarchar(100) null unique,
)

create table Orders
(
	Id uniqueidentifier default newsequentialid() primary key, 
	CustomerId uniqueidentifier foreign key references Customers(Id) on delete cascade on update cascade not null,

	[Description] nvarchar(max) not null,
	[Status] nvarchar(100) not null,
	OpenDate date not null,
	CloseDate date not null
)
go

--Product module

insert into Roles(RoleValue) values ('ProductM')

create table ProductTypes
(
	Id uniqueidentifier primary key default newsequentialid(),

	[Description] nvarchar(max) not null,
	Price money default 0 not null
)

create table ConcreteProducts
(
	Id uniqueidentifier primary key default newsequentialid(),
	ProductTypeId uniqueidentifier foreign key references ProductTypes(Id) on delete cascade on update cascade not null,
	Sold bit default 0 not null
)
go

--Order module : Client, Product

insert into Roles(RoleValue) values ('OrderM')

create table OrderLineProducts
(
	ConcreteProductId uniqueidentifier primary key foreign key references ConcreteProducts(Id) on delete cascade on update cascade, 
	OrderId uniqueidentifier foreign key references Orders(Id) on delete cascade on update cascade not null
)
go