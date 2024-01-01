select * from employee

begin transaction
insert into employee values('Roh',9,7000000)
update employee set departmentid=10 where empid=6
commit transaction