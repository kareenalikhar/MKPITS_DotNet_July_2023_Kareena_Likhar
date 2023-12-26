select * from ProductQty

select max(price) as "Maximum Quantity" from ProductQty;

select product,quantity,price from productqty where quantity=(select max(quantity) as "Maximum Quantity" from productqty);

select product,max(quantity) as "Maximum Quantity" from ProductQty group by product order by product;

