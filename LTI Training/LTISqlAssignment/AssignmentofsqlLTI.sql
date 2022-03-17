create database Assignment;

use Assignment;
create table Clients(Client_ID int primary key,Cname Varchar(40) Not Null,Address Varchar(30),Email varchar(30)unique,Phone int,Business varchar(20) Not Null );
alter table Clients alter column Phone bigint
sp_help Clients;

 


insert into Clients values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing')

insert into Clients(Client_ID,Cname,Address,Email,Phone,Business) values
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090 ,'Consultant'),
(1003 ,'MoneySaver Distributors',' Kolkata' ,'save@moneysaver.com', 7799886655 ,'Reseller'),
(1004,'Lawful Corp' ,'Chennai', 'justice@lawful.com' ,9210342219 ,'Professional')

select * from Employees
create  table Employees(Empno int Primary key, Ename varchar(20)Not NUll,Job varchar(15), salary int check(salary>0),Deptno int references Departments(Deptno));
select * from Departments

