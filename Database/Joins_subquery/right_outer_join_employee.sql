select * from department
select * from employee

SELECT E.first_name, E.last_name, D.department_id, D.department_name 
 FROM employee E 
   RIGHT OUTER JOIN department D
     ON E.department_id = D.department_id;
