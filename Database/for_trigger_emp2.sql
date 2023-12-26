create table employee123(
empid int not null,first_name varchar(20) not null,
last_name varchar (20) not null,email varchar(20) not null,
phone bigint not null,hire_date date not null,managerId int not null,
salary int,department_id int);

create trigger trig1
on employee123
for insert 
as
insert into memplog(empid,operation,updatedate)
select empid,'insert',GETDATE()
from inserted;

insert into employee123 values(1,'Kareena','Likhar','k@gmail.com',1234567890,'2023-12-5',123,800000,234)

select * from employee123
select * from memplog

select * from dbo.memplog