using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Programlist
    {
        public int Sid { get; set; }
        public string Programtype { get; set; }
        public string Programname { get; set; }
        public string Showname { get; set; }
        public string Groupname { get; set; }
        public int Groupseq { get; set; }
        public string Version { get; set; }
        public string Sharedata { get; set; }
        public string Remark { get; set; }
        public string Imageformat { get; set; }
        public long Programdat { get; set; }
        public int Updateitem { get; set; }
        public string Updateuser { get; set; }
        public long Updatedat { get; set; }
        public string Blob { get; set; }
        public int? Programseq { get; set; }
    }
}
