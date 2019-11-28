using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Cardparkinginfo
    {
        public long Sid { get; set; }
        public string Projectid { get; set; }
        public int Carparkid { get; set; }
        public int Zoneid { get; set; }
        public string Cardno { get; set; }
        public string Plate { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Remark { get; set; }
        public string Blob { get; set; }
        public int? Parkingtype { get; set; }
        public string Seasontype { get; set; }
        public string Seasongroupname { get; set; }
    }
}
