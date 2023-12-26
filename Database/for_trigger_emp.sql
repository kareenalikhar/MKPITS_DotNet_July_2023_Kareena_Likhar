create table employee(
empid int primary key,empname varchar(20))

create table EmpLog(
LogId int identity not null,
EmpId int not null,
Operation nvarchar(10) not null,
Updateddate datetime not null);

create trigger tr5
on employee
for insert
as
insert into EmpLog(Empid,Operation,Updateddate)
select empid,'insert',GETDATE()
from inserted;

insert into employee(empid,empname) values(189,'yashit')

select * from employee
select * from EmpLog