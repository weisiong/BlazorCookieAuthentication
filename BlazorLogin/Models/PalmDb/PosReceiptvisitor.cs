using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosReceiptvisitor
    {
        public long Sid { get; set; }
        public string Guid { get; set; }
        public int Zoneindex { get; set; }
        public string Cardno { get; set; }
        public int Cartype { get; set; }
        public string Checkinplate { get; set; }
        public string Checkoutplate { get; set; }
        public string Entrytime { get; set; }
        public string Exittime { get; set; }
        public int Parkingtime { get; set; }
        public string Parkingtimestr { get; set; }
        public string Estackid { get; set; }
        public double Fee { get; set; }
        public int Discountmodel { get; set; }
        public double Discountamount { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
