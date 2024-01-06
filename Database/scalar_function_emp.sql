select * from employee

CREATE FUNCTION f2(@sal DECIMAL)
RETURNS DECIMAL
AS 
BEGIN
    DECLARE @result DECIMAL;
    SET @result = @sal / 7.5;
    RETURN @result;
END;

select dbo.f2(salary) as 'Tax' from employee