create database CentreMedDatabase;

------------------------------------
use CentreMedDatabase;

drop table Treatment;
drop table Laboratory_Result;
drop table Test_Type;
drop table Disease_Category;
drop table Disease;
drop table Payment;
drop table Visit;
drop table Doctor_Category;
drop table Doctor_Department;
drop table Doctor;
drop table Department;
drop table Category;
drop table Patient;

------------------------------------

CREATE TABLE Patient
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
	First_Name VARCHAR(255) NOT NULL ,
	Last_Name VARCHAR(255) NOT NULL ,
	Middle_Name VARCHAR(255),
	PhoneNumber varchar(255) NOT NULL ,
	Email varchar(255),
	Gender VARCHAR(255) NOT NULL 
)

CREATE TABLE Category
(
   Id INT PRIMARY KEY IDENTITY NOT NULL,
   Name VARCHAR(255) NOT NULL 
)

CREATE TABLE Department
(
   Id INT PRIMARY KEY IDENTITY NOT NULL,
   Department_Name VARCHAR(255) NOT NULL 
)

CREATE TABLE Doctor
(
  Id INT PRIMARY KEY IDENTITY NOT NULL,
  Full_Name VARCHAR(255) NOT NULL ,
  Phone_Number VARCHAR(255),
  Email VARCHAR(255),
  Price_Per_Visit MONEY
)

CREATE TABLE Doctor_Department
(
  Doctor_Id INT NOT NULL, 
  Department_Id INT NOT NULL, 
  FOREIGN KEY (Doctor_Id) REFERENCES Doctor(Id),
  FOREIGN KEY (Department_Id) REFERENCES Department(Id)
)

CREATE TABLE Doctor_Category
(
  Doctor_Id INT NOT NULL, 
  Category_Id INT NOT NULL, 
  FOREIGN KEY (Doctor_Id) REFERENCES Doctor(Id),
  FOREIGN KEY (Category_Id) REFERENCES Category(Id)
)

CREATE TABLE Visit
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
	Patient_Id INT NOT NULL,
	Doctor_Id INT NOT NULL,
    Visit_Date DATE NOT NULL,
	Total_Price MONEY,
	Prescriptions VARCHAR(500),
	FOREIGN KEY (Patient_Id) REFERENCES Patient(Id),
	FOREIGN KEY (Doctor_Id) REFERENCES Doctor(Id)
)

CREATE TABLE Payment
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
	Visit_Id INT NOT NULL,
	Amount DECIMAL,
	Payment_Date DateTime NOT NULL,
	FOREIGN KEY (Visit_Id) REFERENCES Visit(Id)
)

CREATE TABLE Disease
(
  Id INT PRIMARY KEY IDENTITY NOT NULL,
  Name VARCHAR(255) NOT NULL
)

CREATE TABLE Disease_Category
(
  Disease_Id INT NOT NULL,
  Category_Id INT NOT NULL,
  FOREIGN KEY (Disease_Id) REFERENCES Disease(Id),
  FOREIGN KEY (Category_Id) REFERENCES Category(Id)
)

CREATE TABLE Test_Type
(
   Id INT PRIMARY KEY IDENTITY NOT NULL,
   Name VARCHAR(255) NOT NULL
)

CREATE TABLE Laboratory_Result
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Test_Type_Id INT NOT NULL,
	Result VARCHAR(500) NOT NULL,
	Date DATETIME NOT NULL,
	FOREIGN KEY (Test_Type_Id) REFERENCES Test_Type(Id)
)

CREATE TABLE Treatment
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
	Visit_Id INT NOT NULL,
	Laboratory_Result_Id INT NOT NULL,
	Disease_Id INT NOT NULL,
	Prescriptions VARCHAR(500),
	FOREIGN KEY (Visit_Id) REFERENCES Visit(Id),
	FOREIGN KEY (Laboratory_Result_Id) REFERENCES Laboratory_Result(Id),
	FOREIGN KEY (Disease_Id) REFERENCES Disease(Id)
)