select * from emp_info

select sum(salary) as "Total salary" from emp_info;

select sum(salary) as "Total salary" from emp_info where working_hours<8;

  SELECT occupation, SUM(salary) AS "Total Salary"  
    FROM emp_info  
    GROUP BY occupation;  

