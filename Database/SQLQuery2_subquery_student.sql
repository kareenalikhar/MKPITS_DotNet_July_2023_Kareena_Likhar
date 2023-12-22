create table student(
rno int,sname varchar(20),email varchar(20),city varchar(50),courseid int)

insert into student values(1,'Kareena','k@gmail.com','Noida',123),
(2,'Chandrima','c@gmail.com','Pune',234),(3,'Pooja','p@gmail.com','Nagpur',345),
(4,'Akash','a@gmail.com','Pune',456),(5,'Ayushree','a@gmail.com','Nagpur',567),
(6,'Sarang','s@gmail.com','Mumbai',678),(7,'Lucky','l@gmail.com','Mumbai',789),
(8,'David','d@gmail.com','Nagpur',890),(9,'Yashit','y@gmail.com','Bangalore',987),
(10,'Rohit','r@gmail.com','Bangalore',876);
select * from student

create table fees(
feesid int,rno int,feesdate date,amount int,courseid int )

insert into fees values(1,1,'2023-12-23',50000,123),(2,4,'2023-12-22',62000,456),
(3,9,'2023-12-24',80000,987),(4,6,'2023-12-5',45000,678),(5,10,'2023-12-24',90000,876)
select * from fees

select feesid,rno,amount from fees where rno in
(select rno from student where city='Mumbai')

select feesid,rno,amount from fees where rno in
(select rno from student where city='Pune')