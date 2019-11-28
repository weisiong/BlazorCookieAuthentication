using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Biometrics
    {
        public long Sid { get; set; }
        public string Guid { get; set; }
        public long Membersid { get; set; }
        public long Visitorsid { get; set; }
        public long Userid { get; set; }
        public int Seq { get; set; }
        public char Btype { get; set; }
        public char Security { get; set; }
        public string Bioname { get; set; }
        public string Biodata { get; set; }
        public int Creatuser { get; set; }
        public long Creatdat { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
