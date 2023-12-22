--modifying stored procedure

select * from products

alter procedure prod2
as begin
select product_name,list_price from products
order by list_price
end
exec prod2

alter procedure prod2
as begin
insert into products values('abc',1,1,'2022',3000)
select * from products
end;

exec prod2
