using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Readerinfo
    {
        public string Projectid { get; set; }
        public int Sid { get; set; }
        public string Readername { get; set; }
        public char Readertype { get; set; }
        public string Ipaddress { get; set; }
        public string Parentname { get; set; }
        public int Readerid { get; set; }
        public int Dooraccessport { get; set; }
        public int Transferport { get; set; }
        public string Config { get; set; }
        public string Defaultconfig { get; set; }
        public string Locationname { get; set; }
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
