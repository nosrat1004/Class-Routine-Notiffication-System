CREATE DATABASE CRNDB;
USE CRNDB;

CREATE TABLE Teacher(
	Name		VARCHAR(50) NOT NULL,
	Id			VARCHAR(30) PRIMARY KEY,
	[Password]	VARCHAR(50) NOT NULL,
	Category	VARCHAR(50) NOT NULL,
	Email		VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(50) NOT NULL,
	
)

CREATE TABLE Guardian(
	Name		VARCHAR(50) NOT NULL,
	Id          INT PRIMARY KEY,
	Email       VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(50) NOT NULL,
)

CREATE TABLE Student(
	Name			VARCHAR(50) NOT NULL,
	Id				VARCHAR(50) PRIMARY KEY,
	[Address]		VARCHAR(MAX) NOT NULL,
	GID				INT NOT NULL,
	Semester		VARCHAR(50) NOT NULL,
	Batch			VARCHAR(50) NOT NULL,
	
	CONSTRAINT FK_S_GID FOREIGN KEY (GID)
	REFERENCES Guardian(Id) ON DELETE CASCADE
)

SELECT * FROM Teacher

SELECT * FROM Guardian

SELECT * FROM Student


CREATE PROC SELECT_STUDENT
AS
BEGIN
	SELECT * FROM STUDENT
END

CREATE PROC SELECT_TEACHER
AS
BEGIN
	SELECT * FROM TEACHER
END

CREATE PROC SELECT_GUARDIAN
AS
BEGIN
	SELECT * FROM GUARDIAN
END


create table NoticebleRoutine
(
	ID				INT IDENTITY PRIMARY KEY,
	CourseCode		VARCHAR(50) NOT NULL,
	[Days]			VARCHAR(15) NOT NULL
)

select * from NoticebleRoutine

select email from guardian

CREATE PROC IS_HAVE_CLASS 'thursday'  
@dayName VARCHAR(15)
AS
BEGIN
	SELECT * FROM NoticebleRoutine
	WHERE [Days] = @dayName
END


select * from NoticebleRoutine



create proc select_guardian_email_by_student '16c' 
@batch varchar(15)
as
begin
	select * from guardian 
	join student
	on guardian.id = student.gid
	where batch = @batch
end


select * from NoticebleRoutine
select * from Student
select * from Guardian