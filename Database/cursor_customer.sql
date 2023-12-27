select * from customer

declare @custname varchar(max),
@custaddress varchar;

declare cursorc cursor 
for select custname,custaddress from customer where custid>3 and custaddress='nagpur';

open cursorc;

fetch next from cursorc into
@custname,@custaddress;

while @@FETCH_STATUS=0
begin
print @custname + cast(@custaddress as varchar);

fetch next from cursorc into
@custname,@custaddress
end;

close cursorc;
deallocate cursorc;