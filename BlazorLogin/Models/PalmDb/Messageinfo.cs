using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Messageinfo
    {
        public int Sid { get; set; }
        public int Parentsid { get; set; }
        public int Messagetype { get; set; }
        public long Membersid { get; set; }
        public string Locationname { get; set; }
        public string Context { get; set; }
        public int Createuser { get; set; }
        public long Createdat { get; set; }
        public int Sendmail { get; set; }
        public string Mail { get; set; }
        public int Showmessage { get; set; }
        public long Validfrom { get; set; }
        public long Validto { get; set; }
        public int Readcount { get; set; }
        public long Lastreaddat { get; set; }
        public int Closeuser { get; set; }
        public long Closedat { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
