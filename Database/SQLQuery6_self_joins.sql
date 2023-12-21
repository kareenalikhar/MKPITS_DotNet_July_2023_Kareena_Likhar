create table mstudent(
id int identity primary key,
first_name varchar(20) not null,
last_name varchar(20) not null,
city varchar(20) not null)

insert into mstudent values('Kareena','Likhar','Pune'),('Pooja','Tambe','Nagpur'),('Chandu','Ghosh','Pune'),
('Akash','Gautam','Delhi'),('Shiv','Tambe','Nagpur')
select * from mstudent

select s1.first_name,s2.last_name,s2.city
from mstudent s1, mstudent s2
where s1.id<>s2.id and s1.city=s2.city order by s2.city