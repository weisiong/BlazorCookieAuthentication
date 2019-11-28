using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Locationinfo
    {
        public string Locationname { get; set; }
        public string Projectid { get; set; }
        public string Buildname { get; set; }
        public int Floornum { get; set; }
        public string Roomname { get; set; }
        public string Defaultaccessgroup { get; set; }
        public string Status { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
