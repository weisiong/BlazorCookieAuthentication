using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class CardinfoAccessgroup
    {
        public string Projectid { get; set; }
        public long Sid { get; set; }
        public int Accessgroupsid { get; set; }
        public string Cardno { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
