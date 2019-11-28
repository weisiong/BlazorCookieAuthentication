using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Blocklist
    {
        public int Sid { get; set; }
        public int Membersid { get; set; }
        public string Cardno { get; set; }
        public string Remark { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Blob { get; set; }
    }
}
