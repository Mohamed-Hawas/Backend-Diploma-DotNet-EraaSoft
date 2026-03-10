-- Data Definition Questions: (using SQL NOT GUI)
-- Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).
create TABLE Employee (
	id int,
	name varchar,
	salary decimal(10, 2)
)

alter table Employee
alter column name varchar(50)

-- Add a new column named "Department" to the "Employees" table with data type varchar(50).
alter table dbo.employee 
add department varchar(50)

-- Remove the "Salary" column from the "Employees" table.
alter table dbo.employee 
drop column salary

-- Rename the "Department" column in the "Employees" table to "DeptName".
execute sp_rename 'dbo.employee.department' ,'DeptName' , 'column'

-- Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
create table projects (
	projectID int,
	projectName varchar(50)
)
alter table [dbo].[projects]
alter column projectId int not null

alter table [dbo].[projects]
ADD CONSTRAINT PK_Projects
primary key (projectID)
-- Add a primary key constraint to the "Employees" table for the "ID" column.
alter table dbo.employee
alter column id int not null

alter table dbo.employee
ADD CONSTRAINT PK_Employees
primary key (id)

-- Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").
alter table dbo.employee
add projectId int 

alter table dbo.employee
add CONSTRAINT FK_Emloyee
foreign key (projectId) references projects(projectId) 

-- Remove the foreign key relationship between "Employees" and "Projects."
alter table dbo.employee
drop constraint FK_Emloyee

-- Add a unique constraint to the "Name" column in the "Employees" table.
alter table dbo.employee
add unique(name)

-- Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
create table customers (
	customerId int,
	firstName varchar(20),
	lastName varchar(20),
	email varchar(50),
	status varchar(20)
)

-- Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
alter table dbo.customers
add unique(firstName, lastName)

-- Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted.
alter table [dbo].[customers]
add default 'active' for status

-- Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
-- Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
create table orders(
	orderId int,
	customerId int,
	orderDate date,
	totalAmount decimal(10,2) ,
	check (totalAmount > 0) 
)
-- Create a schema named "Sales" and move the "Orders" table into this schema.
go
create schema sales 

alter schema sales 
transfer dbo.orders

-- Rename the "Orders" table to "SalesOrders."
exec sp_rename 'sales.orders',  'SalesOrders' 