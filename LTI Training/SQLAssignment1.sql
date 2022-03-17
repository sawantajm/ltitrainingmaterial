use dbcourseregistarion_1000

sp_help Emp



--create table employee
create table EMP(empno int primary key,ename varchar(20),job varchar(20),age int check(age>21),
mgr int,hiredate date,salary int,comm int,
deptno int references department(deptno))


select * from EMP


--create table department
create table department(deptno int primary key,dname varchar(20),location varchar(20))

select * from department


--create table manager
drop table manager
create table manager(managerid int references EMP(empno),deptno int references department(deptno)  )


--insert data in manager table
insert into manager(managerid,deptno) values(7902,20),(7698,30),(7839,20),(7566,20),
(7788,20),(7782,10),(7839,10)

--Show table
select * from manager



--insert data in employee table
insert into EMP(empno,ename,job,age,mgr,hiredate,salary,comm,deptno)
values(7369,'Smith','Clerk',24,7902,'17-Dec-80',1900,800,20),
(7499,'Allen','Salesman',23,7698,'20-Feb-81',1600,300,30),
(7521,'Ward','Salesman',25,7698,'22-Feb-81',1250,500,30)

--insert data in employee table
insert into EMP(empno,ename,job,age,mgr,hiredate,salary,comm,deptno)
values(7654,'Mrtin','salesman',26,7698,'28-sep-81',1250,1400,30)

insert into  EMP(empno,ename,job,age,mgr,hiredate,salary,deptno)
values(7566,'Jones','Manager',25,7839,'02-Apr-81',2975,20),
(7698,'blake','Manager',25,7839,'01-May-81',2850, 30),
(7782,'Clark','Manager',24,7839,'09-Jun-81',2450,10),
(7788,'Scott','Analyst',28,7566,'19-Apr-87',3000,20),
(7844,'Tuner','Salesman',27,7698,'17-Sep-81',15000,30),
       (7876,'Adams','Clerk',25,7788,'13-May-81',1100,20),
         (7900,'James','Clerk',28,7698,'3-Dec-81',950,30),
         (7902,'Ford','Analyst',26,7566,'3-Dec-81',3000,20),
          (7934,'Miller','Clerk',29,7782,'23-Jan-82',1300,10)




insert into EMP(empno,ename,job,age,hiredate,salary,deptno)
values(7839,'King','President',26,'28-Sep-81',1250,30)



--Q1. List all employees whose name begins with 'A'. 

select * from EMP where ename like 'a%'

--Q2. Select all those employees who don't have a manager
select * from EMP where mgr is null


--update EMP set salary=5000,deptno=10 where empno=7839


--Q3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select empno,ename,salary from EMP where salary between 1200 and 1400


--Q4.Give all the employees in the RESEARCH department a 10% pay rise.
select  salary=salary+(salary*10/100)from EMP where deptno=20 

--Q5. Find the number of CLERKS employed. Give it a descriptive heading. 

select job,count(*) 'no of Employee' from EMP where job='Clerk' group by job

--Q6. Find the average salary for each job type and the number of people employed in each job. 

select job, avg(salary)as avreage_salary,count(*)'no_of_employee' from EMP group by job

--Q7. List the employees with the lowest and highest salary. 
select min(salary)'min salary',max(salary)'max salary'from EMP
  
 
--Q8. List full details of departments that don't have any employees

select * from department where deptno not in(select deptno from EMP)
 
select * from manager
--Q9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.
select ename,salary from EMP where job='analyst'and salary>1200

select * from department

--Q10. For each department, list its name and number together with the total salary paid to employees in that department.s
 

select d.deptno,sum(e.salary)'Total Salary' from department d left join EMP e on d.deptno =e.deptno group by d.deptno