USE DBSYS

CREATE PROCEDURE SP_AddPayment_Booking
@uid int, @resid int, @gid int, @type varchar(255), @num varchar(255), @amount decimal(9, 2), @cvv int, @expiry datetime,
@owner varchar(255)
AS
INSERT INTO PaymentInfo(paymentType, cardNumber, paymentAmount, cardSecurityCode, cardExpiryDate, cardOwnerName,
userId, reserveID, guestID)
VALUES(@type, @num, @amount, @cvv, @expiry, @owner, @uid, @resid, @gid)

CREATE PROCEDURE SP_AddGuest_Booking
@fn varchar(255), @ln varchar(255), @gender varchar(255), @bdate datetime, @contact varchar(255), @address varchar(255),
@email varchar(255), @uid int, @rid int
AS
INSERT INTO GuestInformation(guestFirstName, guestLastName, guestGender, guestBirthDate, guestContactNo, guestAddress,
guestEmailAddress, userID, roomID)
VALUES(@fn, @ln, @gender, @bdate, @contact, @address, @email, @uid, @rid)

CREATE PROCEDURE SP_AddReservation_Booking
@checkin datetime, @checkout datetime, @dayscount int, @adults int, @children int, @totalguests int, @uid int, @rid int,
@gid int
AS
INSERT INTO ReservationInfo(reserveCheckInDate, reserveCheckOutDate, reserveStayLength, reserveGuestAdultCount,
reserveGuestChildCount, reserveGuestCount, reserveHasCheckedIn, reserveHasCheckedOut, userId, roomID, guestID)
VALUES(@checkin, @checkout, @dayscount, @adults, @children, @totalguests, 'FALSE', 'FALSE', @uid, @rid, @gid)

CREATE PROCEDURE SP_NewUserAccount_Register
@username varchar(99), @password varchar(99), @status varchar(10), @timecreated datetime, @timeupdated datetime,
@roleid int, @creatorid int, @creatorname varchar(99)
AS
INSERT INTO UserAccount 
VALUES(@username, @password, @status, @timecreated, @timeupdated, @roleid, @creatorid, @creatorname)

CREATE PROCEDURE SP_NewStaff_Register
@fn varchar(255), @ln varchar(255), @gender varchar(255), @bdate datetime, @contact varchar(255), @email varchar(255),
@salary decimal(9, 2), @status varchar(50), @roleid int, @uid int
AS
INSERT INTO StaffInfo
VALUES(@roleid, @uid, @fn, @ln, @bdate, @gender, @contact, @email, @salary, @status)