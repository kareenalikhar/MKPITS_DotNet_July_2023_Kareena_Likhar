select * from orders
select * from customers

select order_id,order_date,customer_id
from orders
where customer_id in(
select customer_id from customers where city='Nagpur')

insert into customers values('Rohit','Dhapodkar','1235468','r@gmail.com','abc','Bangalore','Mp','562415')

select order_id,customer_id,order_date
from orders where customer_id in
(select customer_id from customers where city='Bangalore')
