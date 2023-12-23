select * from department
select * from employee

create table locations(LOCATION_ID int,STREET_ADDRESS varchar(50),POSTAL_CODE int,CITY varchar(50),
STATE_PROVINCE varchar(50),COUNTRY_ID int)
insert into locations values(1800,'Via Cola di Rie',5200,'Roma','Texas',123),
(4000,'Jabberwocky Rd',65400,'Southlake','Texas',124),(5600,'Interiors Blvd',85620,'South San Francisco','California',135),
(4650,'Charade Rd',85620,'Seattle','Washington',136),
(3250,'Boxwood St',4560,'Whitehorse','Yukon',146),
(6450,'Spadina Ave',4862,'Toronto','Ontario',782)
select * from locations

SELECT E.first_name,E.last_name, 
   D.department_name, L.city, L.state_province
     FROM employee E 
      inner JOIN department D  
        ON E.department_id = D.department_id  
          inner JOIN locations L
           ON D.location_id = L.location_id;
