using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosReceiptmember
    {
        public long Sid { get; set; }
        public string Guid { get; set; }
        public int Carparkindex { get; set; }
        public int Zoneindex { get; set; }
        public int Cartype { get; set; }
        public string Cardno { get; set; }
        public char Cardtype { get; set; }
        public string Plate { get; set; }
        public string Validstart { get; set; }
        public string Validto { get; set; }
        public string Newvalidto { get; set; }
        public int Addtionmonth { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
    }
}
