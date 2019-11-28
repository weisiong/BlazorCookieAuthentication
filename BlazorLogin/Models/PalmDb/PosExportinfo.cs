using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosExportinfo
    {
        public long Sid { get; set; }
        public string Guid { get; set; }
        public double Denomination { get; set; }
        public int Exportnumber { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
    }
}
