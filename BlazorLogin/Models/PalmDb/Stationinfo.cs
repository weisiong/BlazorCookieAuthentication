using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Stationinfo
    {
        public string Projectid { get; set; }
        public int Carparkid { get; set; }
        public int Zoneid { get; set; }
        public int Sid { get; set; }
        public string Stationname { get; set; }
        public char Stationtype { get; set; }
        public string Ipaddress { get; set; }
        public int Port { get; set; }
        public string Config { get; set; }
        public string Defaultconfig { get; set; }
        public string Locationname { get; set; }
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
