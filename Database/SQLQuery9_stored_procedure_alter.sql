select * from products

alter procedure prod2(@lp as dec)
as begin
select * from products where list_price>=@lp order by list_price
end;
exec prod2 3000