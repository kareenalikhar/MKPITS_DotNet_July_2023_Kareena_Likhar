create table student( 
id int identity primary key,
addmission_no varchar(50) not null,
first_name varchar(50) not null,
last_name varchar(50) not null,
age int,city varchar(50) not null)

create table fees(
addmission_no varchar(50) not null,
course varchar(50),amount_paid int)

insert into student values('123','Kareena','Likhar',21,'Nagpur'),('234','Pooja','Tambe',31,'Nagpur'),
('345','Chandrima','Ghosh',21,'Nagpur'),('456','Akash','Gautam',21,'Nagpur'),('567','Ayushree','Shende',21,'Nagpur')
insert into student values('678','Sarang','Prajapati',22,'Nagpur'),('789','Lucky','Tambe',25,'Nagpur'),
('890','David','Kothe',22,'Nagpur')
select * from student

insert into fees values(123,'Java', 20000),       
    (345, 'Android', 22000),       
    (567, 'Python', 18000),    
    (978,'SQL', 15000),       
    (890, 'Machine Learning', 30000);  
select * from fees

select student.addmission_no,student.first_name,student.last_name,fees.course,fees.amount_paid
from student inner join fees 
on student.addmission_no=fees.addmission_no
