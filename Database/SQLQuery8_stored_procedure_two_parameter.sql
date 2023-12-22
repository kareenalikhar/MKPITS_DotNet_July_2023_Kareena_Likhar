select * from products

create procedure prod6(@pname as varchar(20),@p as dec(10,2))
as begin
select * from products 
where product_name =@pname and list_price=@p
end;

exec prod6 'name plate',1200