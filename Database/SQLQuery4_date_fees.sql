create table fees(rno int,sname varchar(20),course varchar(20),amount int,paiddate date)

insert into fees values(1,'Kareena','dotnet',65000,'2023-12-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-11-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-11-4')
insert into fees values(1,'Kareena','dotnet',65000,'2023-11-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-11-2')
insert into fees values(1,'Kareena','dotnet',65000,'2023-11-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-12-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-12-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-12-24')
insert into fees values(1,'Kareena','dotnet',65000,'2023-12-24')

select * from fees
select * from fees where paiddate between '2023-11-1' and '2023-11-30'

select * from fees where rno in (1)

select distinct sname from fees