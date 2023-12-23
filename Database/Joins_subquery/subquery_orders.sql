select * from salesman
select * from orders

select * from orders where purch_amt>(select avg(purch_amt) from orders
where ord_date='2012-08-17')