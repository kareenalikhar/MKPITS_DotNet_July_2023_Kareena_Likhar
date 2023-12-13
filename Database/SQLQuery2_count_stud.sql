create table student(studid int,studname varchar(20),state varchar(20),city varchar(20))

insert into student values(1,'Kareena','Maharshtra','nagpur')
insert into student values(2,'Rohit','Maharshtra','nagpur')
insert into student values(3,'Ruchika','MP','Bhopal')
insert into student values(4,'bharti','MP','Bhopal')
insert into student values(5,'Kareena','Mp','Indore')
insert into student values(6,'Kareena','Mp','Indore')

select state,COUNT(*) from student where city='nagpur' group by state

select state,COUNT(*) from student
  where city <> 'nagpur'
  group by state order by state
