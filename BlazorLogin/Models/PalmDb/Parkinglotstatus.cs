using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Parkinglotstatus
    {
        public long Sid { get; set; }
        public string Cardno { get; set; }
        public char Cardtype { get; set; }
        public int Carparkidx { get; set; }
        public int Zoneidx { get; set; }
        public string Entrytime { get; set; }
        public string Plate { get; set; }
    }
}
