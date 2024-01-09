create table TableNation(NationID int primary key,
NationName varchar(500));

insert into TableNation values(1,'India'),(2,'United Nation'),(3,'Nepal'),(4,'Sri Lanka');

create table TableState(StateID int primary key,
StateName varchar(500),NationID int,
foreign key (NationID)
references TableNation(NationID));

insert into TableState values(101,'Andhra Pradesh',1),(102,'Punjab',1),(103,'Califonia',2),(104,'Florida',2),(105,'Koshi',3),(106,'Bagmati',3),(107,'Colombo',4),(108,'Ratnapra',4);

create table TableCity(CityID int primary key,CityName varchar(500),StateID int,
foreign key(StateID) 
references TableState(StateID));

insert into TableCity values(1001,'Visakhapatnam',101),(1002,'Vijayvada',101),(1003,'Guntur',101),
(1004,'Amritsar',102),(1005,'Jalandar',102),(1006,'Chandigarh',102),
(1007,'Los Angeles',103),(1008,'San Jose',103),(1009,'San Diego',103),
(1010,'Jacksonville',104),(1011,'Miami',104),(1012,'Tampa',104),
(1013,'Damak',105),(1014,'Dharan',105),(1015,'Biratnagar',105),
(1016,'Banepa',106),(1017,'Bharatpur',106),(1018,'Hetauda',106),
(1019,'Grandpass',107),(1020,'Borella',107),(1021,'Pettah',107),
(1022,'Balangoda',108),(1023,'Kolonna',108),(1024,'Panamure',108);

select * from TableNation
select * from TableState
select * from TableCity

create table TableCourseRegDetail(CourseRegID int identity primary key,CategoryID int,
FullName varchar(1500),GenderId int);

create table TableRegAddress(RegAddressID int identity primary key,
CourseRegID int,NationID int,StateID int,CityID int,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID),
foreign key(NationID) references TableNation(NationID),
foreign key(StateID) references TableState(StateID),
foreign key(CityID) references TableCity(CityID));

create table TableFeeDetail(FeeID int identity,CourseRegID int,TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,PaidDate datetime,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID));

select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail