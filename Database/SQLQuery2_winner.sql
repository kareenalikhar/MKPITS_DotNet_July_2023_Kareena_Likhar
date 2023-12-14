create table winner1(wyear int,sub varchar(20),winname varchar(20),country varchar(20),category varchar(20))

insert into winner1 values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into winner1 values (1970,'Physics','Louis Neel','France','Scientist')
insert into winner1 values(1972, 'Chemistry','Luis Federico Leloir','France','Scientist')
insert into winner1 values(1970,' Physiology ','Ulf von Euler ',' Sweden',' Scientist')
insert into winner1 values(1970 ,'Physiology',' Ulf von Euler','Sweden','Scientist')

select * from winner1

select wyear,sub,winname from winner1 where wyear=1970
select winname from winner1 where wyear=1972 or sub='chemistry'
insert into winner1 values(1970,' Physiology','Bernard Katz','Germany','Scientist')
select wyear,sub from winner1 where winname='Bernard Katz'

select wyear,sub,winname,country from winner1 where wyear between 1965 and 1975 and sub='Chemistry'

