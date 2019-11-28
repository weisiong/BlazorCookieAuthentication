using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosReceipt
    {
        public string Guid { get; set; }
        public string Posid { get; set; }
        public string Recepitid { get; set; }
        public int Visitoritem { get; set; }
        public int Memberitem { get; set; }
        public int Productitem { get; set; }
        public string Estackid { get; set; }
        public int Discountmodel { get; set; }
        public double Discountamount { get; set; }
        public double Fee { get; set; }
        public double Vat { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }
        public string Hostname { get; set; }
        public string Machineid { get; set; }
        public string Projectid { get; set; }
        public long Receiptdat { get; set; }
        public string Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Remark { get; set; }
        public string Blob { get; set; }
        public double InitSid { get; set; }
        public double Initmoney { get; set; }
        public double Totalmoney { get; set; }
    }
}
