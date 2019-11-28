using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Memberaccessgroup
    {
        public long Sid { get; set; }
        public long Membersid { get; set; }
        public string Readerlist { get; set; }
        public long Validfrom { get; set; }
        public long Validto { get; set; }
        public int Closeuser { get; set; }
        public long Closedat { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
