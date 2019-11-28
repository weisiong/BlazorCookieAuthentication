using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Accesstraffic
    {
        public long Sid { get; set; }
        public int Accessgroupsid { get; set; }
        public string Trafficname { get; set; }
        public string Ctrldat { get; set; }
        public string Ctrlweek { get; set; }
        public string Validtm { get; set; }
        public string Validtmfrom { get; set; }
        public string Validtmto { get; set; }
        public int Isholiday { get; set; }
    }
}
