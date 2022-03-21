create database EmployeManagement
use EmployeManagement
create table Employee(empno int primary Key,
					  empname varchar(50) not null,
					  empsal numeric(10,2)check(empsal>=25000),
					  emptype varchar(1) check(emptype in('c','p')))
insert into Employee
values(1,'Sunitha',45000,'p'),
(2,'Anjali',34000,'c')
select*from Employee

create or alter procedure Emp_Management  @ename varchar(30),@esal numeric(10,2),@etype varchar(1)
as
begin
	declare @eid int=(select max(empno) from Employee)
	begin
		
		declare @empid int=@eid+1;
		insert into Employee values(@empid,@ename,@esal,@etype)
	end
end
