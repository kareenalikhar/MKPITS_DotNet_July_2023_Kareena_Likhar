create table products(
product_id int identity primary key,
product_name varchar(20) not null,
unit_price dec(10,2)
check(unit_price>0)
);

insert into products values('Keyboard',100)

create table products1(
product_id int identity primary key,
product_name varchar(20) not null,
unit_price dec(10,2),
constraint pp check(unit_price>0)
)

insert into products1 values('Mouse',50)

insert into products values('CPU',null)

select * from products

create table products2(
product_id int identity primary key,
product_name varchar(50) not null,
unit_price dec(10,2) check(unit_price>0),
discount_price dec(10,2) check(discount_price>0),
check(discount_price<unit_price)
);
insert into products2 values('Keyboard',120,20)
insert into products2 values('Mouse',120,40)
select * from products2 

create table products3(
product_id int identity primary key,
product_name varchar(50) not null,
unit_price dec(10,2),discount dec(10,2),
check(unit_price>0),check(discount>0),
check(unit_price>discount)
);

create table product4(
product_id int identity primary key,
product_name varchar(50) not null,
price dec(10,2),discount dec(10,2),
check(price>0),
constraint cpp check(discount>0 and discount<price)
);

