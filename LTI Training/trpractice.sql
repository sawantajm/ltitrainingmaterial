--create database 
create database dbcourseregistarion_1000;
use dbcourseregistarion_1000;
create table tblcourse(courseid varchar(20), coursename  varchar(35),startdate date,enddate date, fees int,maxstudent int,modeofcourse varchar(20));

sp_help tblcourse;
 drop table tblcourse;

 -- create table with primary  key 
 create table tblcourse(courseid varchar(20) primary key, coursename varchar(30), startdate date,enddate date,fees int, maxstudent int, modeofcourse varchar(30));

 --alter command
alter table tblcourse add constraint  pk_cid primary key(courseid);
-- insert multiple records in table 
insert into tblcourse(courseid,coursename,startdate,enddate,fees,maxstudent,modeofcourse) values ('Java001','JavaBasics','2022-1-10','2022-1-25',7000,15,'online'),('Java002','JavaAdvance','2022-1-10','2022-2-28',20000,15,'online'),('AI001','AIBasics','2022-2-5','2022-4-5',7000,15,'online'),('.Net001','.NetFramework','2022-2-10','2022-3-28',25000,10,'online')

select * from tblcourse;
-- insert one record
insert into tblcourse values('.Net2','.NetCore','2022-2-12','2022-3-28',30000,12,'offline')

--update 

update tblcourse set modeofcourse='online' where courseid='.Net2';


--delete 
 --Hard Delete,Soft delete

 --Hard delete

 delete from tblcourse where courseid='AI001';


 --Adding column in to tblcourse 

 alter table tblcourse add isavailable bit;

 select * from tblcourse;

 update tblcourse set isavailable=1
 --common update 
 
 update tblcourse set isavailable=0 where courseid='.Net2'


 update tblcourse set isavailable=0 where courseid='.Net2'

 sp_help tblcourse

 --delete all records
 --what is the difference truncate and delete

--truncate means delete all records from table structure as it is

--DQL select

select * from tblcourse;



--selecting perticular columns

select courseid,coursename from tblcourse;


select courseid,fees, coursename from tblcourse;

--Alise Name

select coursename as course,fees 'Course Fee' from tblcourse;

--Relational Operator >,<,>=,<=,=,or,between


select coursename,fees, maxstudent from tblcourse where fees>2000;


select coursename fees,maxstudent from tblcourse where maxstudent>10 and maxstudent<=15;

select coursename,fees, maxstudent from tblcourse where fees between 2000 and 70000;
 
 select coursename, fees, maxstudent from tblcourse where startdate between '2022-1-1' and '2022-1-15'

 select * from tblcourse;

 --Negative oprator , !


 select coursename,fees,maxstudent from tblcourse where not startdate between '2022-1-10' and '2022-2-15';
 select  * from tblcourse where maxstudent!=15;


 --null 
 select * from tblcourse where isavailable is null

 select * from tblcourse  where isavailable is not null

 select * from tblcourse where isavailable = null

 ---IN   
 select courseid,enddate from tblcourse where enddate in('2022-3-15','2022-5-2', '2022-2-17')

  select * from tblcourse where endate('2020-1-1,2022','200-4-25')

  select courseid,enddate from tblcourse where enddate in('2022-3-15','2022-4-
28','2022-2-17')




 

select courseid,enddate from tblcourse where enddate ='2022-3-15' or enddate ='2022-4-28' or enddate ='2022-2-17'



 --Arithmatic operator +,-,/*,%
 select * from tblcourse
 update tblcourse set maxstudent=maxstudent+2
 update tblcourse set maxstudent=maxstudent-7 where coursename='Javaadvanced'
 --Like operator %-zero or more character,_ -->single character,[],^
 select courseid,coursename from tblcourse where coursename like 's%' --startingwith s
select courseid,coursename from tblcourse where coursename like '%v' --ends with a
select courseid,coursename from tblcourse where coursename like '%a_%'
select courseid,coursename from tblcourse where coursename like '_a%'--eshould be in second position
select courseid,coursename from tblcourse where coursename like '[a-l]%' --course name start letter is from a to l
 select courseid,coursename from tblcourse where coursename like 'j[^bc]%'--first character as j not second character as b or c
--Number function
select CEILING(167.90)
select floor(167.90)
select TAN(45)
--area of circle
declare @r int =3,@areaofcircle float
set @areaofcircle=PI()*SQUARE(@r)
print @areaofcircle
--Character function
select LOWER(coursename) 'Course Name' from tblcourse
select upper(coursename) 'Course Name' from tblcourse
select coursename,charindex('o',coursename) 'Course Name' from tblcourse
select CONCAT_WS(' ',courseid,coursename) from tblcourse
--Date and Time Function
select GETDATE() 'current data and time'
select CONVERT(date,GETDATE()) 'Date'
select datepart(DAY,GETDATE()) 'Day'
select datepart(Month,GETDATE()) 'Month'
select datepart(Year,GETDATE()) 'year'
select Dateadd(DAY,5,GETDATE()) 'adding 5 days with Today'
--finding the duration of course
select coursename,datediff(DAY,startdate,enddate) 'CourseDuration' from tblcourse
--Aggregate function --works in groups Min,Max,Avg,Sum,count
select * from tblcourse
select count(coursename) from tblcourse
select count(isavailable) from tblcourse --count exclude null values
select min(maxstudent) from tblcourse
select max(maxstudent) from tblcourse
--Order by asc,desc
--select coulumn list from tablname where condition order by column1 ,...columnN
select * from tblcourse order by maxstudent
select * from tblcourse order by maxstudent desc
select * from tblcourse where fees > 7000 order by maxstudent desc
select * from tblcourse order by modeofcourse,maxstudent desc
select * from tblcourse order by len(coursename)
--based on column in select list
select courseid,fees,startdate from tblcourse order by 3 desc
select courseid,fees,startdate from tblcourse order by 2