using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Cardinfo
    {
        public int Sid { get; set; }
        public string Projectid { get; set; }
        public int Isotype { get; set; }
        public string Carduid { get; set; }
        public string Cardno { get; set; }
        public char Cardtype { get; set; }
        public int Membersid { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public string Groupaccess { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Remark { get; set; }
        public string Blob { get; set; }
    }
}
