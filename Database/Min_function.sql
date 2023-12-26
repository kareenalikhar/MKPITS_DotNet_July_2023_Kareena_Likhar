create table ProductQty(
Id int identity primary key,
Region varchar(20) not null,Product varchar(20) not null,
Year int not null,Quantity int not null,
Price int not null);

insert into ProductQty values('East','Computer',2020,130,50000),('South','Computer',2020,450,350000),
('North','Computer',2021,250,400000),('East','Hard Disk',2021,190,5500),
('West','Computer',2021,250,450000),('South','Hard Disk',2021,56,78000),
('East','Pen drive',2022,120,50000),('West','Mouse',2023,550,456000);

select * from ProductQty

select min(Quantity) as "Minimum Quantity" from ProductQty;

select product,quantity,price from ProductQty where quantity=(select min(quantity) as "Minimum Quantity" from ProductQty);

select product, min(quantity) as "Minimum Quantity" from ProductQty group by product;

select product,min(price) as "Minimum quantity" from ProductQty group by product;

select product,min(quantity) as "Minimum quantity" from ProductQty group by product having min(quantity)>100