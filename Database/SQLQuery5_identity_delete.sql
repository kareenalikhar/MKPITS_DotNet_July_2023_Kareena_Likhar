create database employee

create table employee(empid int primary key identity(1,1),empname varchar(20))

insert into employee values('Kareena')
insert into employee values('Rohit')

select * from employee

insert into employee values('Yashit')

delete from employee where empid=1