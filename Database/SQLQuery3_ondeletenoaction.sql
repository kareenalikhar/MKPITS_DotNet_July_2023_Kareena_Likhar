create table vendor_group(group_id int identity primary key,group_name varchar(20) not null)

create table vendor(vendor_id int identity primary key,vendor_name varchar(20) not null,group_id int,
constraint fk2 foreign key (group_id)
references vendor_group(group_id) on delete no action)

insert into vendor_group values('HCL'),('Hindustan Liver')
insert into vendor values('Kareena',3),('Rohit',3)
insert into vendor values('Yashika',5),('Ankush',5)

select * from vendor_group
select * from vendor

delete from vendor_group where group_id=3

