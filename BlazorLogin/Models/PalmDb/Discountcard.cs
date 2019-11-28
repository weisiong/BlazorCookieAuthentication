using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Discountcard
    {
        public int Sid { get; set; }
        public string Ticketno { get; set; }
        public int Discountmodel { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public string Discountvalue { get; set; }
        public int Createuser { get; set; }
        public string Createdat { get; set; }
        public int Usecount { get; set; }
        public int Updateuser { get; set; }
        public string Updatedat { get; set; }
    }
}
