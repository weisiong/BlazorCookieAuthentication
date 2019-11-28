using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PosReceiptitem
    {
        public long Sid { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Unitprice { get; set; }
        public int Totalcount { get; set; }
        public string Status { get; set; }
    }
}
