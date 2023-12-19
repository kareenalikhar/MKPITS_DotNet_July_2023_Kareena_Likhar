create table products4(
product_id int identity primary key,
product_name varchar(50) not null,
unit_price dec(10,2)
);

alter table products4
add constraint pprice check(unit_price>0);

alter table products4
add discount dec(10,2)
check(discount>0);

insert into products4 values('cpu',2000,200);

sp_help products4

alter table products4
add constraint price check(discount<unit_price)

alter table products4
drop constraint pprice