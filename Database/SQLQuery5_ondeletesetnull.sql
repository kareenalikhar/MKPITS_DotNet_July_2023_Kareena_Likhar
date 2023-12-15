drop table vendor

create table vendor(vendor_id int identity primary key,vendor_name varchar(20),group_id int
constraint fk4 foreign key(group_id)
references vendor_group(group_id) on delete set null)

insert into vendor values('Kareena',1)

select * from vendor_group
select * from vendor

delete from vendor_group where group_id=1
