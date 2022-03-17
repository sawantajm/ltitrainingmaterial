use dbcourseregistarion_1000
--subquery
--order by cannot use sub query
--1.single row subquery 2. multirow subquery
--1.single row subquery <,>,<=,>=,=,!

--inner query return single row

--(outer query <,>,<=,>=,!(inner query))
--select course details whose fee is greter than fees of course .net001

select * from tblcourse
select * from tblcourse where fees>
(select fees from tblcourse where courseid='.Net001')

--select coursedetails whos fess is less than fess of course .net1
select * from tblcourse where fees<(select fees from tblcourse where courseid='.net001')
--display the depid,avg salary of all department  whose average  salary is > avg
select deptno,avg(salary) from EMP
group by deptno
having avg(salary)>
(select avg(salary ) from EMP where deptno=103)

--delete the employee whose department is accounting  
select * from department
select * from EMP
delete from EMP where deptno=
(select deptno from department where dname='Acounting')
--Multiple row subqueries all,any,in

--display name and salary of employee whose salary is equal to one of the salaries of employee in dept 102

select Ename,salary,deptno from EMP where salary in

(select salary from tblEmployee where did=102) and did != 102

select Ename,salary,Did from tblemployee where salary < all

(select salary from tblEmployee where did=101)

select Ename,salary,Did from tblemployee where salary > any

(select salary from tblEmployee where did=101) and did != 101


--find employees whose salary is greater than min salary of any employee

--T-sql

/*

if, while ,continue, case and when

*/

--Stored procedure

--set of sql statement

--query plan or execution plan--reused

--DDL,DML,DQL,TQL

/*create procedure procedurename

as

begin

sql tatement

end*/

--Ex1 without parameter

create procedure spu_course

as

begin

select * from tblcourse

end

--to run

exec spu_course

--Ex 2 with parameter

alter procedure spu_insertcourse

(@cid varchar(20),@cname varchar(20),@sdate date,@edate date,@fee int,@mstudents int,@moc varchar(35),@ia bit)

as

begin

insert into tblcourse(courseid,coursename,startdate,enddate,fee,maxiumstudents,modeofcourse,isavailable) values

(@cid,@cname,@sdate,@edate,@fee,@mstudents,@moc,@ia)

end

exec spu_insertcourse @cid='AI1', @cname ='AI',@sdate ='2022-3-12',@edate='2022-5-7',@fee=67000,@mstudents=23,@moc='offline',@ia=1

--Ex3

--soft delete

create proc spu_tblcousesoftdelete (@cid varchar(30))

as

begin

if(@cid is not null)

begin

update tblcourse set isavailable=0 where courseid=@cid

end

else

begin

print 'cid is not having valid data'

end

end

exec spu_tblcousesoftdelete @cid='ccna1'

--Ex4 with return

/* sp can return integer

sp can return only one integer at a time*/

create procedure spu_maxfee

as

begin

return(select max(fee) 'max fee 'from tblcourse)

end

--execute

declare @getfee int

exec @getfee=spu_maxfee

print @getfee

--Ex5

create procedure spu_quaification

as

begin

select qualification,COUNT(studentid) from tblenrollment

where studentname like '[a-l]%'

group by qualification

having count(studentid)>=2

end

exec spu_quaification

--ex 5 sp with out parameter

--in -i/p parameter out- output parameter

-------------------------------Stored procedure---------------------------------------
create procedure spu_noofstudent(@noofstu int output)

as 
begin
set @noofstu =(select count(studentid) from tblenrollment)
end 

declare @stuno int
exec spu_noofstudent @ stuno output
if(@stuno>0)
print @stuno

else
print 'no record '


--create a table tblmarks cid,sid,marks
--create procedure to insert the record in tblmarks



--can we call a procedure from another  procedure ? yes


create procedure spu_callsp
as
begin
exec spu_course 
end

exec sp_callsp


--create a procedure to dispaly studentname coursename to which they have register
select * from tblenrollment
select * from tblcourse
select * from tblcourseregistration



create procedure  sp_dispalydata
as 
begin
select studentname ,coursename from ((tblcourse c inner join tblcourseregistration r on c.courseid=r.cid)inner join tblenrollment  e on e.studentid=r.sid)


end

exec sp_dispalydata

/* Function 
/* Function
 1.system defined function  2.user defined function - scalar function ,table valued function
 
 function cant return  -text,ntext,image,crsor,timestamp
 --ddl,dml,dcl cant be used in function ,only dql-select can be used in function
 create function functionname (parameterlist)
 returns datatype
 begin
 statement
 return value 
 */
 
-- scalar function 
--finding the year of birth for student
*/
create function fun_yearofbirth(@sid int)
returns int as
begin
return(select (DATEPART(YEAR,GETDATE())-age) from tblenrollment where studentid =@sid)
end



--exec

select studentid,studentname,age,dbo.fun_yearofbirth(studentid)'year of birth' from tblenrollment

--employee database tax Calculation
select * from EMP
create function fun_employeetax(@eid int)
returns float
as begin 
declare @tax float,@annualsalary float
set @annualsalary=(select salary*12 from EMP where empno=@eid)
if(@annualsalary>50000)
begin
set @tax=@annualsalary*0.1
end
begin
set @tax=0
end
return @tax
end


select ename,salary,dbo.fun_employeetax(empno)'Tax' from EMP



--table function 
/*
create functionn functionname parameterlist
retuen table 
as statement
retuen

*/

create function fun_stu()

returns table

as
return(select studentid,studentorganizer,age from tblenrollment)


select studentid,studentorganizer from dbo.fun_stu()



alter function fun_stu(@g varchar(10))
returns table
as
return(select studentid,studentorganizer,age from tblenrollment where gender=@g)


select studentid,studentorganizer,age from dbo.fun_stu('female')

--can we call a proceduer inside function ? no
--can we call a function inside a procedure? yes


--Integrity constarint
 select * from books


 create table book(bid int primary key,bname varchar(30))

 insert into book(bid,bname) values(1,'java'),(2,'os'),(3,'NW')


 create table reder(rid int primary key,rname varchar(30),bookid int references book(bid) on delete cascade
 on update cascade)

 insert into reder(rid,rname,bookid) values(1001,'sai',1),(1002,'ravi',1),(1003,'abi',3),(1004,'suman',3)



 --TCL(transaction control language) save,commit,rollback

 begin transaction t
 insert into book(bid,bname) values(5,'Dsp')
 save transaction s1
 insert into book(bid,bname) values(6,'EI'),(7,'Dbms')
 save transaction s2
 delete from book where bid=10
 select * from book
 rollback transaction s1

 select * from book


 --commit
 --dont use save in n commit
 begin transaction t1
 insert into book(bid,bname) values(6,'od')
 commit transaction t1
 rollback transaction t1