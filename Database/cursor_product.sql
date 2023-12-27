select * from product

declare @product_name varchar(50),@list_price decimal;

declare cursorprod cursor
for select 
productname,price from product;

open cursorprod;

fetch next from cursorprod into @product_name ,@list_price;

while @@FETCH_STATUS=0
begin
print @product_name+cast(@list_price as varchar);
fetch next from cursorprod into 
@product_name,@list_price
end;

close cursorprod;
deallocate cursorprod;