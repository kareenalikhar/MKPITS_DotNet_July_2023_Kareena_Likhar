create table emp_info(
Name varchar(20),Occupation varchar(20),working_date date,working_hours int,salary int);

insert into emp_info values('Kareena','Software Devloper','2024-2-1',8,500000),
('Rohit','Drone piolet','2024-2-1',6,600000),('Yashit','Manager','2027-8-6',5,800000);

select * from emp_info

select avg(working_hours) as "Average working hours" from emp_info;

select avg(working_hours) as "Average working hours" from emp_info where Occupation='Software Devloper';

select occupation,avg(working_hours) as "Average working hours" from emp_info group by Occupation;