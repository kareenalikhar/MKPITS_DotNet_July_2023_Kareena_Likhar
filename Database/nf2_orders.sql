create table orders(order_id int,order_date varchar(20),product_name varchar(20),customer_name varchar(20),quantity int);

insert into orders values(1,'1/1/2024','Samosa','Amit',2),(1,'1/1/2024','Pakoda','Amit',2),(1,'1/1/2024','Kachori','Amit',3),
(2,'2/2/2024','Samosa','Ravi',2),(2,'2/2/2024','Kachori','Ravi',3);

create table orders_table(order_id int primary key,order_date varchar(20),customer_name varchar(20));

create table order_details(order_id int,product_name varchar(20),quantity int,
foreign key (order_id) references orders_table(order_id));

insert into orders_table values(1,'1/1/2024','amit'),(2,'2/2/2024','Ravi')
insert into order_details values(1,'Samosa',2),(1,'Pakoda',2),(1,'Kachori',3),(2,'Samosa',2),(2,'Kachori',3)

select * from order_details
select * from orders_table

