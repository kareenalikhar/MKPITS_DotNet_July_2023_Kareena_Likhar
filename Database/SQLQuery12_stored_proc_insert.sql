create proc sp_inprod1(@pn as varchar(20),@bid as int,@cid as int,@year as varchar(max),@pp as dec)
as begin 
insert into products values(@pn,@bid,@cid,@year,@pp)
end;

select * from products

exec sp_inprod1 'abcd',2,2,'2022',4500

