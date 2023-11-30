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

        public UserRepository() { 
            DB = new DBSYSEntities();
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

        public int GetUserAccountCount() 
        {
            DB = new DBSYSEntities();

            var count = DB.UserAccount.Count();
            return count;
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

        public GuestInformation GetGuestByGuestID(int? GuestID) 
        {
            DB = new DBSYSEntities();
            return DB.GuestInformation.Where(guest => guest.guestID == GuestID).FirstOrDefault();
        }

        public List<vw_Guest_Full> GetGuestFullList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Guest_Full.ToList();
        }
        public List<vw_Guest_RoomOccupied> GetGuestLocationList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Guest_RoomOccupied.ToList();
        }
        public List<vw_Guest_CheckInOutDates> GetGuestCheckDatesList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Guest_CheckInOutDates.ToList();
        }

    }
}
