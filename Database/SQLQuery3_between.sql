create table order1(productid int,custname varchar(20),productname varchar(20),quantity int,paiddate date)

insert into order1 values(1,'Kareena','mouse',5,'2023-2-1')
insert into order1 values(2,'Ruchika','keyboard',6,'2023-3-4')
insert into order1 values(3,'Rohit','Pc',8,'2023-4-6')
insert into order1 values(4,'yashit','cpu',2,'2023-5-8')

select * from order1

select * from order1 where paiddate between '2023-2-1' and '2023-4-8'