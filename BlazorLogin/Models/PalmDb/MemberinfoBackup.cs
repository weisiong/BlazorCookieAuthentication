using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class MemberinfoBackup
    {
        public string Guid { get; set; }
        public long Backupdat { get; set; }
        public int Empno { get; set; }
        public string Empname { get; set; }
        public int Backupstatus { get; set; }
        public long Sid { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Identityid { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Contactphone { get; set; }
        public string Locationname { get; set; }
        public string Accessauthority { get; set; }
        public string Pwd { get; set; }
        public string Membertype { get; set; }
        public int Attention { get; set; }
        public int Attentionuser { get; set; }
        public string Attentiondat { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
