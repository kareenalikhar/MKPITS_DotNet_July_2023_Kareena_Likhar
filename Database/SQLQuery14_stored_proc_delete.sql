create proc sp_inprod3(@pid as int,@pn as varchar(20))
as 
begin
delete from products
where product_id=@pid or product_name=@pn
end

exec sp_inprod3 23,'wifi'

select * from products
