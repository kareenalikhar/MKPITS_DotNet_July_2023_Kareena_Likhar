select * from employee
create table job_grades(GRADE_LEVEL varchar(20),LOWEST_SAL int,HIGHEST_SAL int)

insert into job_grades values('A',10000,29999),('B',30000,59999),('C',60000,99999),('D',100000,149999),
('E',150000 ,249999),('F',25000,40000)
select * from job_grades

SELECT EMP.FIRST_NAME	, EMP.LAST_NAME, EMP.SALARY, J.GRADE_LEVEL
 FROM employee EMP
   inner JOIN job_grades J
     ON EMP.salary BETWEEN J.lowest_sal AND J.highest_sal;
