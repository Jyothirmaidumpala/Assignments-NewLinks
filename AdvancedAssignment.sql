/*Sql Assignment on Advanced Topics*/ 


/*1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction */

begin
declare @salary float=30000
declare @SAL float
declare @HRA float,@DA float,@PF float,@IT float
declare @deductions float,@GrossSal float,@NetSal float
set @HRA=@salary*0.1
print 'HRA is:'
print @HRA
set @DA=@salary*0.2
print 'DA is:'
print @DA
set @PF=@salary*0.08
print 'PF is:'
print @PF
set @IT=@salary*0.05
print 'IT is:'
print @IT
set @deductions=@PF+@IT
print 'Deductions is:'
print @deductions
set @SAL=@salary-(@HRA+@DA+@deductions)
set @GrossSal=@SAL+(@HRA+@DA+@deductions)
print 'Gross salary is'
print @GrossSal
set @NetSal=@GrossSal-@deductions
print 'Net Salary is'
print @NetSal
end

/*2.	Write a T-SQL Program to Display complete result of a given student. (Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths
,phy,comp)*/

begin
declare @Sno int,@Sname varchar(20),@Mat int,@Phy int,@Comp int,@Total int,@Percentage int
declare @Result varchar(20)
set @Sno=1
set @Sname='Jyothi'
set @Mat=95
set @Phy=86
set @Comp=95
set @Total=(@Mat+@Phy+@Comp)
set @Percentage=(@Total*100)/300
print @Percentage
 create table Result(
Sno int,Sname varchar(20),Maths int,Physics int,Computer int,Total int,Percentage int)
insert into Result
values(@SNo,@SName,@Mat,@Phy,@Comp,@Total,@Percentage)
select *from Result
end

/*3.Write a T-SQL Program to find the factorial of a given number.*/
begin
	declare @num int
	declare @factorial int
	set @num=5
	set @factorial=1
while @num>0
	begin                                                       
		set @factorial=@factorial*@num
		set @num=@num-1
	end
	print 'Factorial of a number is'
	print @factorial
end
/*4.Create a stored procedure to generate multiplication tables up to a given number.*/

create or alter procedure pro_multiplication
as
begin
	declare @num1 int=1,@num2 int=6,@res int
while @num1<=10
	begin
		set @res=@num2*@num1
		print @res
	set @num1=@num1+1
	end
end
exec pro_multiplication

/*5.Create a user defined function calculate Bonus for all employees of a  given job using following conditions
a.	       For Deptno10 employees 15% of sal as bonus.
b.	       For Deptno20 employees  20% of sal as bonus
c.	      For Others employees 5%of sal as bonus
*/

use JyothiDb

select * from EMP
--function Creation--
create or alter function Calculate_Bonus(@ejob varchar(15))
returns table
as
return (select Ename,Job,Sal,Deptno from EMP Where job=@ejob)
go
update EMP set Sal=Sal+(Sal*0.15) where Deptno=10
update EMP set Sal=Sal+(Sal*0.2) where Deptno=20
update EMP set Sal=Sal+(Sal*.05) where Deptno<>10 and Deptno<>20 
select * from Calculate_Bonus('Clerk')

/*6.Create a trigger to restrict data manipulation on EMP table during General holidays. 
Display the error message like “Due to Independence day you cannot manipulate data”
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details*/

---create holiday table----
create table Holiday
(holiday_date varchar(20),
Holiday_name varchar(20))

--inserting values into Holiday table---
insert into Holiday values('14-JAN','Sankranthi'),
('01-Mar','Ugadhi'),
('15-AUG','Independence Day'),
('2-OCT','Gandhi Jayanthi')

select * from Holiday

----trigger creation----
create or alter trigger RestrictDataManipulation
on Holiday
instead of update
as
   Raiserror('Due to Independace Day You Cannot Manipulate the Data',16,1)

update Holiday set holiday_date='14-Aug' where holiday_date='15-Aug'











