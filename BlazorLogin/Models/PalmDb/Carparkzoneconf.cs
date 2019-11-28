using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Carparkzoneconf
    {
        public string Projectid { get; set; }
        public int Carparkid { get; set; }
        public int Sid { get; set; }
        public string Zonename { get; set; }
        public string Alternativename { get; set; }
        public int Totalzonenumber { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
        public int? Parkigtype { get; set; }
    }
}
