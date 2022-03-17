use dbcourseregistarion_1000


select * from tblcourse;


create table tblenrollment(studentid int identity(100,1) primary key,studentname nvarchar(20) not null,
gender varchar(20) check(gender in ('male','female','others')),
age int constraint ck_age check(age>20),
city varchar(30) default 'not entered',
qualification varchar(20),mailid varchar(30) not null unique,contactno varchar(20))

sp_help tblenrollment;



--best approch for iserting a records


insert into tblenrollment(studentname,gender,age,city,qualification,mailid,contactno) values
('sai','male',23,'Btech','Aurangabad','sai@gmail.com','8956328464'),
('anu','female',24,'Mtech','Nashik','anu@gmail.com','8956328465'),
('banu','female',26,'Bsc','Pune','banu@gmail.com','8956328452'),
('sasi','male',23,'Msc','Nagpur','sasi@gmail.com','8956518464')




-- Error
insert into tblenrollment values('ram','male',23,'vaijapur','Btech','ram@gmail.com','8656953220')


select * from tblenrollment

--check constaint voilation 

insert into tblenrollment(studentname, gender,age,city,qualification,mailid,contactno) values
('sai','male',20,'Btech','Aurangabad','sai2@gmail.com','8956328464')


-- uniue key voilation
insert into tblenrollment(studentname, gender,age,city,qualification,mailid,contactno) values
('sai','male',20,'Btech','Aurangabad','sai@gmail.com','8956328464')


-- not null
insert into tblenrollment(studentname, gender,age,city,qualification,mailid,contactno) values
('sai','male',20,'Btech','Aurangabad','8956328464')

update tblenrollment set city='Goa',qualification = 'Bsc' where  studentid =107

-- group by

select * from tblenrollment

--select column list from tablename where condition group by columnlist
-- group by aggregate function

--display no of female 

select gender ,count(studentid) from tblenrollment group by gender

-- using group by with order by 


--dispaly no of males and female age>23

select gender, count(studentid) from tblenrollment  where age>23 group by gender
select * from tblenrollment


--Display the no of person under each degree

select qualification, count(studentid) from tblenrollment group by qualification



--Display the no of person from each city

select city, count(studentid) 'no of person' from tblenrollment group by city


create table tblcourseregistration(cid varchar(20)references tblcourse(courseid),
sid int references tblenrollment(studentid),payment varchar(25),status nvarchar(20))

select * from tblcourse
select * from tblenrollment
insert into tblcourseregistration(cid,sid,payment,status) values
('.Net001',103,'pending','notregistered'),
('Java002',104,'payed','registered'),
('Java002',103,'payed','registered')


select * from tblcourseregistration


--join
 -- inner join
 --left join
 --right join
 --full join

 --select cloumns from table1 (join) table2 on  table1.columnname =table2.columnname

 --inner join

 select *  from tblcourse inner join tblcourseregistration on tblcourse.courseid= tblcourseregistration.cid


 --left join
 select * from tblcourse c left join tblcourseregistration r on c.courseid=r.cid

 --rightjoin
 insert into tblcourseregistration(payment,status) values ('pending','notregistered')
 select * from  tblcourse c right join tblcourseregistration r on c.courseid=r.cid

 --full join or full outer join

 select * from  tblcourse c full join tblcourseregistration r on c.courseid= r.cid

select * from  tblcourse c full outer join tblcourseregistration r on c.courseid= r.cid


--self referances
alter table tblenrollment add studentorganizer int references tblenrollment(studentid)

--update tblenrollment set studentorganizer=100 where studentid in() 


--Having
 --agrregate function cant use in having clause

 --select * from  tblcourse where max(maxstudent)>10


 select * from tblcourseregistration

 select cid, count(sid) from tblcourseregistration group by cid having count(sid)>=1

 select cid, count(sid) from tblcourseregistration group by cid having count(sid)>=1 order by cid desc

 --display the no of student under each qualification

 select qualification,count(studentid)  from tblenrollment where
 studentname like '[a-l]%' group by qualification 
 having count(studentid)>=1




  drop table books
 create table books(id varchar(20) primary key, title varchar(30), outhor varchar(30),
 isbn  varchar(20) unique, published_date date)

 

 insert into books(id,title,outhor,isbn,published_date) values
 (2,'my_second_sql_book','john meyer',857300923713,getdate()),
 (3,'my_third_sql_book','cary flint',523120967812,getdate())

 select * from books

 

 -- view 



 create  view v_studinfo 
 as select studentname,qualification,city from tblenrollment

 select * from v_studinfo

 --alter

 alter view v_studinfo 
 as select studentname,qualification,city,age from tblenrollment


 --drop

drop view v_studinfo 


--Ex2

create view v_coursetu
as select e.studentname, r.status from tblenrollment e, tblcourseregistration r
where e.studentid=r.sid

select * from v_coursetu


--Ex3
create view v_coursetu1 
as select e.studentname ,r.status from tblenrollment e inner join tblcourseregistration r 
on e.studentid=r.sid


alter view v_coursetu1 
as select e.studentname, r.status from tblenrollment e inner join tblcourseregistration r
on e.studentid=r.sid 
where contactno is not null

select * from v_coursetu1 


--display the no of registered and not redisterd student using view 

create 



create view v_age
as select studentid,studentname,age,gender,mailid from tblenrollment
 
 select * from v_age

 insert into v_age(studentname,age,gender,mailid) 
 values('aaa',19,'male','a@gmail.com')

 --without check option 



 --insertion takes place consistancy not maintain
 select * from v_age

 select * from tblenrollment

 alter view v_age 
 as select studentid,





