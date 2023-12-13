create table mkp(id int primary key,sname varchar(20),coursename varchar(20),city varchar(20))

insert into mkp values(1,'Kareena','dotnet','nagpur')
insert into mkp values(2,'Rohit','dotnet','nagpur')
insert into mkp values(3,'Yashit','Java','nagpur')
insert into mkp values(4,'Pooja','dotnet','nagpur')
insert into mkp values(5,'Diksha','Java','nagpur')
insert into mkp values(6,'Kareena','Java','nagpur')

select * from mkp

select coursename,count(*) from mkp
where city='nagpur'
group by coursename
