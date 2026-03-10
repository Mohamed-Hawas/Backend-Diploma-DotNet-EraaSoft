-- Data Manipulation Questions
-- Select all columns from the "Employees" table.
select *
from dbo.Employee

-- Select only the "Name" and "Salary" columns from the "Employees" table.
select name, salary
from [dbo].[Employee]


-- Select distinct values of the "DeptName" column from the "Employees" table.
select distinct DeptName 
from [dbo].[Employee]

-- Select the top 5 records from the "Employees" table.
select top 5 *
from [dbo].[Employee]

-- Select all records from the "Employees" table, ordered by the "Salary" column in descending order.
select * 
from Employee
order by salary desc

-- Select the first 10 records from the "Employees" table, starting from the third record.
select * 
from Employee
order by id 
OFFSET 2 rows
fetch next 10 rows only

-- Select the average salary from the "Employees" table.
select avg(salary) as avgSalary
from employee

-- Select the maximum and minimum salaries from the "Employees" table.
select max(salary) as maxSalary, min(salary) as minSalary
from employee

-- Select the top 3 highest salaries from the "Employees" table.
select top 3 salary
from employee
order by salary desc

-- Select all records from the "Employees" table, ordered by "Name" in ascending order.
select *
from Employee
order by name asc

-- Select the first 5 records from the "Employees" table, starting from the second record, ordered by "Salary" in descending order.
select *
from Employee
order by salary desc 
offset 1 rows
fetch next 5 rows only

-- Select the sum of all salaries from the "Employees" table.
select sum(salary) as sumOFSalaries
from Employee

-- Select records from the "Employees" table where the "Salary" is between 40000 and 60000, ordered by "Salary" in ascending order.
select *
from Employee
where salary  between '40000' and '60000'
order by salary asc