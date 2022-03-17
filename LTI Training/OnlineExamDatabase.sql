create database OnlineExam
use OnlineExam



create table Registration(User_id int identity(0,1) primary key,Fullname varchar(50),Email varchar(50) unique ,Password varchar(50),City varchar(50),DOB date,State varchar(50),
Qualification varchar(50),Year_of_Completion date,Mobile_no varchar(50));




create table Subject(Subject_id int primary key,Subject_name varchar(50) );






create table Level(Level_id int primary key, Level_Name varchar(100));




create table Exam(Exam_id int primary key,Questions nvarchar(255),Question_id int,
File_id int,Subject_id varchar(50));






create table ExamDetails(Duration time,Level_id int references level(Level_id),Cutoff int,Exam_id int references Exam(Exam_id) );





create table Filename(File_id int primary key, File_Name varchar(50));




create table QuestionDetails(Question_id int primary key,File_id int references Filename(File_id),Question nvarchar(255)
,Option1 varchar(50),Option2 varchar(50),Option3 varchar(50),Option4 varchar(50),Correctanswers varchar(50),Subject_id int references Subject(Subject_id),Level_id int references level(Level_id));



create table ReportDetails(User_id int references Registration(User_id),Level_id int references level(Level_id),
MarksObtained int, Subject_id int references Subject(Subject_id));




create table Admin_Login(Email varchar(50),Password varchar(50));





select * from Registration
select * from Subject
select * from ReportDetails
select * from Exam
select * from ExamDetails
select * from level
select * from QuestionDetails
select * from Filename
select * from AddQuestion




insert into Registration (Fullname,Email,Password,City,DOB,State,Qualification,Year_of_Completion,Mobile_no)
values('Rahul Tripathi ','rahul@gmail.com','rahul@123','Nashik','2000-06-13','Maharashtra','BE','2021',9876546792),
('Akshay Aher ','Akshay@gmail.com','akhay@123','A.Nagar','2000-05-16','Maharashtra','Bsc','2019',9966546792),
('Rameshwar Rothe','rameshwar@gmail.com','rameshwar@123','Mumbai','2000-06-17','Maharashtra','ME','2020',9876746792),
('Sam Rathod','sam@gmail.com','sam@123','Aurangabad','2000-06-15','Maharashtra','BE','2015',9860546792)




insert into Subject(Subject_id,Subject_name)values(1,'java'),(2,'c#.Net'),(3,'c++');


insert into ReportDetails(User_id,Level_id,MarksObtained,Subject_id) values(0,1,67,1),(1,1,70,3),(2,1,80,2);

create table AddQuestion(QuestionNumber int primary key, Question nvarchar(255)
,Option1 varchar(50),Option2 varchar(50),Option3 varchar(50),Option4 varchar(50),Correctanswer varchar(50));


select * from QuestionDetails

create table ForgotPassword(Email varchar(50) references Registration(Email),Emailsent BIT);