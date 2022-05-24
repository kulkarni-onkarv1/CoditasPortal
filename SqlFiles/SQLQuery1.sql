Create Database CoditasPortalDb;

Create Table Users(
     ID nvarchar(1024) Primary Key,
	 UserName nvarchar(512) Unique Not Null,
     Email nvarchar(256) Not Null,
     Password nvarchar(max) Not Null,
     PhoneNumber nvarchar(256) Not Null, 
     LockOutStatus int Not Null);

--drop table Users;

Create Table UserBiometrics(
		 ID nvarchar(1024) Primary Key Foreign Key References Users(ID),
		 FirstName nvarchar(256) Not Null,
         LastName nvarchar(256) Not Null,
		 Gender nvarchar(256) Not Null,
		 DOB Date Not Null);

--drop table UserBiometrics

