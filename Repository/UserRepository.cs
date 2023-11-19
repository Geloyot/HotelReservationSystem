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
        private DBSYSEntities Database;

        public UserRepository() { 
            Database = new DBSYSEntities();
        }

        public UserAccount GetUserByUsername(string SpecificUsername)
        {
            // Re-initialize db object because sometimes data in the list is not updated.
            Database = new DBSYSEntities();
            return Database.UserAccount.Where(m => m.userName == SpecificUsername).FirstOrDefault();
        }

        public UserAccount GetUserByUserID(int? UserID) 
        {
            Database = new DBSYSEntities();
            return Database.UserAccount.Where(u => u.userId == UserID).FirstOrDefault();
        }

        public List<vw_UserAccount_Full> GetUserAccountList()
        {
            Database = new DBSYSEntities();
            return Database.vw_UserAccount_Full.ToList();
        }

        public List<vw_UserAccount_Roles> GetUserAccountRolesList()
        {
            Database = new DBSYSEntities();
            return Database.vw_UserAccount_Roles.ToList();
        }
        public List<vw_UserAccount_Active> GetUserAccountActiveList() 
        {
            Database = new DBSYSEntities(); 
            return Database.vw_UserAccount_Active.ToList();
        }
        public List<vw_UserAccount_Inactive> GetUserAccountInactiveList()
        {
            Database = new DBSYSEntities();
            return Database.vw_UserAccount_Inactive.ToList();
        }
    }
}
