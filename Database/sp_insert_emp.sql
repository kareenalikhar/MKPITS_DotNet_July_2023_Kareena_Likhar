select * from employee

create procedure InsertEmployee(@name as varchar(20),@depid as int,@sal as int)
as begin
insert into employee values(@name,@depid,@sal)
end;

exec InsertEmployee 'Yashit',8,60000

