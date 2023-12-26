create table memployee(
empid int primary key,
empname varchar(20) not null);

create table mEmpLog(
LogId int identity not null,
EmpID int not null,
operation nvarchar(10) not null,
updatedate datetime not null);

create trigger emptri
on memployee
for insert
as 
insert into mEmpLog(empid,operation,updatedate)
select empid,'insert',GETDATE()
from inserted

insert into memployee values(123,'Kareena')
insert into memployee values(456,'Rohit')

select * from memployee
select * from mEmpLog

