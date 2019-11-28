using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Stationstatus
    {
        public long Sid { get; set; }
        public string Projectid { get; set; }
        public string Stationname { get; set; }
        public string Cardno { get; set; }
        public string Plate { get; set; }
        public string Pgs { get; set; }
        public string Pgsphoto1 { get; set; }
        public string Pgsphoto2 { get; set; }
        public string Pgsphoto3 { get; set; }
        public string Membername { get; set; }
        public string Stationtype { get; set; }
        public int Parkfee { get; set; }
        public string Status { get; set; }
        public string Dattm { get; set; }
        public string Iocontext { get; set; }
        public string Iodattm { get; set; }
        public string Newled { get; set; }
        public string Newleddattm { get; set; }
        public string Lastled { get; set; }
        public string Lastleddattm { get; set; }
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
        public string Takepicture1 { get; set; }
        public string Takepicturedattm1 { get; set; }
        public string Takepicture2 { get; set; }
        public string Takepicturedattm2 { get; set; }
        public string Watchdog { get; set; }
        public long Updatedat { get; set; }
        public string Blob { get; set; }
    }
}
