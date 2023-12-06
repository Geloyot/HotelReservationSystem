# Hotel Kanno-teki
_A test/sample application that creates, handles, and stores booked reservations in a hotel chain._

## Functionalities
This hotel reservation application/system contains the following functionalities as well as an outline of the flow of transaction between users:
### 💁 Guest
* Dashboard: book a reservation, disabled if there is already pre-existing reservation.
* Create Reservation (1): select a room, check-in and check-out dates with a max of 14 days, and the number of guests.
* Create Reservation (2): fill out the booking guest's details.
* Create Reservation (3): select payment mode and payment details.
### 🧑‍💼 Staff/Employee
* Dashboard: user can choose between windows: guests, rooms, reservations, and transaction/payment history. Live statistics are also present in the UI.
* Guest Window: user can update guest details and remove guests from the hotel database.
* Rooms Window: user can add rooms with room image preview, update room details, and remove rooms from the hotel database.
* Reservations Window: user can view reservation details and check if they arrive in the hotel to check-in, or check-out before leaving.
### 🛠️🔑 Admin
* Dashboard: admin can choose between windows: accounts, rooms, reservations. Live statistics are also present in the UI.
* Accounts Window: admin can manage guest and staff accounts, including insertion, updating, and deletion of accounts. If the account is from a staff/employee, the admin can view the staff's own details as well.
* Rooms Window: admin can view room details and search/filter out specific rooms.
* Reservations Window: admin can view reservations details and search/filter out specific reservations.

## Database
This system includes an SQL Server database that needs to be restored if using this repository in another PC. 
The application utilizes an entity data model (EDMx) to connect to the database, and uses DBContext, SQL Views, and SQL Stored Procedures to provide the application its functionalities that involve the system's database.
The database consists of the following tables:
* User Account
* Roles
* Guest Information
* Staff Information
* Room Information
* Reservation Information
* Payment Information

## Upcoming features
* Payment/Transaction history for Staff
* Guest Information for Admin's Accounts Window
* More data grid view filters
