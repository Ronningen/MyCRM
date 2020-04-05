create database CRMdb
go

use CRMdb
go

--UserM module

create table Roles
(
	Id int primary key identity(1,1),
	[Value] nvarchar(max) not null unique
)

create table Offices
(
	Id int primary key identity(1,1),
	[Name] nvarchar(max) not null unique,
	Deleted bit default 0 not null
)

create table Users
(
	Id int primary key identity(1,1),
	[Login] nvarchar(max) not null unique,
	[Password] nvarchar(max) not null,
	OfficeId int foreign key references Offices(Id) on delete cascade not null,
	Deleted bit default 0 not null
)

create table UserRoles
(
	UserId int foreign key references Users(Id) on delete cascade primary key,
	RoleId int foreign key references Roles(Id) on delete cascade primary key,
	constraint PK_UserRole primary key (UserId, RoleId)
)
go

insert into Roles([Value]) values ('UserM'), ('ClientM'), ('ProductM'), ('OrderM')
go


--ProductM module

create table ProductTypes
(
	Id int primary key identity(1,1),
	[Name] nvarchar(max) not null unique,
	[Description] nvarchar(max) null,
	Price money default 0 not null,
	Deleted bit default 0 not null
)

create table ConcreteProducts
(
	Id int primary key identity(1,1),
	ProductTypeId int foreign key references ProductTypes(Id) on delete cascade not null,
	Deleted bit default 0 not null
)
go

--ClientM module

create table Clients
(
	Id int primary key identity(1,1),
	FirstName nvarchar(max) not null,
	SecondName nvarchar(max) not null,
	LastName nvarchar(max) null,
	Phone nvarchar(max) null,
	Email nvarchar(max) null,
	UserId int foreign key references Users(Id) on delete cascade not null, -- This client's manager
	Deleted bit default 0 not null
)

create table Orders
(
	Id int primary key identity(1,1),
	ClientId int foreign key references Clients(Id) on delete cascade not null,
	[Description] nvarchar(max) not null,
	[Status] nvarchar(max) not null default N'Requested',
	OpenDate date not null,
	CloseDate date not null,
	Deleted bit default 0 not null
)