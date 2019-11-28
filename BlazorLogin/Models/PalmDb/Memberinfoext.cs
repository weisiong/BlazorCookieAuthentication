using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Memberinfoext
    {
        public int Sid { get; set; }
        public int Membersid { get; set; }
        public int Visitorsid { get; set; }
        public int Exttype { get; set; }
        public string Name { get; set; }
        public string Loginid { get; set; }
        public string Pwd { get; set; }
        public int Mailcheck { get; set; }
        public int Phonecheck { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
