//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservationSystem.Appdata
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Payment_Full
    {
        public int Payment_No_ { get; set; }
        public string Payment_Mode { get; set; }
        public decimal Payment_Amount { get; set; }
        public string Credit_Card_No_ { get; set; }
        public System.DateTime Credit_Card_Expiration_Date { get; set; }
        public int Credit_Card_Security_Code { get; set; }
        public string Credit_Card_Name { get; set; }
        public Nullable<int> Payer_Username { get; set; }
        public Nullable<int> Payer_Guest_ID { get; set; }
        public Nullable<int> Referred_Reservation_ID { get; set; }
    }
}
