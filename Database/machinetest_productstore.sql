create database Product_Store

create table TableProductGSTDetails(Product_GST_ID int primary key,
GST_Detail_Name varchar(500),CGST decimal,SGST decimal,IGST decimal);

insert into TableProductGSTDetails values(12,'Commercial',10.2,10.3,10.4),(13,'Domestic',10.2,10.3,10.4),
(14,'Household',10.2,10.3,10.4),(15,'Commercial',10.2,10.3,10.4),(16,'Household',10.2,10.3,10.4);

create table TableProductCategory(Product_Category_ID int primary key,Product_Type_Name varchar(500),Product_GST_ID int,
foreign key(Product_GST_ID) references TableProductGSTDetails(Product_GST_ID));

insert into TableProductCategory values(11,'Household',12),(22,'Sports',13),(33,'Study Material',14),(44,'Electronics',15),(55,'Beauty Products',16);

create table TableProduct(ProductID int primary key,ProductTypeID int,Product_Name varchar(500));

insert into TableProduct values(111,10,'Utensils'),(222,20,'Badbinton'),(333,30,'Pen'),(444,40,'Laptop'),(555,50,'Compact');

create table TableInvoiceDetails(Invoice_Detail_ID int,Customer_Name varchar(500),Customer_Contact varchar(15),
Product_Category_ID int,ProductID int,Residential_Type_ID int,Invoice_Date datetime,Quantity decimal,
Price decimal,CGST decimal,SGST decimal,IGST decimal,CGST_Value decimal,SGST_Value decimal,IGST_Value decimal,Total_Amount decimal,
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
foreign key(ProductID) references TableProduct(ProductID));

insert into TableInvoiceDetails values(1,'Kareena','1234567890',11,111,01,'2023/12/12',10,50000,50,50.20,50.40,500,550,575,10000),
(2,'Pooja','1234567890',22,222,02,'2023/12/12',10,50000,50,50.20,50.40,500,550,575,10000),
(3,'Chandrima','1234567890',33,333,03,'2023/12/12',10,50000,50,50.20,50.40,500,550,575,10000),
(4,'Akash','1234567890',44,444,04,'2023/12/12',10,50000,50,50.20,50.40,500,550,575,10000),
(5,'Sarang','1234567890',55,555,05,'2023/12/12',10,50000,50,50.20,50.40,500,550,575,10000);

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails