using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Programlog
    {
        public string Projectid { get; set; }
        public int Sid { get; set; }
        public string Devicename { get; set; }
        public string Programtype { get; set; }
        public long Nowtime { get; set; }
        public long Lasttime { get; set; }
        public string Status { get; set; }
    }
}
