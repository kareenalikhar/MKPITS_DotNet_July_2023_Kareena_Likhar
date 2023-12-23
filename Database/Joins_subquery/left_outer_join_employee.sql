select * from employee
select * from department


SELECT E.first_name, E.last_name, E.department_id, D.department_name 
  FROM employee E 
   LEFT OUTER JOIN department D 
     ON E.department_id = D.department_id;
