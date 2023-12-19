create table person(
person_id int identity primary key,
person_name varchar(20) not null,
person_lastname varchar(20) not null,
email_id varchar(50) unique);

insert into person values('Kareena','Likhar','k@gmail.com'),('Kareena','Likhar','k123@gmail.com');

create table person1(
person_id int identity primary key,
person_name varchar(20) not null,
person_lastname varchar(20) not null,
email_id varchar(50),
unique(email_id));


create table person2(
person_id int identity primary key,
person_name varchar(20) not null,
person_lastname varchar(20) not null,
email_id varchar(50),
constraint email unique(email_id)
);

insert into person2 values('kareena','likhar','k@gmail.com')

create table person_skills(
person_id int,
skills_id int,
update_at datetime,
unique(person_id,skills_id)
);

insert into person_skills values(1,10,'2023-12-12'),(1,1,'2023-12-21')

create table person3(
person_id int identity primary key,
person_name varchar(50) not null,
person_lastname varchar(50) not null,
email varchar(50),phone bigint)

alter table person3 
add constraint ccp unique(email)

insert into person3 values('kareena','likhar','k@gmail.com',1234567890)
insert into person3 values('kareena','likhar','k1@gmail.com',1234567890)

select * from person3

alter table person3
drop constraint ccp 
insert into person3 values('kareena','likhar','k1@gmail.com',1234567890)



