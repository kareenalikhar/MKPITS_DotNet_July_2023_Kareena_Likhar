select * from customer
select * from orders

--left outer join

select customer.cust_id,customer.custname,orders.order_date,orders.product_name,orders.quantity,orders.rate
from customer left outer join orders 
on customer.cust_id=orders.custid

--right outer join

select customer.cust_id,customer.custname,orders.order_date,orders.product_name,orders.quantity,orders.rate
from customer right outer join orders 
on customer.cust_id=orders.custid

--full outer join

select customer.cust_id,customer.custname,orders.order_date,orders.product_name,orders.quantity,orders.rate
from customer full outer join orders 
on customer.cust_id=orders.custid