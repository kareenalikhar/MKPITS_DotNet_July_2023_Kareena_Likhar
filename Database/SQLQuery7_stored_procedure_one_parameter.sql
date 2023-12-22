select * from products

create procedure prod2(@pid as int)
as begin 
select * from products where product_id>@pid
end

exec prod2 2

create proc prod5(@pname as varchar(20))
as
begin
select * from products
where product_name = @pname
order by product_name
end;

exec prod5 'name plate'
