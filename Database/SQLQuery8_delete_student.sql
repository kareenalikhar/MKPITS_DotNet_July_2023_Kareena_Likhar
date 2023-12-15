create table student(rno int primary key,stud_name varchar(20),stud_address varchar(20))
create table fees(fees_id int primary key,rno int 
constraint fk foreign key(rno)
references student(rno) on delete no action)

insert into student values(1,'kareena','nagpur'),(2,'Rohit','nagpur')
drop table fees

create table fees(fees_id int primary key,rno int 
constraint fk foreign key(rno)
references student(rno) on delete no action ,amount int,paiddate date)

insert into fees values(123,1,50000,'2023-2-5'),(1234,1,40000,'2023-4-6')
insert into fees values(12,2,50000,'2023-2-5'),(127,2,40000,'2023-4-6')

select * from student
select * from fees

delete from student where  rno=1

drop table fees

create table fees(fees_id int primary key,rno int 
constraint fk foreign key(rno)
references student(rno) on delete cascade ,amount int,paiddate date)

insert into fees values(123,1,50000,'2023-2-5'),(1234,1,40000,'2023-4-6')
insert into fees values(12,2,50000,'2023-2-5'),(127,2,40000,'2023-4-6')

delete from student where rno=1

drop table fees

create table fees(fees_id int primary key,rno int 
constraint fk foreign key(rno)
references student(rno) on delete set null ,amount int,paiddate date)

insert into fees values(123,1,50000,'2023-2-5'),(1234,1,40000,'2023-4-6')
insert into fees values(12,2,50000,'2023-2-5'),(127,2,40000,'2023-4-6')
delete from student where rno=2

select * from student
select * from fees

drop table fees

create table fees(fees_id int primary key,rno int 
constraint fk foreign key(rno)
references student(rno) on delete set null ,amount int,paiddate date)

insert into fees values(123,1,50000,'2023-2-5'),(1234,1,40000,'2023-4-6')
insert into fees values(12,2,50000,'2023-2-5'),(127,2,40000,'2023-4-6')

insert into student values(1,'kareena','nagpur'),(2,'Rohit','nagpur')

delete from student where rno=2

