USE DBSYS

CREATE TABLE GuestInformation (
	guestID int IDENTITY(1, 1) PRIMARY KEY,
	guestFirstName varchar(255) NOT NULL,
	guestLastName varchar(255) NOT NULL,
	guestBirthDate smalldatetime,
	guestGender varchar(99) NOT NULL DEFAULT 'Prefer not to say',
	guestContactNo varchar(99) NOT NULL,
	guestAddress varchar(255) NOT NULL DEFAULT 'UNKNOWN',
	guestEmailAddress varchar(99) NOT NULL,
	guestLastCheckInDate smalldatetime NOT NULL,
	guestLastCheckOutDate smalldatetime NOT NULL,
	userID int REFERENCES UserAccount (userID),
	roomID int REFERENCES RoomInformation (roomID)
)

CREATE TABLE RoomInformation (
	roomID int IDENTITY(1, 1) PRIMARY KEY,
	roomTitle varchar(255) NOT NULL,
	roomType varchar(255) NOT NULL,
	roomPrice decimal(9, 2) NOT NULL DEFAULT,
	roomImage varchar(255) DEFAULT 'N/A',
	roomDesc varchar(255) DEFAULT 'None',
	roomGuestCount int NOT NULL DEFAULT 0,
	userID int REFERENCES UserAccount (userID) DEFAULT 0
)

-- ==================================
-- SQL VIEWS
-- ==================================

CREATE VIEW vw_UserAccount_Full AS
SELECT ua.userId AS 'User ID#', ua.userName AS 'Username', ua.userPassword as 'Password', ua.userStatus AS 'Status', 
ua.userDateCreated AS 'Date Created', ua.userDateUpdated AS 'Date Updated', r.roleName AS 'Role', ua.createdByUser AS 'Creator'
FROM UserAccount ua 
LEFT JOIN [Role] r 
ON ua.roleId = r.roleId

CREATE VIEW vw_UserAccount_Roles AS
SELECT ua.userId AS 'User ID#', ua.userName AS 'Username', r.roleName AS 'Role' 
FROM UserAccount ua
LEFT JOIN [Role] r
ON ua.roleId = r.roleId

CREATE VIEW vw_UserAccount_Active AS
SELECT ua.userId AS 'User ID#', ua.userName AS 'Username', ua.userStatus AS 'Status'
FROM UserAccount ua
LEFT JOIN [Role] r
ON ua.roleId = r.roleId
WHERE ua.userStatus = 'ACTIVE'

CREATE VIEW vw_UserAccount_Inactive AS
SELECT ua.userId AS 'User ID#', ua.userName AS 'Username', ua.userStatus AS 'Status'
FROM UserAccount ua
LEFT JOIN [Role] r
ON ua.roleId = r.roleId
WHERE ua.userStatus = 'INACTIVE'

CREATE VIEW vw_UserAccount_Updates AS
SELECT ua.userId AS 'User ID#', ua.userName AS 'Username', ua.userDateCreated AS 'Date Created', ua.userDateUpdated AS 'Date Updated', 
ua.createdByUser AS 'Creator'
FROM UserAccount ua 
LEFT JOIN [Role] r 
ON ua.roleId = r.roleId

CREATE VIEW vw_RoomInfo_Full AS
SELECT roomID AS 'Room ID', roomTitle AS 'Room Name', roomType AS 'Room Type', roomPrice AS 'Room Price',
roomImage AS 'Room Image File Name', roomDesc AS 'Room Description', roomGuestCount AS 'Room Occupants', ISNULL(guestID, 0) AS 'Hotel Occupant ID'
FROM RoomInformation

CREATE VIEW vw_RoomInfo_Types AS
SELECT roomID AS 'Room ID', roomTitle AS 'Room Name', roomType AS 'Room Type', roomDesc AS 'Room Description'
FROM RoomInformation

CREATE VIEW vw_RoomInfo_Prices AS
SELECT roomID AS 'Room ID', roomTitle AS 'Room Name', roomType AS 'Room Type', roomPrice AS 'Room Price', roomDesc AS 'Room Description'
FROM RoomInformation

CREATE VIEW vw_RoomInfo_Occupied AS
SELECT r.roomID AS 'Room ID', r.roomTitle AS 'Room Name', r.roomType AS 'Room Type', ISNULL(g.guestID, 0) AS 'Hotel Occupant ID', 
r.roomGuestCount AS 'Room Occupants', ISNULL(g.guestLastName, 'N/A') AS 'Occupant Surname'
FROM RoomInformation r
LEFT JOIN GuestInformation g
ON r.guestID = g.guestID
WHERE r.roomGuestCount > 0

