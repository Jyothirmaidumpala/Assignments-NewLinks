/*create a database*/
create database JyothiDb
/*using database*/
use JyothiDb
/*To create Table*/
create table Department
(Deptno int primary key,
Dname varchar(20) not null,
Loc varchar(20) not null)
/*To insert data into the Department Table*/
insert into Department
values(10,'Accounting','Newyork'),
(20,'Research','Dallas'),
(30,'Sales','chicago'),
(40,'Operations','boston')
/* To query Table*/
select* from Department
/*To create Employee Table*/
create table Employeeis
(Empno int primary key,
ename varchar(20) not null,
job varchar(20),
mgr int ,
hiredate  DATE,
sal int,
comm int   null,
Deptno int foreign key references Department(Deptno))
/*To query Table*/

select* from Employeeis
/* inserting values into Employee Table*/
insert into Employeeis
values(7369,'Smith','Clerk',7902,('17-Dec-80'),800,null,20);
select*from Employeeis
insert into Employeeis
values(7499,'Allen','Salesman',7698,('20-Feb-81'),1600,300,30),
(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250,500, 30),
(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975,null, 20),
(7654, 'MARTIN', 'SALESMAN',7698, '28-SEP-81', 1250,1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850,null, 30),
(7782, 'CLARK', 'MANAGER', 7839, '09-JUN-81', 2450,null, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000,null, 20),
(7839, 'KING', 'PRESIDENT', null, '17-NOV-81', 5000,null, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500,0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87',1100,null, 20),
(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950,null, 30),
(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000,null, 20),
(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300,null, 10)

/*--Assignment1 sql queries---*/
--1. List of all employees whose name start with 'A'
select *from Employeeis where ename like 'A%'
--2.Select all those employees who don't have manager
select*from Employeeis where mgr is null
--3.List employee name,number and salary for those employes who earn in the range 1200 to 1400
select ename,Empno,sal from Employeeis where sal between 1200 and 1400
--4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
select*from Department
select Deptno,ename,sal,(sal+(sal*10/100)) 'New Salary' from Employeeis where Deptno=20
--5.Find the number of CLERKS employed. Give it a descriptive heading
select count(job) 'No.of clercks employed' from Employeeis where job='clerk'
--6.Find the average salary for each job type and the number of people employed in each job
select job,avg(sal),count(*) 'No of people employed' from Employeeis
group by job
--7.List the employees with the lowest and highest salary
--for Highest salary
select ename,sal from Employeeis 
where sal =(select max(sal) from Employeeis) 
---for Lowest salary
select ename,sal from Employeeis
 where sal=(select min(sal) from Employeeis)
 --8.List full details of departments that dont have any employees
 select *from Department where Deptno not in(select deptno from Employeeis)
 --9.Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name
 select ename,sal from Employeeis where job='Analyst' and sal>1200 and Deptno=20
 --10.For each department, list its name and number together with the total salary paid to employees in that department
 select Dname,count(*) Deptno,sum(sal) 'Total salary Paid' from Department,Employeeis where Employeeis.Deptno=Department.Deptno
 group by Dname
 --11.Find out salary of both MILLER and SMITH
 select sal from Employeeis where ename='Miller' 
 select sal from Employeeis where ename='Smith'
 --12.Find out the names of the employees whose name begin with ‘A’ or ‘M’
 select* from Employeeis where ename like 'A%' or ename like 'M%'
 --13.Compute yearly salary of SMITH.
 select sal,sal*12 'Annual salary' from Employeeis where ename='Smith'
 --14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850
 select ename,sal from Employeeis where sal  not between 1500 and 2850

 --------------------------------------------------------------------------------------
 /*Assignment2*/

--1.Retrieve a list of MANAGERS
select *from Employeeis where job='mgr'
--2.Find out salary of both MILLER and SMITH
select sal from Employeeis where ename='Miller'
select sal from Employeeis where ename='Smith'
--3.Find out the names and salaries of all employees earning more than 1000 per month
select ename,sal from Employeeis where sal>1000
--4.Display the names and salaries of all employees except JAMES
select ename from Employeeis where ename !='James'
--5.Find out the details of employees whose names begin with ‘S’
select ename from Employeeis where ename like 's%'
--6.Find out the names of all employees that have ‘A’ anywhere in their name
select ename from Employeeis where ename like'%a%'
--7.Find out the names of all employees that have ‘L’ as their third character in their name
select ename from Employeeis where ename like '_l%'
--8.Find out the names of the employees whose name begin with ‘A’ or ‘M’
select ename from Employeeis where ename like '[am]%'
--9.Compute yearly salary of SMITH
select sal, sal*12 from Employeeis where ename='smith'
--10.Compute daily salary of JONES
select sal,sal/30 from Employeeis where ename='Jones'
--11.Calculate the total monthly salary of all employees
select sum(sal)'total_Monthly_Salaries' from Employeeis
--12.Print the average annual salary
select avg(sal*12) 'Average Annual salary' from Employeeis
--13.Select the name, job, salary, department number of all employees except SALESMAN from department number 30
select ename,job,sal,deptno from Employeeis where job!='Salesman' and deptno=30
--14.List unique departments of the EMP table
select distinct(deptno) from Employeeis
--15.List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively
select ename  Employee,sal 'Monthly Salary' from Employeeis where sal>1500 and Deptno=10 or  Deptno=30

----------------------------------------------------------------------------------







