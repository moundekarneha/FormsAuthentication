create database EmpData
go
use EmpData
go
create table Emp
(
id int primary key identity,
name varchar(60),
dept varchar(60),
salary int
)
go
select * from Emp
go
create table UserT
(
id int primary key identity,
username varchar(60),
pass varchar(60)
)