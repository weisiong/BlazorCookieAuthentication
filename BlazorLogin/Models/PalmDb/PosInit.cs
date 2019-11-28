using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosInit
    {
        public long Sid { get; set; }
        public double Initmoney { get; set; }
        public double Totalmoney { get; set; }
        public string Createuser { get; set; }
        public string Enduser { get; set; }
        public long Createdat { get; set; }
        public long Enddat { get; set; }
        public string Status { get; set; }
        public string Posid { get; set; }
        public string Hostname { get; set; }
        public string Machineid { get; set; }
        public string Projectid { get; set; }
    }
}
