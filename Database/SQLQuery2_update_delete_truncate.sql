select * from product

update product set price=10000 where productname='keyboard'

update product set price=20000 where productname='pc' and price=5000

delete from product where productname='pc'

create table sample123(id int identity primary key,name varchar(20))

insert into sample123 values('mouse'),('pendrive'),('cpu'),('keyboard'),('monitor')
select * from sample123
delete from sample123 where name='cpu'

insert into sample123 values('cpu')

truncate table sample123

alter table sample123 add price int
alter table sample123 alter column price dec(10,2)
alter table sample123 drop column price

exec sp_rename 'name','product_name','column'
EXEC sp_rename 'name', 'stuname','COLUMN'