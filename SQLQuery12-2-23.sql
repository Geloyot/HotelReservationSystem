USE DBSYS

-- SQL VIEWS

CREATE VIEW vw_Guest_Full
AS
SELECT guestID AS "Guest ID", 
CONCAT(guestLastName, ', ', guestFirstName) AS "Guest Name",
guestGender AS "Guest Gender",
guestBirthDate AS "Guest Birthdate",
guestContactNo AS "Contact Number",
guestAddress AS "Address",
guestEmailAddress AS "Email Address",
guestLastCheckInDate AS "Last Checked In",
guestLastCheckOutDate AS "Last Checked Out",
userID AS "User Account ID"
FROM GuestInformation

CREATE VIEW vw_Guest_CheckInOutDates
AS
SELECT guestID AS "Guest ID", 
CONCAT(guestLastName, ', ', guestFirstName) AS "Guest Name",
guestLastCheckInDate AS "Last Checked In",
guestLastCheckOutDate AS "Last Checked Out"
FROM GuestInformation

CREATE VIEW vw_Guest_RoomOccupied
AS
SELECT g.guestID AS "Guest ID", 
CONCAT(g.guestLastName, ', ', g.guestFirstName) AS "Guest Name",
g.roomID AS "Room ID",
r.roomTitle AS "Room Name"
FROM GuestInformation g
INNER JOIN RoomInformation r
ON g.roomID = r.roomID

CREATE VIEW vw_Reservation_CheckedIn
AS
SELECT res.reserveID AS 'Reservation No.',
res.reserveCheckInDate AS 'Check-In', 
res.reserveCheckOutDate AS 'Check-Out', 
res.reserveStayLength AS 'Nights to Stay',
res.reserveGuestAdultCount AS 'No. of Adult Guests', 
res.reserveGuestChildCount AS 'No. of Children Guests', 
res.reserveGuestCount AS 'No. of Guests'
FROM ReservationInfo res
WHERE res.reserveHasCheckedIn IS NOT NULL

CREATE VIEW vw_Reservation_CheckedOut
AS
SELECT res.reserveID AS 'Reservation No.',
res.reserveCheckInDate AS 'Check-In', 
res.reserveCheckOutDate AS 'Check-Out', 
res.reserveStayLength AS 'Nights to Stay',
res.reserveGuestAdultCount AS 'No. of Adult Guests', 
res.reserveGuestChildCount AS 'No. of Children Guests', 
res.reserveGuestCount AS 'No. of Guests'
FROM ReservationInfo res
WHERE res.reserveHasCheckedIn IS NOT NULL AND res.reserveHasCheckedOut IS NOT NULL

CREATE VIEW vw_Reservation_CheckStatus
AS
SELECT reserveID AS "Reservation No.",
reserveCheckInDate AS "Check-In", 
reserveCheckOutDate AS "Check-Out", 
reserveHasCheckedIn AS "Has Checked In?", 
reserveHasCheckedOut AS "Has Checked Out?"
FROM ReservationInfo
WHERE reserveHasCheckedIn IS NOT NULL AND reserveHasCheckedOut IS NOT NULL

-- SQL STORED PROCEDURES

CREATE PROCEDURE SP_SearchReservation_Username
@UName varchar(255)
AS
SELECT reserveID AS 'Reservation No.',
ua.userName AS 'Booker Username',
res.reserveCheckInDate AS 'Check-In', 
res.reserveCheckOutDate AS 'Check-Out', 
res.reserveStayLength AS 'Nights to Stay',
res.reserveGuestAdultCount AS 'No. of Adult Guests', 
res.reserveGuestChildCount AS 'No. of Children Guests', 
res.reserveGuestCount AS 'No. of Guests',
res.userId AS 'Booker ID',
res.guestID AS 'Guest ID No.', 
res.roomID AS 'Room ID'
FROM ReservationInfo res
INNER JOIN UserAccount ua
ON res.userId = ua.userId
WHERE ua.userName = @UName

CREATE PROCEDURE SP_SearchReservation_RoomOccupied
@RoomTitle varchar (255)
AS
SELECT reserveID AS 'Reservation No.',
r.roomTitle AS 'Room Name',
res.reserveCheckInDate AS 'Check-In', 
res.reserveCheckOutDate AS 'Check-Out', 
res.reserveStayLength AS 'Nights to Stay',
res.reserveGuestAdultCount AS 'No. of Adult Guests', 
res.reserveGuestChildCount AS 'No. of Children Guests', 
res.reserveGuestCount AS 'No. of Guests',
res.userId AS 'Booker ID',
res.guestID AS 'Guest ID No.', 
res.roomID AS 'Room ID'
FROM ReservationInfo res
INNER JOIN RoomInformation r
ON res.roomID = r.roomID
WHERE r.roomTitle = @RoomTitle