CREATE VIEW vw_RoomInfo_Available AS
SELECT r.roomID AS 'Room ID', r.roomTitle AS 'Room Name', r.roomType AS 'Room Type', ISNULL(g.guestID, 0) AS 'Hotel Occupant ID', 
r.roomGuestCount AS 'Room Occupants', ISNULL(g.guestLastName, 'N/A') AS 'Occupant Surname'
FROM RoomInformation r
LEFT JOIN GuestInformation g
ON r.guestID = g.guestID
WHERE r.roomGuestCount = 0

-- ==================================
-- SQL STORED PROCEDURES
-- ==================================

CREATE PROCEDURE SP_NewUserAccount
@UName varchar(255), @UPassword varchar(255), @CreateDate datetime, @UpdateDate datetime, @RoleID int, @CreatedByID int, @CreatorName varchar(255)
AS
INSERT INTO UserAccount(userName, userPassword, userDateCreated, userDateUpdated, roleId, createdById, createdByUser)
VALUES (@UName, @UPassword, @CreateDate, @UpdateDate, @RoleID, @CreatedByID, @CreatorName)

CREATE PROCEDURE SP_UpdateUserAccount
@SpecificID int, @UName varchar(255), @UPassword varchar(255), @UStatus varchar(10), @ULastUpdated datetime
AS
UPDATE UserAccount
SET userName = @UName, userPassword = @UPassword, userStatus = @UStatus, userDateUpdated = @ULastUpdated
WHERE userId = @SpecificID

CREATE PROCEDURE SP_DeleteUserAccount
@SpecificID int
AS
DELETE UserAccount WHERE userId = @SpecificID

CREATE PROCEDURE SP_UpdateUserAccountStatus
@UName varchar(255), @UStatus varchar(10)
AS
UPDATE UserAccount SET userStatus = @UStatus WHERE userName = @UName

-- ==================================
-- COMMANDS FOR DEBUGGING
-- ==================================

SELECT * FROM UserAccount
SELECT * FROM vw_UserAccount_Full
SELECT * FROM vw_UserAccount_Roles
SELECT * FROM vw_UserAccount_Updates
SELECT * FROM vw_UserAccount_Active
SELECT * FROM vw_UserAccount_Inactive

SELECT * FROM RoomInformation
SELECT * FROM vw_RoomInfo_Full
SELECT * FROM vw_RoomInfo_Types
SELECT * FROM vw_RoomInfo_Prices
SELECT * FROM vw_RoomInfo_Available
SELECT * FROM vw_RoomInfo_Occupied

ALTER TABLE RoomInformation
ADD CONSTRAINT DF_roomImage
DEFAULT 'N/A' FOR roomImage

ALTER TABLE RoomInformation
ADD CONSTRAINT DF_roomDesc
DEFAULT 'None' FOR roomDesc

ALTER TABLE RoomInformation
ADD CONSTRAINT DF_RoomUserID
DEFAULT 0 FOR userID

ALTER TABLE RoomInformation
DROP CONSTRAINT DF_RoomUserID

ALTER TABLE RoomInformation
DROP CONSTRAINT DF_roomPrice

ALTER TABLE RoomInformation
ADD CONSTRAINT DF_roomPrice
DEFAULT 'Not yet specified' FOR roomPrice

DBCC CHECKIDENT(RoomInformation, RESEED, 0) -- RESET Auto-Number/Identity of Table Primary Key 

DELETE FROM RoomInformation
DELETE FROM RoomInformation WHERE roomGuestCount IS NOT NULL

INSERT INTO RoomInformation VALUES('1A-F1-Twins-Singles', 'Twins-Singles', '1499.00', DEFAULT, 'Two single-person beds, Room #1A, First Floor', DEFAULT, NULL)
INSERT INTO RoomInformation VALUES('1B-F1-Twins-Singles', 'Twins-Singles', '1499.00', DEFAULT, 'Two single-person beds, Room #1B, First Floor', DEFAULT, NULL)
INSERT INTO RoomInformation VALUES('1C-F1-Twins-Singles', 'Twins-Singles', '1499.00', DEFAULT, 'Two single-person beds, Room #1C, First Floor', 3, 10)
INSERT INTO RoomInformation VALUES('1D-F1-Twins-Doubles', 'Twins-Doubles', '2249.00', DEFAULT, 'Two double-person beds, Room #1D, First Floor', 2, 12)
INSERT INTO RoomInformation VALUES('1E-F1-Twins-Doubles', 'Twins-Doubles', DEFAULT, DEFAULT, DEFAULT, DEFAULT, NULL)
