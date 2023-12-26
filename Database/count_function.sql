select * from product

select count(price) as "Total count" from product;

select count(price) as "total" from product where productname='mouse';

select productname,count(price) as "total" from product group by productname