CREATE PROCEDURE SP_SearchReservation_GuestLastName
@GuestSurname varchar (255)
AS
SELECT reserveID AS 'Reservation No.',
CONCAT(g.guestLastName, ', ', g.guestFirstName) AS 'Booker Full Name',
res.reserveCheckInDate AS 'Check-In', 
res.reserveCheckOutDate AS 'Check-Out', 
res.reserveStayLength AS 'Nights to Stay',
res.reserveGuestAdultCount AS 'No. of Adult Guests', 
res.reserveGuestChildCount AS 'No. of Children Guests', 
res.reserveGuestCount AS 'No. of Guests',
res.userId AS 'Booker ID',
res.guestID AS 'Guest ID No.', 
res.roomID AS 'Room ID'
FROM ReservationInfo res
INNER JOIN GuestInformation g
ON res.guestID = g.guestID
WHERE g.guestLastName = @GuestSurname

CREATE PROCEDURE SP_SearchRoom_RoomTitle
@RoomTitle varchar(255)
AS
SELECT *
FROM vw_RoomInfo_Full room
WHERE room.[Room Name] = @RoomTitle

CREATE PROCEDURE SP_UpdateGuest
@GuestID int, @FName varchar(255), @LName varchar(255), @Gender varchar(99), @BDate datetime, @Contact varchar(99), @Address varchar(99), @Email varchar(99)
AS
UPDATE GuestInformation
SET guestFirstName = @FName, 
guestLastName = @LName, 
guestGender = @Gender, 
guestBirthDate = @BDate, 
guestContactNo = @Contact,
guestAddress = @Address,
guestEmailAddress = @Email
WHERE guestID = @GuestID

CREATE PROCEDURE SP_DeleteGuest
@GuestID int
AS
DELETE GuestInformation
WHERE guestID = @GuestID

CREATE PROCEDURE SP_SearchGuest_Name
@GName varchar(255)
AS
SELECT *
FROM GuestInformation
WHERE guestFirstName LIKE '%' + @GName + '%' OR guestLastName LIKE '%' + @GName + '%'

CREATE PROCEDURE SP_AddRoom
@Title varchar(99), @Type varchar(99), @Price decimal(9, 2), @Desc varchar(255), @Img varchar(255) 
AS
INSERT INTO RoomInformation(roomTitle, roomType, roomPrice, roomDesc, roomImage, roomGuestCount) 
VALUES(@Title, @Type, @Price, @Desc, @Img, DEFAULT)

CREATE PROCEDURE SP_UpdateRoom
@ID int, @Title varchar(99), @Type varchar(99), @Price decimal(9, 2), @Desc varchar(255), @Img varchar(255)
AS
UPDATE RoomInformation
SET roomTitle = @Title, roomType = @Type, roomPrice = @Price, roomDesc = @Desc, roomImage = @Img
WHERE roomID = @ID

CREATE PROCEDURE SP_UpdateRoom_NoImage
@ID int, @Title varchar(99), @Type varchar(99), @Price decimal(9, 2), @Desc varchar(255)
AS
UPDATE RoomInformation
SET roomTitle = @Title, roomType = @Type, roomPrice = @Price, roomDesc = @Desc
WHERE roomID = @ID

CREATE PROCEDURE SP_UpdateRoom_GuestCount
@ID int, @Count int
AS
UPDATE RoomInformation
SET roomGuestCount = @Count
WHERE roomID = @ID

CREATE PROCEDURE SP_UpdateRoom_GuestID
@RID int, @GID int
AS
UPDATE RoomInformation
SET guestID = @GID
WHERE roomID = @RID

CREATE PROCEDURE SP_DeleteRoom
@ID int
AS
DELETE RoomInformation
WHERE roomID = @ID

CREATE PROCEDURE SP_UpdateReservation_CheckInGuest
@ResID int, @CheckInDate datetime
AS
UPDATE ReservationInfo
SET reserveHasCheckedIn = 'FALSE', reserveGuestCheckInDate = @CheckInDate
WHERE reserveID = @ResID

CREATE PROCEDURE SP_UpdateGuest_CheckInDate
@GID int, @CheckInDate datetime
AS
UPDATE GuestInformation
SET guestLastCheckInDate = @CheckInDate
WHERE guestID = @GID

CREATE PROCEDURE SP_UpdateReservation_CheckOutGuest
@ResID int, @CheckOutDate datetime
AS
UPDATE ReservationInfo
SET reserveHasCheckedOut = 'FALSE', reserveGuestCheckOutDate = @CheckOutDate
WHERE reserveID = @ResID

CREATE PROCEDURE SP_UpdateGuest_CheckOutDate
@GID int, @CheckOutDate datetime
AS
UPDATE GuestInformation
SET guestLastCheckOutDate = @CheckOutDate
WHERE guestID = @GID

CREATE PROCEDURE SP_UpdateRoom_EmptyRoom
@RID int
AS
UPDATE RoomInformation
SET roomGuestCount = 0, guestID = null
WHERE roomID = @RID

-- CUSTOM QUERIES

DBCC CHECKIDENT(UserAccount, RESEED, 0)
DBCC CHECKIDENT(StaffInfo, RESEED, 1000)
DBCC CHECKIDENT(ReservationInfo, RESEED, 10000)
DBCC CHECKIDENT(RoomInformation, RESEED, 100) -- RESET Auto-Number/Identity of Table Primary Key