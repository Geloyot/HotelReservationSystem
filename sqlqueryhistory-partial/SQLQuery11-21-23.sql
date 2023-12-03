USE DBSYS

--==================================================================
-- SQL Table, Views, and Stored Procedures for Reservations/Bookings
--==================================================================

CREATE TABLE ReservationInfo (
	reserveID int IDENTITY(10001, 1) PRIMARY KEY,
	reserveCheckInDate datetime NOT NULL,
	reserveCheckOutDate datetime NOT NULL,
	reserveStayLength int NOT NULL,
	reserveGuestCount int NOT NULL,
	reserveGuestAdultCount int NOT NULL,
	reserveGuestChildCount int NOT NULL,
	userId int REFERENCES UserAccount(userId),
	guestID int REFERENCES GuestInformation(guestID),
	roomID int REFERENCES RoomInformation(roomID)
)

CREATE VIEW vw_Reservation_Full
AS
SELECT reserveID AS "Reservation No.", 
reserveCheckInDate AS "Check-In", 
reserveCheckOutDate AS "Check-Out", 
reserveHasCheckedIn AS "Has Checked In?", 
reserveHasCheckedOut AS "Has Checked Out?",
reserveStayLength AS "Nights to Stay",
reserveGuestAdultCount AS "No. of Adult Guests", 
reserveGuestChildCount AS "No. of Children Guests", 
reserveGuestCount AS "No. of Guests",
userId AS "Booker ID", 
guestID AS "Guest ID No.", 
roomID AS "Room ID"
FROM ReservationInfo 

CREATE VIEW vw_Reservation_Rooms
AS
SELECT reserveID AS 'Reservation No.', reserveCheckInDate AS 'Check-In', reserveCheckOutDate AS 'Check-Out', reserveGuestCount AS 'No. of Guests', 
roomID AS 'Room ID'
FROM ReservationInfo 

CREATE VIEW vw_Reservation_GuestCount
AS
SELECT reserveID AS 'Reservation No.', reserveCheckInDate AS 'Check-In', reserveCheckOutDate AS 'Check-Out', 
reserveGuestAdultCount AS 'No. of Adult Guests', reserveGuestChildCount AS 'No. of Children Guests', reserveGuestCount AS 'No. of Guests', 
guestID AS 'Guest ID No.'
FROM ReservationInfo

CREATE VIEW vw_Reservation_GuestInfo
AS
SELECT r.reserveID AS 'Reservation No.', r.reserveCheckInDate AS 'Check-In', r.reserveCheckOutDate AS 'Check-Out', 
r.reserveGuestCount AS 'No. of Guests', r.guestID AS 'Guest ID No.', g.guestFirstName AS 'First Name', g.guestLastName AS 'Last Name',
g.guestGender AS 'Gender', g.guestContactNo AS 'Contact No.', g.guestEmailAddress AS 'Email Address', g.guestLastCheckInDate AS 'Last Checked-In',
g.guestLastCheckOutDate AS 'Last Checked-Out'
FROM ReservationInfo r
INNER JOIN GuestInformation g
ON r.guestID = g.guestID

CREATE VIEW vw_Reservation_RoomInfo
AS
SELECT res.reserveID AS 'Reservation No.', res.reserveCheckInDate AS 'Check-In', res.reserveCheckOutDate AS 'Check-Out', 
res.roomID AS 'Room ID', rm.roomTitle AS 'Room Title', rm.roomType AS 'Room Type', rm.roomPrice AS 'Price', rm.roomDesc AS 'Short Description'
FROM ReservationInfo res
INNER JOIN RoomInformation rm
ON res.roomID = rm.roomID

CREATE VIEW vw_Reservation_UserInfo
AS
SELECT r.reserveID AS 'Reservation No.', r.reserveCheckInDate AS 'Check-In', r.reserveCheckOutDate AS 'Check-Out', 
r.reserveGuestCount AS 'No. of Guests', r.userId AS 'User ID', ua.userName AS 'Username', ua.userDateUpdated AS 'Last Updated'
FROM ReservationInfo r
INNER JOIN UserAccount ua
ON r.userId = ua.userId

