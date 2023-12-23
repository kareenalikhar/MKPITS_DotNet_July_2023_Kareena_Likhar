select * from student

create table course(
courseid int,course_name varchar(50),fees int,duration int)

insert into course values(234,'Java',80000,5),(456,'Java',80000,7),(678,'Java',80000,8),(890,'Java',80000,5),
(876,'Dotnet',70000,8),(567,'dotnet',80000,5)

select * from course

select rno,sname,city,courseid from student
where courseid in (select courseid from course where course_name='Java')