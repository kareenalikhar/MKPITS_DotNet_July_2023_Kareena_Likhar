CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName NVARCHAR(50) NOT NULL
);

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'Engineering'),
       (2, 'Marketing'),
       (3, 'Sales');

	   CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(50) NOT NULL,
    DepartmentID INT,
    CONSTRAINT FK_Department_Employee FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID)
VALUES (1, 'John Doe', 1),
       (2, 'Jane Smith', 2),
       (3, 'Bob Johnson', 1),
       (4, 'Alice Brown', 3);

SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID;

INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID)VALUES (5, 'Sam Wilson', 4);

UPDATE Employees
SET DepartmentID = 3
WHERE EmployeeID = 1;

SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID;