select * from customer
select * from orders

select customer.cust_id,customer.custname,orders.order_date,orders.product_name,orders.quantity,orders.rate
from customer cross join orders
