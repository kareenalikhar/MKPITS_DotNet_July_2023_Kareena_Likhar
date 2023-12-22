select * from products

create proc prod8(@minp as dec,@maxp as dec ,@pn as varchar(50))
as begin
select * from products
where list_price>@minp and list_price<@maxp order by product_name
end

exec prod8 1000,5000,'abc'

create proc prod9(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from products
where list_price > @minp and list_price < @maxp
and product_name LIKE '%' + @pn + '%'
order by product_name
end

exec prod9 1000,5000,'abc'