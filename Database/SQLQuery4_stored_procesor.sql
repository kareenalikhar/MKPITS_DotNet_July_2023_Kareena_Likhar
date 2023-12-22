select * from products

create procedure prod1
as begin
select * from products
end;

exec prod1 

create proc prod2
as begin
select * from products where model_year='2023'
end
exec prod2