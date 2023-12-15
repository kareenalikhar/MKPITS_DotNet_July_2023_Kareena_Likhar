insert into vendor_group values('HCL'),('HL')

insert into vendor values('Kareena',3)
insert into vendor values('Roh', 4)

select * from vendor_group
select * from vendor

update vendor_group set group_name='mkpit' where group_id=3

drop table vendor 

create table vendor(vendor_id int identity primary key,vendor_name varchar(20),group_id int
constraint fk5 foreign key(group_id)
references vendor_group(group_id) on update no action)

update vendor_group set group_name='tcs' where group_id=4