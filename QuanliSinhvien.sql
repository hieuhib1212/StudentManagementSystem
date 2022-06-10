USE master
--DROP DATABASE StudentManagement
GO
CREATE DATABASE StudentManagement
GO

USE "StudentManagement"
-- Student
-- Subject
-- Score
GO

CREATE TABLE Student(
   StudentID NVARCHAR(50) PRIMARY KEY,
   StudentName NVARCHAR(50) NOT NULL,
   StudentGender BIT NOT NULL,
   StudentDOB DATETIME NOT NULL,
   StudentEmail NVARCHAR(50) NOT NULL,
   StudentLogin NVARCHAR(50) NOT NULL,
   StudentPassword NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE [Subject](
   SubjectID NVARCHAR(50) PRIMARY KEY,
   SubjectName NVARCHAR(300) NOT NULL
)
GO
INSERT INTO [Subject] VALUES(N'CEA201', N'Computer Organization and Architecture')
INSERT INTO [Subject] VALUES(N'SSG101', N'Working in Group Skills')
INSERT INTO [Subject] VALUES(N'PRJ311', N'Desktop Java Applications')
INSERT INTO [Subject] VALUES(N'LAB221', N'Desktop Java Lab')
INSERT INTO [Subject] VALUES(N'SWT301', N'Software Testing')
INSERT INTO [Subject] VALUES(N'PRM391', N'Mobile Programming')
INSERT INTO [Subject] VALUES(N'MAS291', N'Statistics and Probability')
INSERT INTO [Subject] VALUES(N'OSG202', N'Operating Systems')
INSERT INTO [Subject] VALUES(N'CSD201', N'Data Structures and Algorithms')
INSERT INTO [Subject] VALUES(N'MAE101', N'Mathematics for Engineering')
INSERT INTO [Subject] VALUES(N'PRF192', N'Programming Fundamentals')
INSERT INTO [Subject] VALUES(N'DBI202', N'Introduction to Databases')
INSERT INTO [Subject] VALUES(N'MAD101', N'Discrete mathematics')
INSERT INTO [Subject] VALUES(N'WED201', N'Web Design')
INSERT INTO [Subject] VALUES(N'IOT101', N'Internet of Things')
GO

INSERT INTO Student
VALUES(N'HE140173', N'Bùi Văn Vinh', 1, CONVERT(VARCHAR, '12/30/2013', 103),N'abc@gmail.com', N'Vinhbvhe140173', '1234567')
GO
INSERT INTO Student
VALUES(N'HE150173', N'Nguyễn Minh Hiếu', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com', N'Hieunmhe150173', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140172', N'Phạm Nhật Duy', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Duypnhe140172', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140154', N'Dương Đình Vũ', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Vuddhe140154', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140123', N'Phạm Nhật Thành', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Thanhpnhe140123', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140165', N'Lê Thị Vân', 0,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Vanlthe140134', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140177', N'Nguyễn Hải Anh', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Anhnhhe140177', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140393', N'Triệu Văn Long', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Longtvhe140393', '1234567')
GO
INSERT INTO Student
VALUES(N'HE140134', N'Bùi Minh Hiệu', 1,CONVERT(VARCHAR, '12/30/2013', 103), N'abc@gmail.com',N'Hieubmhe140134', '1234567')
GO
CREATE TABLE [Admin](
   AdminID INT PRIMARY KEY,
   AdminLogin NVARCHAR(50) NOT NULL,
   AdminPassword NVARCHAR(50) NOT NULL
)
GO
INSERT INTO [Admin]
VALUES(12, N'Admin0101', '1234567')
GO
INSERT INTO [Admin]
VALUES(13, N'Admin0202', '1234567')
GO
CREATE TABLE StudentSubjectStatus(
   StudentID NVARCHAR(50) FOREIGN KEY REFERENCES Student(StudentID),
   SubjectID NVARCHAR(50) FOREIGN KEY REFERENCES [Subject](SubjectID),
   SubjectStatus INT,
   CONSTRAINT PK_Student PRIMARY KEY (StudentID,SubjectID)
   --0-In progress
   --1-Not passed
   --2-Passed
)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE150173', N'WED201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE150173', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE150173', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE150173', N'MAE101', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140172', N'WED201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE140172', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140172', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140172', N'MAE101', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140154', N'WED201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE140154', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140154', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140154', N'MAE101', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140123', N'WED201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE140123', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140123', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140123', N'MAE101', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140173', N'WED201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE140173', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140173', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140173', N'MAE101', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140177', N'CSD201', 1)
INSERT INTO StudentSubjectStatus VALUES(N'HE140177', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140177', N'OSG202', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140177', N'PRF192', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140177', N'WED201', 0)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140134', N'OSG202', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140134', N'MAS291', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140134', N'WED201', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140134', N'IOT101', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140134', N'PRM391', 1)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140393', N'MAE101', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140393', N'MAS291', 0)
INSERT INTO StudentSubjectStatus VALUES(N'HE140393', N'IOT101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140393', N'OSG202', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140393', N'PRM391', 2)
GO
INSERT INTO StudentSubjectStatus VALUES(N'HE140165', N'PRF192', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140165', N'DBI202', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140165', N'MAD101', 2)
INSERT INTO StudentSubjectStatus VALUES(N'HE140165', N'CEA201', 2)
GO
SELECT * FROM Student WHERE StudentID='HE140154'
SELECT SubjectStatus FROM StudentSubjectStatus WHERE StudentID='HE140154' AND SubjectID='IOT101'
