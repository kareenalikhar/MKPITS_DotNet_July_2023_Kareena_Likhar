select * from orders
select * from order_details

drop table order_details

create table order_details(order_id int,product_name varchar(20),quantity int
constraint fk1 foreign key(order_id)
references orders(order_id) on delete no action)

delete from orders where order_id=1

insert into order_details values(2,'shoe',3)

delete from orders where order_id=2

drop table order_details
create table order_details(order_id int,product_name varchar(20),quantity int
constraint fk1 foreign key(order_id)
references orders(order_id) on delete cascade)

insert into order_details values(2,'shoe',3)

delete from orders where order_id=2

drop table order_details

create table order_details(order_id int,product_name varchar(20),quantity int
constraint fk1 foreign key(order_id)
references orders(order_id) on delete set null)
insert into orders values('2023-5-4',102)
insert into order_details values(4,'shoe',3)

delete from orders where order_id=4

drop  table order_details

create table order_details(order_id int,product_name varchar(20),quantity int
constraint fk1 foreign key(order_id)
references orders(order_id) on update no action)

insert into orders values('2023-5-4',102)
insert into order_details values(5,'bag',5)

update orders set custid=405 where order_id=5
update order_details set product_name='glass' where order_id=5
