create table customer(
cust_id int not null,custname varchar(20) not null,
telno varchar(20))

insert into customer values(123,'Kareena','123456789'),(234,'Pooja','2345652352'),(345,'Chandrima','465622556'),
(456,'Akash','12356489'),(567,'Sarang','253641525')
select * from customer

create table orders(
orderid int,order_date date,custid int,product_name varchar(20),quantity int,rate bigint)
insert into orders values(1,'2023-12-12',234,'Mint',2,100),(2,'2023-12-20',567,'Strawberry',1,50),
(3,'2023-12-14',345,'Chocolate',5,500)

select customer.cust_id,customer.custname,orders.order_date,orders.product_name,orders.quantity,orders.rate
from customer inner join orders 
on customer.cust_id=orders.custid