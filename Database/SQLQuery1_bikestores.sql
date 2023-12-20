select * from stores

create table staffs(
staff_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone VARCHAR (25),
	active tinyint NOT NULL,
	store_id INT NOT NULL,
	manager_id INT,
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) 
        ON DELETE CASCADE ON UPDATE CASCADE
		)

		insert into staffs values('kareena','likhar','k@gmail.com','123456789',1,1,5)
		insert into staffs values('Rohit','Dhapodkar','r@gmail.com','52642356',1,2,2)
		insert into staffs values('Yashit','Dhapodkar','y@gmail.com','52642356',1,3,2)

		select * from staffs

		select * from categories
		insert into categories values('children bicycles'),('comfort bicycles'),('electric bikes')

		select * from brand
		insert into brand values('Electra'),('Hero'),('Honda')

		select * from products
		insert into products values('Front wheel',1,1,2023,5000)
		insert into products values('Engine Oil',2,3,2023,1000),('Name plate',3,2,2023,1200)

		create table customers(
		customer_id int identity(1,1) primary key,
		first_name varchar(50) not null,
		last_name varchar(50) not null,
		phone varchar(50),
		email varchar(50) not null,
		street varchar(50),
		city varchar(50),
		state varchar(50),
		zip_code varchar(50)
		);

		insert into customers values('Kareena','Likhar','123456789','k@gmail.com','abc','Nagpur','Maharshtra','440017')
		insert into customers values('Yashit','Likhar','123456789','y@gmail.com','abc','Nagpur','Maharshtra','440017')

		create table orders(
		order_id int identity(1,1) primary key,
		customer_id int ,
		order_status tinyint not null,
		--order status 1-pending,2-processing,3-rejected,4-completed
		order_date date not null,
		required_date date not null,
		shipped_date date,
		store_id int not null,
		staff_id int not null,
		foreign key(customer_id) references customers(customer_id) on delete cascade on update cascade,
		foreign key(store_id) references stores(store_id) on delete cascade on update cascade,
		foreign key(staff_id) references staffs(staff_id) on delete no action on update no action,
		);

insert into orders values(1,2,'2023-12-20','2023-12-23','2023-12-23',1,1)
insert into orders values(2,1,'2023-12-20','2023-12-23','2023-12-23',2,3)
insert into orders values(2,4,'2023-12-20','2023-12-23','2023-12-23',3,2)
select * from orders

create table order_items(
order_id int,item_id int,
product_id int not null,
quantity int not null,
list_price dec(10,2) not null,
discount dec(10,2) not null,
primary key(order_id,item_id),
foreign key(order_id) references orders(order_id) on delete cascade on update cascade,
foreign key(product_id) references
products(product_id) on delete cascade on update cascade);

insert into order_items values(1,1,1,50,50000,500)
insert into order_items values(2,2,2,45,60000,600),(4,3,3,60,70000,700)
select * from order_items

create table stocks(
store_id int,product_id int,
quantity int, primary key(store_id,product_id),
foreign key (store_id) references stores(store_id),
foreign key (product_id) references products(product_id)
);
insert into stocks values(1,1,50)
insert into stocks values(2,2,60),(3,3,70)
select * from stocks

select * from stores
select * from staffs
select * from categories
select * from brand
select * from products
select * from customers
select * from orders
select * from order_items
select * from stocks









