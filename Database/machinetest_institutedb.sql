create database institutedb

create table TableNation(NationID int primary key,
NationName varchar(500));

insert into TableNation values(1,'India'),(2,'Afghanistan'),(3,'Maldives'),(4,'Mali'),(5,'Bangladesh');

create table TableState(StateID int primary key,
NationID int,StateName varchar(500),
foreign key (NationID)
references TableNation(NationID));

insert into TableState values(123,1,'Maharshtra'),(124
,2,'Kandahar'),(125,3,'Asia'),(126,4,'Sahara'),(127,5,'Dhaka');

create table TableCity(CityID int primary key,StateID int,CityName varchar(500),
foreign key(StateID) 
references TableState(StateID));

insert into TableCity values(111,123,'Nagpur'),(222,124,'Spin'),(333,125,'Bangkok'),(444,126,'Smara'),(555,127,'Tungi');

create table TableCourseRegDetail(CourseRegID int primary key,CategoryID int,
FullName varchar(1500),GenderId int);

insert into TableCourseRegDetail values(987,147,'Kareena',2),(654,258,'Pooja',2),(321,369,'Sarang',1),(984,148,'Akash',1),(651,259,'David',1);

create table TableRegAddress(RegAddressID int primary key,
CourseRegID int,NationID int,StateID int,CityID int,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID),
foreign key(NationID) references TableNation(NationID),
foreign key(StateID) references TableState(StateID),
foreign key(CityID) references TableCity(CityID));

insert into TableRegAddress values(1,987,1,123,111),(2,654,2,124,222),(3,321,2,125,333),(4,984,3,126,444),(5,651,4,127,555);

create table TableFeeDetail(FeeID int,CourseRegID int,TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,PaidDate datetime,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID));

insert into TableFeeDetail values(12,987,7000,1000,4000,3000,'2023/12/1'),
(13,654,8000,1500,4000,4000,'2023/12/3'),(14,321,9000,400,5000,4000,'2023/12/2'),
(14,984,4500,500,4000,500,'2023/12/4'),(15,651,7500,400,4000,3500,'2023/12/5');

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail


