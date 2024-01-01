create table employee(Empid int identity primary key,Name varchar(50),
departmentid int, salary int not null);
              
insert into employee values('Kareena',1,500000),('Rohit',2,8000000),('Pooja',3,400000),('Chandrima',4,300000),('Akash',5,450000);
select * from employee

select count(empid) as 'Total' from employee






