create function f1()
returns table
as 
return (select * from product)

select * from f1()
