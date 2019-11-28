using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Parameterlist
    {
        public int Sid { get; set; }
        public string Iso3166 { get; set; }
        public string Classify { get; set; }
        public string Keyword { get; set; }
        public string Context { get; set; }
        public string Status { get; set; }
        public long Updatedat { get; set; }
        public string Blob { get; set; }
    }
}
