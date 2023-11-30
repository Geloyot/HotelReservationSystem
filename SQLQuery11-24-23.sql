USE DBSYS

CREATE TABLE StaffInfo(
	StaffID int IDENTITY(1000, 1) PRIMARY KEY,
	roleId int REFERENCES [Role](roleId),
	userId int REFERENCES UserAccount(userId),
	StaffFirstName varchar(255) NOT NULL,
	StaffLastName varchar(255) NOT NULL,
	StaffBirthDate datetime NOT NULL,
	StaffGender varchar(99) NOT NULL DEFAULT 'Prefer not to say',
	StaffContactNo varchar(99) NOT NULL DEFAULT 'Unknown',
	StaffEmailAddress varchar(99) NOT NULL,
	StaffSalary decimal(9, 2) NOT NULL,
	StaffStatus varchar(10) NOT NULL DEFAULT 'ACTIVE'
)

CREATE VIEW vw_Staff_Full 
AS
SELECT si.StaffID AS 'Staff ID',
si.userId AS 'Hotel User ID',
CONCAT (si.StaffLastName, ', ', si.StaffFirstName) AS 'Staff Name',
si.StaffBirthDate AS 'Staff Birthdate',
si.StaffGender AS 'Staff Gender',
si.StaffContactNo AS 'Staff Contact Number',
si.StaffEmailAddress AS 'Staff Email Address',
si.StaffSalary AS 'Staff Salary',
ua.userDateCreated AS 'Staff Account Last Created',
ua.userDateUpdated AS 'Staff Account Last Updated'
FROM StaffInfo si
INNER JOIN UserAccount ua
ON si.userId = ua.userId

CREATE VIEW vw_Staff_Personal
AS
SELECT StaffID AS 'Staff ID',
userId AS 'Hotel User ID',
CONCAT (StaffLastName, ', ', StaffFirstName) AS 'Staff Name',
StaffBirthDate AS 'Staff Birthdate',
StaffGender AS 'Staff Gender',
StaffContactNo AS 'Staff Contact Number',
StaffEmailAddress AS 'Staff Email Address'
FROM StaffInfo

CREATE VIEW vw_Staff_Salary
AS
SELECT StaffID AS 'Staff ID',
CONCAT (StaffLastName, ', ', StaffFirstName) AS 'Staff Name',
StaffContactNo AS 'Staff Contact Number',
StaffEmailAddress AS 'Staff Email Address',
StaffSalary AS 'Staff Salary'
FROM StaffInfo