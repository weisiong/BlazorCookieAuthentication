using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Readerstatus
    {
        public long Sid { get; set; }
        public string Projectid { get; set; }
        public string Readername { get; set; }
        public char Readertype { get; set; }
        public string Cardno { get; set; }
        public string Membername { get; set; }
        public string Status { get; set; }
        public string Dattm { get; set; }
        public string Iocontext { get; set; }
        public string Iodattm { get; set; }
        public string Errstatus { get; set; }
        public string Errstatusdattm { get; set; }
        public string Errio { get; set; }
        public string Erriodattm { get; set; }
        public string Erruart { get; set; }
        public string Erruartdattm { get; set; }
        public string Erractive { get; set; }
        public string Erractivedattm { get; set; }
        public string Message { get; set; }
        public string Messagedattm { get; set; }
        public string Watchdog { get; set; }
        public long Updatedat { get; set; }
        public string Blob { get; set; }
    }
}
