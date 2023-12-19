using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Appdata;

namespace HotelReservationSystem
{
    public class UserRepository
    {
        private DBSYSEntities DB;
        private HotelRepository HotelRepos;

        public UserRepository() { 
            DB = new DBSYSEntities();
            HotelRepos = new HotelRepository();
        }

        public UserAccount GetUserByUsername(string SpecificUsername)
        {
            // Re-initialize db object because sometimes data in the list is not updated.
            DB = new DBSYSEntities();
            return DB.UserAccount.Where(m => m.userName == SpecificUsername).FirstOrDefault();
        }
        public UserAccount GetUserByUserID(int? UserID) 
        {
            DB = new DBSYSEntities();
            return DB.UserAccount.Where(u => u.userId == UserID).FirstOrDefault();
        }
        public string GetUsernameByUserID(int? ID) 
        {
            DB = new DBSYSEntities();
            UserAccount user = DB.UserAccount.Where(u => u.userId == ID).FirstOrDefault();
            return user.userName;
        }
        public int GetUserAccountCount() 
        {
            DB = new DBSYSEntities();

            var count = DB.UserAccount.Count();
            return count;
        }
        public int GetCurrentMonthUserAccountCount() 
        {
            DB = new DBSYSEntities();
            List<UserAccount> UserList = DB.UserAccount.ToList();
            foreach (UserAccount User in DB.UserAccount.ToList()) 
            {
                if (User.userDateUpdated.Value.Month != DateTime.Now.Month) 
                {
                    UserList.Remove(User);
                }
            }
            return UserList.Count;
        }

        public List<vw_UserAccount_Full> GetUserAccountList()
        {
            DB = new DBSYSEntities();
            return DB.vw_UserAccount_Full.ToList();
        }

        public List<vw_UserAccount_Roles> GetUserAccountRolesList()
        {
            DB = new DBSYSEntities();
            return DB.vw_UserAccount_Roles.ToList();
        }
        public List<vw_UserAccount_Active> GetUserAccountActiveList() 
        {
            DB = new DBSYSEntities(); 
            return DB.vw_UserAccount_Active.ToList();
        }
        public List<vw_UserAccount_Inactive> GetUserAccountInactiveList()
        {
            DB = new DBSYSEntities();
            return DB.vw_UserAccount_Inactive.ToList();
        }

        public StaffInfo GetStaffInfoByUserID(int? userID) 
        {
            DB = new DBSYSEntities();
            return DB.StaffInfo.Where(si => si.userId == userID).FirstOrDefault();
        }

        public List<vw_Staff_Full> GetStaffFullList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Staff_Full.ToList();
        }
        public List<vw_Staff_Personal> GetStaffPIList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Staff_Personal.ToList();
        }
        public List<vw_Staff_Salary> GetStaffSalaryList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Staff_Salary.ToList();
        }

        public int GetGuestLatestID() 
        {
            DB = new DBSYSEntities();
            return DB.GuestInformation.Max(guest => guest.guestID);
        }
        public GuestInformation GetGuestLatestByGuestID()
        {
            DB = new DBSYSEntities();
            int LatestGuestID = DB.GuestInformation.Max(guest => guest.guestID);
            return DB.GuestInformation.FirstOrDefault(guest => guest.guestID == LatestGuestID);
        }
        public GuestInformation GetGuestByGuestID(int? GuestID) 
        {
            DB = new DBSYSEntities();
            return DB.GuestInformation.Where(guest => guest.guestID == GuestID).FirstOrDefault();
        }
        public string GetGuestNameByGuestID(int? ID) 
        {
            DB = new DBSYSEntities();
            GuestInformation guest = DB.GuestInformation.Where(g => g.guestID == ID).FirstOrDefault();
            return guest.guestLastName + ", " + guest.guestFirstName;
        }
        public GuestInformation GetGuestByUserID(int? ID) 
        { 
            DB = new DBSYSEntities();
            return DB.GuestInformation.Where(g => g.userID == ID).FirstOrDefault();
        }
        public int GetCurrentMonthGuestCount() 
        {
            int GuestCurrentCount = 0;
            DB = new DBSYSEntities();

            List<GuestInformation> GuestList = new List<GuestInformation>();

            foreach (GuestInformation Guest in DB.GuestInformation.ToList()) 
            {
                if (Guest.roomID == null)
                {
                    GuestList.Remove(Guest);
                }
                else 
                {
                    GuestCurrentCount += HotelRepos.GetGuestCountByRoomID(Guest.roomID);
                }
            }

            return GuestCurrentCount;
        }

        public List<vw_Guest_Full> GetGuestFullList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Guest_Full.ToList();
        }
        public List<vw_Guest_RoomOccupied> GetGuestLocationList() 
        {
            DB = new DBSYSEntities();
            List<vw_Guest_RoomOccupied> GuestLocations = new List<vw_Guest_RoomOccupied>();
            foreach (vw_Guest_RoomOccupied guest in DB.vw_Guest_RoomOccupied.ToList()) 
            {
                if (guest.Room_ID != null) 
                {
                    GuestLocations.Add(guest);
                }
            }
            return GuestLocations;
        }
        public List<vw_Guest_CheckInOutDates> GetGuestCheckDatesList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Guest_CheckInOutDates.ToList();
        }

    }
}
