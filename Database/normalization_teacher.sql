create table teacher(teacher_id int, subject varchar(20),teacher_age int);
insert into teacher values(25,'chemistry',30),(25,'Biology',30),(47,'English',35),(83,'Maths',38),(83,'Computer',38)

select * from teacher

create table teacher_details(teacher_id int primary key,teacher_age int)
create table teacher_subject(teacher_id int,subject varchar(20),
constraint t1 foreign key (teacher_id)
references teacher_details(teacher_id));

insert into teacher_details values(25,30),(47,35),(83,38)
insert into teacher_subject values(25,'chemistry'),(25,'Biology'),(47,'English'),(83,'Maths'),(83,'Computer')

select * from teacher_details
select * from teacher_subject