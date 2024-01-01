create procedure GetEmployeeByDepartment1(@depid as int)
as begin
select * from employee
where departmentid= @depid
order by departmentid
end;
exec GetEmployeeByDepartment1 5