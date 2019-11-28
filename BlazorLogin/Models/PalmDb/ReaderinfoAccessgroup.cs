using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class ReaderinfoAccessgroup
    {
        public string Projectid { get; set; }
        public int Sid { get; set; }
        public int Accessgroupsid { get; set; }
        public int Readerinfosid { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
