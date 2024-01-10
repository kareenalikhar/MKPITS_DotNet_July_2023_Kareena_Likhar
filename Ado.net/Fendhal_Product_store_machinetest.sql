create table TableProductGSTDetails(Product_GST_ID int primary key,
GST_Detail_Name varchar(500),CGST decimal,SGST decimal,IGST decimal);

create table TableProductCategory(Product_Category_ID int primary key,Product_Type_Name varchar(500),Product_GST_ID int,
foreign key(Product_GST_ID) references TableProductGSTDetails(Product_GST_ID));

create table TableProduct(ProductID int primary key,Product_Name varchar(500),Product_Category_ID int,ProductPrice int
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID));

create table TableInvoiceDetails(Invoice_Detail_ID int,Customer_Name varchar(500),Customer_Contact varchar(15),
Product_Category_ID int,ProductID int,Residential_Type_ID int,Invoice_Date datetime,Quantity decimal,
Price decimal,CGST decimal,SGST decimal,IGST decimal,CGST_Value decimal,SGST_Value decimal,IGST_Value decimal,Total_Amount decimal,
foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
foreign key(ProductID) references TableProduct(ProductID));

insert into TableProductGSTDetails values(601,'Ac and fridge',14,14,14),(602,'Computers',9,9,9),(603,'Printers',9,9,9),(604,'Mobiles',6,6,6);

insert into TableProductCategory values(1001,'Computers',602),(1002,'Mobiles',604),(1003,'Printers',603),(1004,'Ac and fridge',601);

insert into TableProduct values(210,'Apple',1002,40000),(211,'Lenevo',1002,25000),(212,'Samsung',1003,50000),(213,'IFB',1004,20000),(214,'LG',1004,30000),(215,'Sony',1001,60000);

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct

