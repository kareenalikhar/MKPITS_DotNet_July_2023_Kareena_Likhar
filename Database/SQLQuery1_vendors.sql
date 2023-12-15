create table vendor_group(group_id int identity primary key,group_name varchar(20) not null) 

create table vendors(vendor_id int identity primary key,vendor_name varchar(20) not null,group_id int not null)

drop table vendors

create table vendors(vendor_id int identity primary key,vendor_name varchar(20) not null,group_id int not null
constraint fk foreign key(group_id)
references vendor_group(group_id))

insert into vendor_group values('HCL'),('Hindustan liver')

insert into vendors values('Kareena',1),('Roh',1)
insert into vendors values('Yashika',2),('Ankush',2)

select * from vendor_group
select * from vendors

