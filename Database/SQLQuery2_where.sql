create table student(rno int,first_name varchar(20),last_name varchar(20),city varchar)

insert into student values(1,'Kareena','Likhar','Nagpur')
insert into student values(2,'Rohit','Dhapodkar','Nagpur')
insert into student values(3,'Yashit','Dhapodkar','Nagpur')

select * from student

select * from student where rno=1
select * from student where rno>1
select * from student where rno <>2

select * from student where city ='nagpur'	

select * from student where city ='nagpur' and rno=1
select * from student where first_name ='Rohit' or last_name='Dhapodkar'