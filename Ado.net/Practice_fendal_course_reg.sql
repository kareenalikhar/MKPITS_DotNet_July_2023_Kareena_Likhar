create table TableNation(NationId int primary key,NationName varchar(500));

create table TableState(StateId int primary key,StateName varchar(500),NationId int,
foreign key(NationId) references TableNation(NationId));

create table TableCity(CityId int primary key,CityName varchar(500),StateId int,
foreign key(StateId) references TableState(StateId));

create table TableCourseRegDetail(CourseRegId int identity primary key,CategoryId int,FullName Varchar(1500),GenderId int);

create table TableRegAddress(RegAddressId int identity primary key, CourseRegId int,NationId int,StateId int,CityId int,
foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId),
foreign key(NationId) references TableNation(NationId),
foreign key(StateId) references TableState(StateId),
foreign key(CityId) references TableCity(CityId));

create table TableFeeDetail(FeeId int identity primary key,CourseRegId int,TotalAmount decimal,MinPer decimal,PaidAmount decimal,BalAmount decimal,PaidDate datetime,
foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId));

insert into TableNation values(1,'India'),(2,'United Nation');
insert into TableState values(101,'Andra Pradesh',1),(102,'Maharashtra',1),(103,'California',2),(104,'Florida',2);
insert into TableCity values(1001,'Vishakhapatnam',101),(1002,'Vijayvada',101),(1003,'Nagpur',102),(1004,'Pune',102),
(1005,'Los Angeles',103),(1006,'San Jose',103),(1007,'Miami',104),(1008,'Tampa',104);

select * from TableNation
select * from TableState
select * from TableCity

select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail

