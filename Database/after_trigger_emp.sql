create trigger trigg
on memployee
after update 
as
insert into memplog(empid,operation,updatedate)
select empid,'update',GETDATE()
from memployee

select * from memployee
select * from memplog

update memployee set empname='Ankush' where empid=456
