using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Accessgroup
    {
        public string Projectid { get; set; }
        public int Sid { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public string Doorlist { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public string Updatedat { get; set; }
    }
}
