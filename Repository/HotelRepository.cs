using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Appdata;

namespace HotelReservationSystem
{
    public class HotelRepository
    {
        private DBSYSEntities DB;

        public HotelRepository() 
        { 
            DB = new DBSYSEntities();
        }

        public RoomInformation GetRoomByRoomID(int? RoomID) 
        {
            DB = new DBSYSEntities();
            return DB.RoomInformation.Where(r => r.roomID == RoomID).FirstOrDefault();
        }
        public RoomInformation GetRoomByRoomTitle(string RoomName) 
        {
            DB = new DBSYSEntities();
            return DB.RoomInformation.Where(r => r.roomTitle == RoomName).FirstOrDefault();
        }
        public string GetRoomTitleByRoomID(int? ID) 
        {
            DB = new DBSYSEntities();
            RoomInformation room = DB.RoomInformation.Where(r => r.roomID == ID).FirstOrDefault();
            return room.roomTitle;
        }
        public int GetGuestCountByRoomID(int? ID)
        {
            DB = new DBSYSEntities();
            RoomInformation room = DB.RoomInformation.Where(r => r.roomID == ID).FirstOrDefault();
            return room.roomGuestCount.Value;
        }

        public List<vw_RoomInfo_Full> GetRoomsFullList()
        {
            DB = new DBSYSEntities();
            return DB.vw_RoomInfo_Full.ToList();
        }
        public List<vw_RoomInfo_Available> GetRoomsAvailableList()
        {
            DB = new DBSYSEntities();
            return DB.vw_RoomInfo_Available.ToList();
        }
        public List<vw_RoomInfo_Occupied> GetRoomsOccupiedList()
        {
            DB = new DBSYSEntities();
            return DB.vw_RoomInfo_Occupied.ToList();
        }
        public List<vw_RoomInfo_Types> GetRoomsTypesList()
        {
            DB = new DBSYSEntities();
            return DB.vw_RoomInfo_Types.ToList();
        }
        public List<vw_RoomInfo_Prices> GetRoomsPricesList()
        {
            DB = new DBSYSEntities();
            return DB.vw_RoomInfo_Prices.ToList();
        }

        public PaymentInfo GetPaymentInfoByReservationID(int? id) 
        {
            DB = new DBSYSEntities();
            return DB.PaymentInfo.Where(res => res.reserveID == id).FirstOrDefault();
        }

        public List<vw_Payment_Full> GetPaymentFullList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_Full.ToList();
        }
        public List<vw_Payment_GuestInfo> GetPaymentGuestsList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_GuestInfo.ToList();
        }
        public List<vw_Payment_UserInfo> GetPaymentUsersList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_UserInfo.ToList();
        }
        public List<vw_Payment_CardInfo> GetPaymentCardList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_CardInfo.ToList();
        }
        public List<vw_Payment_ReservationInfo> GetPaymentReservationList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_ReservationInfo.ToList();
        }
        public List<vw_Payment_Amount> GetPaymentAmountsList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Payment_Amount.ToList();
        }

        public int GetReservationLatestID() 
        {
            DB = new DBSYSEntities();
            return DB.ReservationInfo.Max(res => res.reserveID);
        }
        public ReservationInfo GetReservationByID(int? ID) 
        {
            DB = new DBSYSEntities();
            return DB.ReservationInfo.Where(res => res.reserveID == ID).FirstOrDefault();
        }
        public ReservationInfo GetReservationByGuestID(int? ID) 
        {
            DB = new DBSYSEntities();
            return DB.ReservationInfo.Where(res => res.guestID == ID).FirstOrDefault();
        }

        public List<vw_Reservation_Full> GetReservationFullList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_Full.ToList();
        }
        public List<vw_Reservation_GuestInfo> GetReservationGuestList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_GuestInfo.ToList();
        }
        public List<vw_Reservation_UserInfo> GetReservationUsersList()
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_UserInfo.ToList();
        }
        public List<vw_Reservation_RoomInfo> GetReservationRoomsList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_RoomInfo.ToList();
        }
        public List<vw_Reservation_GuestCount> GetReservationGuestCountList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_GuestCount.ToList();
        }
        public List<vw_Reservation_CheckedIn> GetReservationCheckInList()
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_CheckedIn.ToList();
        }
        public List<vw_Reservation_CheckedOut> GetReservationCheckOutList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_CheckedOut.ToList();
        }
        public List<vw_Reservation_CheckStatus> GetReservationChecksList() 
        {
            DB = new DBSYSEntities();
            return DB.vw_Reservation_CheckStatus.ToList();
        }

    }
}
