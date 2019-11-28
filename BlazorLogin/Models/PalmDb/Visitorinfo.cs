using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class Visitorinfo
    {
        public string Projectid { get; set; }
        public int Sid { get; set; }
        public string Cardno { get; set; }
        public string Name { get; set; }
        public string Identityid { get; set; }
        public string Phone { get; set; }
        public string Plate { get; set; }
        public string Purpose { get; set; }
        public string Groupaccess { get; set; }
        public string Interviewee { get; set; }
        public string Locationname { get; set; }
        public int Intervieweesid { get; set; }
        public string Filename1 { get; set; }
        public string Filename2 { get; set; }
        public string Filename3 { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public int Validfromuser { get; set; }
        public long Validfrom { get; set; }
        public int Validtouser { get; set; }
        public long Validto { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
