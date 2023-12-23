create table department(
department_id int primary key,department_name varchar(50),manager_id int,location_id int)

insert into department values(1,'Administration',200,1700),(2,'Marketing',201,1800),
(3,'Purchasing',211,1600),(4,'Human Resources',405,4000),(5,'Shipping',460,8050),
(6,'IT',640,5600),(7,'Finance',820,4560),(8,'Executive',120,4650),(9,'Accounting',750,6450),
(10,'Operations',468,3250)
select * from department

create table employee(EMPLOYEE_ID int,FIRST_NAME varchar(50), LAST_NAME varchar(50),EMAIL varchar(50),
PHONE_NUMBER bigint,HIRE_DATE date,
JOB_ID int,SALARY int,COMMISSION_PCT int,MANAGER_ID int, DEPARTMENT_ID int)

insert into employee values(100,'Steven','King','SKING',123456789,'2023-12-20',12,240000,0,200,1),
(200,'Neena','Kochhar','NKOCHHAR',4560478522,'2023-5-6',45,620000,1,405,4),
(300,'Alexander','Hunold','AHUNOLD',885562162,'2023-6-8',65,4522002,0,640,6),
(400,'David','Austin','DAUSTIN',56624533,'2023-8-5',46,850000,1,468,10),
(500,'Nancy','Greenberg','NGREENBE',45023689,'2023-7-9',56,45600,2,120,8),
(600,'John','Chen','JCHEN',52625633,'2023-8-6',45,365000,1,820,7)    
select * from employee

SELECT E.first_name , E.last_name , 
       E.department_id , D.department_name 
        FROM employee E 
         inner JOIN department D 
          ON E.department_id = D.department_id;


