select * from employee

CREATE FUNCTION f4(@depid int)
RETURNS TABLE
AS
RETURN
(
    SELECT * FROM employee WHERE departmentid = @depid
);

select * from f4(5)