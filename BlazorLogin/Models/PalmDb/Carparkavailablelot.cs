using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Carparkavailablelot
    {
        public string Projectid { get; set; }
        public int Carparkid { get; set; }
        public int Zoneid { get; set; }
        public int Totallots { get; set; }
        public int Relay { get; set; }
        public int Reservedforseason { get; set; }
        public int Controltype { get; set; }
        public int Occupiedseason { get; set; }
        public int Occupiedhourly { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
