using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Discountticket
    {
        public int Sid { get; set; }
        public string Serialno { get; set; }
        public string Ticketno { get; set; }
        public int Discountmodel { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }
        public string Discountvalue { get; set; }
        public string Cardno { get; set; }
        public string Name { get; set; }
        public string Identityid { get; set; }
        public string Phone { get; set; }
        public string Locationname { get; set; }
        public long Chargeid { get; set; }
        public int Updateuser { get; set; }
        public long? Updatedat { get; set; }
    }
}
