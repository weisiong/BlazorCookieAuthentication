using System;
using System.Collections.Generic;

namespace BlazorLogin.Models.PalmDb
{
    public partial class CardinfoAccessgroupBackup
    {
        public string Guid { get; set; }
        public long Backupdat { get; set; }
        public int Empno { get; set; }
        public string Empname { get; set; }
        public int Backupstatus { get; set; }
        public long Sid { get; set; }
        public string Projectid { get; set; }
        public int Accessgroupsid { get; set; }
        public string Cardno { get; set; }
        public int Updateuser { get; set; }
        public long Updatedat { get; set; }
    }
}
