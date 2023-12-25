create proc sp_inprod2(@pid as int,@pn as varchar(20),@pr as decimal,@q as int)
as 
begin
update products set product_name=@pn,list_price=@pr
where product_id=@pid
end

exec sp_inprod2 23,'wifi',400,4
select * from products