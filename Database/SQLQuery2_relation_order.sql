create table orders(order_id int identity primary key,order_date date not null,custid int ) 

create table order_details(order_id int,product_name varchar(20),quantity int
constraint fk1 foreign key(order_id)
references orders(order_id))

insert into orders values('2023/12/24',123),('2023/12/24',1234)

insert into order_details values(1,'Rose',3),(1,'Cake',1)
insert into order_details values(2,'Shirt',2),(2,'Watch',1)

select * from orders
select * from order_details