CREATE TABLE Product (  
     Product_id INT PRIMARY KEY,   
     Product_name VARCHAR(40),   
     Price INT,  
     Quantity INT  
    )  

	INSERT INTO Product VALUES(111, 'Mobile', 10000, 10),  
    (112, 'Laptop', 20000, 15),  
    (113, 'Mouse', 300, 20),  
    (114, 'Hard Disk', 4000, 25),  
    (115, 'Speaker', 3000, 20);  

	    -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
     INSERT INTO Product VALUES(116, 'Headphone', 2000, 30)  
     UPDATE Product SET Price = 450 WHERE Product_id = 113  
     -- Commit changes   
    COMMIT TRANSACTION  

	select * from product

	-- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE Product_id = 114  
    DELETE FROM Product WHERE Product_id = 116  

	    -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE Product_id = 114  
    DELETE FROM Product WHERE Product_id = 116  
    --Undo Changes  
    ROLLBACK TRANSACTION  


