select * from employee

create procedure GetHighSalaryEmployees(@salary as decimal)
as begin
select * from employee
where salary> @salary
end;

exec GetHighSalaryEmployees 500000
