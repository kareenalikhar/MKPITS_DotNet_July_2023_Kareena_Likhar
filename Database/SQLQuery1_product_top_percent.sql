create table product(productid int, productname varchar(20),price int,quantity int)

insert into product values(1,'Mouse',1000,5)
insert into product values(2,'pc',5000,2)
insert into product values(3,'keyboard',1200,6)
insert into product values(4,'cpu',10000,3)

select * from product

select top 2 productname from product
select top 2 * from product

select top 2 productname, price from product order by quantity desc

select top 70 percent * from product
select top 70 percent productname,price from product order by quantity desc