create database dbOPSRS;
use dbOPSRS;
create table staff (
staffId int(6) not null,
staffName varchar(20) not null,
staffPosition varchar(20) not null,
staffpwd varchar(20) not null,
primary key (staffId)
);
insert into staff values (000001, 'Peter', 'clerk', '12345');