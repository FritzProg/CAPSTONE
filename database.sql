CREATE DATABASE dbLIBRARY1
GO

USE master
GO

USE dbLIBRARY1
GO

CREATE TABLE tblAUTHORS
(
Author_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Author_Name varchar(50),
Author_No VARCHAR(10)

);
GO

ALTER TABLE tblAUTHORS
ADD PRIMARY KEY (Author_Id);

--Author_Name, Author_No-- 

Select * from tblAUTHORS
GO

CREATE TABLE tblBOOK
(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Accession_No int,
book_Title varchar(50),
book_Publication varchar (50),
book_DateReceived date,
book_Edition varchar (50),
book_Pages int,
book_Year int,
book_SourceofFund varchar(50),
book_ISBN varchar(20),
-- Class Number --
book_SubjectArea varchar(50),
book_DeweyDecimal decimal(8,3),
book_Publisher varchar (50),
book_Author_No INT,
FOREIGN KEY (book_Author_No) REFERENCES tblAUTHORS(Author_Id)
);
GO

--Accession_No, book_Title, book_Publication, book_DateReceived, book_Edition, book_Pages, book_Year, book_SourceofFund, book_ISBN, book_ShelfLocation, book_Author, book_DeweyDecimal, book_Publisher--




ALTER TABLE tblBOOK
ALTER COLUMN book_DeweyDecimal decimal(8,3);

ALTER TABLE tblBOOK
ADD book_Copies varchar (50);

Select * from tblBOOK, tblAUTHORS;

DELETE  FROM tblAUTHORS;

