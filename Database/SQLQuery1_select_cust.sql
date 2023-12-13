create table customer2(custid int,custname varchar(20),custstate varchar(20))

insert into customer2 values(1,'amit','Maharashtra')
insert into customer2 values(2,'Raj','Maharashtra')
insert into customer2 values(3,'Bharti','MP')
insert into customer2 values(4,'deeptii','MP')

select * from customer2

select * from customer2 order by custname desc
select * from customer2 where custname='amit'

select * from customer2 where custid>1

select * from customer2 where custstate='MP' order by custname
