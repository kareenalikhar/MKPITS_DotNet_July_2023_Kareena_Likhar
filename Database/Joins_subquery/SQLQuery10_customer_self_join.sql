create table customers(
cust_id int,cust_name varchar(20),city varchar(20))

insert into customers values(1,'Kareena','Nagpur'),(2,'pooja','Nagpur'),(3,'Chandu','pune'),(4,'yash','pune'),
(3,'Akash','Delhi')

SELECT S1.cust_id, S2.cust_name, S2.city  
    FROM customers S1, customers S2  
    WHERE S1.cust_id <> S2.cust_id AND S1.city = S2.city  
    ORDER BY S2.city;  
