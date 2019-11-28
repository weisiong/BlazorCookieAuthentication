using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Seasongroup
    {
        public long Sid { get; set; }
        public string Projectid { get; set; }
        public int Parkingtype { get; set; }
        public string Seasongroupname { get; set; }
        public string Seasontype { get; set; }
        public int Membersid { get; set; }
        public int Seasongroupcount { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public int Ctrlcarpark { get; set; }
        public int Carparkid1 { get; set; }
        public int Zoneid1 { get; set; }
        public int Carparkid2 { get; set; }
        public int Zoneid2 { get; set; }
        public int Carparkid3 { get; set; }
        public int Zoneid3 { get; set; }
        public int Carparkid4 { get; set; }
        public int Zoneid4 { get; set; }
        public int Carparkid5 { get; set; }
        public int Zoneid5 { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Remark { get; set; }
        public string Blob { get; set; }
    }
}