CREATE PROCEDURE SP_AddReservation
@CheckInDate datetime, @CheckOutDate datetime, @StayCount int, @GuestCount int, @AdultGuestCount int, @ChildGuestCount int, @UID int, @GID int, @RID int
AS
INSERT INTO ReservationInfo VALUES(@CheckInDate, @CheckOutDate, @StayCount, @GuestCount, @AdultGuestCount, @ChildGuestCount, @UID, @GID, @RID)

--==================================================================
-- SQL Table, Views, and Stored Procedures for Payments
--==================================================================

CREATE TABLE PaymentInfo (
	paymentID int IDENTITY(100000, 1) PRIMARY KEY,
	paymentType varchar(99) NOT NULL,
	paymentAmount decimal(9, 2) NOT NULL,
	cardNumber varchar(50) NOT NULL,
	cardExpiryDate datetime NOT NULL,
	cardSecurityCode int NOT NULL,
	cardOwnerName varchar(255) NOT NULL,
	userId int REFERENCES UserAccount(userId),
	guestID int REFERENCES GuestInformation(guestID),
	reserveID int REFERENCES ReservationInfo(reserveID)
)

CREATE VIEW vw_Payment_Full
AS
SELECT paymentID AS 'Payment No.', paymentType AS 'Payment Mode', paymentAmount AS 'Payment Amount', cardNumber AS 'Credit Card No.',
cardExpiryDate AS 'Credit Card Expiration Date', cardSecurityCode AS 'Credit Card Security Code', cardOwnerName AS 'Credit Card Name',
userId AS 'Payer Username', guestID AS 'Payer Guest ID', reserveID AS 'Referred Reservation ID'
FROM PaymentInfo

CREATE VIEW vw_Payment_Amount
AS
SELECT paymentID AS 'Payment No.', paymentType AS 'Payment Mode', paymentAmount AS 'Payment Amount', cardNumber AS 'Credit Card No.', 
cardOwnerName AS 'Credit Card Name'
FROM PaymentInfo

CREATE VIEW vw_Payment_CardInfo
AS
SELECT paymentID AS 'Payment No.', paymentType AS 'Payment Mode', paymentAmount AS 'Payment Amount', cardNumber AS 'Credit Card No.',
cardExpiryDate AS 'Credit Card Expiration Date', cardSecurityCode AS 'Credit Card Security Code', cardOwnerName AS 'Credit Card Name'
FROM PaymentInfo

CREATE VIEW vw_Payment_ReservationInfo
AS
SELECT p.paymentID AS 'Payment No.', p.paymentType AS 'Payment Mode', p.paymentAmount AS 'Payment Amount', p.reserveID AS 'Referred Reservation ID',
r.reserveCheckInDate AS 'Check-In Date', r.reserveCheckOutDate AS 'Check-Out Date', r.reserveGuestCount AS 'No. of Guests'
FROM PaymentInfo p
INNER JOIN ReservationInfo r
ON p.reserveID = r.reserveID

CREATE VIEW vw_Payment_UserInfo
AS
SELECT p.paymentID AS 'Payment No.', p.paymentType AS 'Payment Mode', p.paymentAmount AS 'Payment Amount', p.userId AS 'Payer User ID',
ua.userName AS 'Payer Username'
FROM PaymentInfo p
INNER JOIN UserAccount ua
ON p.userId = ua.userId

CREATE VIEW vw_Payment_GuestInfo
AS
SELECT p.paymentID AS 'Payment No.', p.paymentType AS 'Payment Mode', p.paymentAmount AS 'Payment Amount', p.guestID AS 'Payer Guest ID',
g.guestFirstName AS 'Guest First Name', g.guestLastName AS 'Guest Last Name', g.guestGender AS 'Gender', g.guestContactNo AS 'Contact No.',
g.guestEmailAddress AS 'Email Address'
FROM PaymentInfo p
INNER JOIN GuestInformation g
ON p.guestID = g.guestID

--==================================================================
-- OTHERS
--==================================================================

CREATE PROCEDURE SP_SearchUA_Username
@UName varchar(255)
AS
SELECT * FROM UserAccount WHERE userName LIKE @UName