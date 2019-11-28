using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorLogin.Models.PalmDb
{
    public partial class PalmDBaseContext : DbContext
    {
        public PalmDBaseContext()
        {
        }

        public PalmDBaseContext(DbContextOptions<PalmDBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accessgroup> Accessgroup { get; set; }
        public virtual DbSet<Accesstraffic> Accesstraffic { get; set; }
        public virtual DbSet<Biometrics> Biometrics { get; set; }
        public virtual DbSet<Blocklist> Blocklist { get; set; }
        public virtual DbSet<Cardinfo> Cardinfo { get; set; }
        public virtual DbSet<CardinfoAccessgroup> CardinfoAccessgroup { get; set; }
        public virtual DbSet<CardinfoAccessgroupBackup> CardinfoAccessgroupBackup { get; set; }
        public virtual DbSet<CardinfoBackup> CardinfoBackup { get; set; }
        public virtual DbSet<Cardparkinginfo> Cardparkinginfo { get; set; }
        public virtual DbSet<CardparkinginfoBackup> CardparkinginfoBackup { get; set; }
        public virtual DbSet<Carparkavailablelot> Carparkavailablelot { get; set; }
        public virtual DbSet<Carparkconf> Carparkconf { get; set; }
        public virtual DbSet<Carparkzoneconf> Carparkzoneconf { get; set; }
        public virtual DbSet<Discountcard> Discountcard { get; set; }
        public virtual DbSet<Discountticket> Discountticket { get; set; }
        public virtual DbSet<Locationinfo> Locationinfo { get; set; }
        public virtual DbSet<Memberaccessgroup> Memberaccessgroup { get; set; }
        public virtual DbSet<Memberinfo> Memberinfo { get; set; }
        public virtual DbSet<MemberinfoBackup> MemberinfoBackup { get; set; }
        public virtual DbSet<Memberinfoext> Memberinfoext { get; set; }
        public virtual DbSet<Messageinfo> Messageinfo { get; set; }
        public virtual DbSet<Parameterlist> Parameterlist { get; set; }
        public virtual DbSet<Parkinglotstatus> Parkinglotstatus { get; set; }
        public virtual DbSet<PosExportinfo> PosExportinfo { get; set; }
        public virtual DbSet<PosInit> PosInit { get; set; }
        public virtual DbSet<PosReceipt> PosReceipt { get; set; }
        public virtual DbSet<PosReceiptitem> PosReceiptitem { get; set; }
        public virtual DbSet<PosReceiptmember> PosReceiptmember { get; set; }
        public virtual DbSet<PosReceiptvisitor> PosReceiptvisitor { get; set; }
        public virtual DbSet<Programlist> Programlist { get; set; }
        public virtual DbSet<Programlog> Programlog { get; set; }
        public virtual DbSet<Readerinfo> Readerinfo { get; set; }
        public virtual DbSet<ReaderinfoAccessgroup> ReaderinfoAccessgroup { get; set; }
        public virtual DbSet<Readerstatus> Readerstatus { get; set; }
        public virtual DbSet<Seasongroup> Seasongroup { get; set; }
        public virtual DbSet<Seasongroupdetail> Seasongroupdetail { get; set; }
        public virtual DbSet<Stationinfo> Stationinfo { get; set; }
        public virtual DbSet<Stationstatus> Stationstatus { get; set; }
        public virtual DbSet<Visitorinfo> Visitorinfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5435;Database=PalmDBase;Username=rmdf;Password=rmdf168168");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessgroup>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("accessgroup_pkey");

                entity.ToTable("accessgroup");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Name })
                    .HasName("accessgroup_key2");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Nickname })
                    .HasName("accessgroup_key1");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Doorlist)
                    .IsRequired()
                    .HasColumnName("doorlist")
                    .HasMaxLength(3999)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat)
                    .IsRequired()
                    .HasColumnName("updatedat")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 01010000'::bpchar");
            });

            modelBuilder.Entity<Accesstraffic>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("accesstraffic_pkey");

                entity.ToTable("accesstraffic");

                entity.HasIndex(e => new { e.Sid, e.Accessgroupsid })
                    .HasName("accesstraffic_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Accessgroupsid).HasColumnName("accessgroupsid");

                entity.Property(e => e.Ctrldat)
                    .IsRequired()
                    .HasColumnName("ctrldat")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Ctrlweek)
                    .IsRequired()
                    .HasColumnName("ctrlweek")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("'1234567'::character varying");

                entity.Property(e => e.Isholiday)
                    .HasColumnName("isholiday")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Trafficname)
                    .IsRequired()
                    .HasColumnName("trafficname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Validtm)
                    .IsRequired()
                    .HasColumnName("validtm")
                    .HasMaxLength(96)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Validtmfrom)
                    .IsRequired()
                    .HasColumnName("validtmfrom")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'0000'::bpchar");

                entity.Property(e => e.Validtmto)
                    .IsRequired()
                    .HasColumnName("validtmto")
                    .HasMaxLength(4)
                    .IsFixedLength()
                    .HasDefaultValueSql("'2359'::bpchar");
            });

            modelBuilder.Entity<Biometrics>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("biometrics_pkey");

                entity.ToTable("biometrics");

                entity.HasIndex(e => new { e.Sid, e.Userid, e.Seq })
                    .HasName("biometrics_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Biodata)
                    .IsRequired()
                    .HasColumnName("biodata")
                    .HasMaxLength(32768)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Bioname)
                    .IsRequired()
                    .HasColumnName("bioname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Btype)
                    .HasColumnName("btype")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Creatdat).HasColumnName("creatdat");

                entity.Property(e => e.Creatuser).HasColumnName("creatuser");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Visitorsid).HasColumnName("visitorsid");
            });

            modelBuilder.Entity<Blocklist>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("blocklist_pkey");

                entity.ToTable("blocklist");

                entity.HasIndex(e => new { e.Sid, e.Cardno, e.Updatedat })
                    .HasName("blocklist_key1");

                entity.HasIndex(e => new { e.Sid, e.Membersid, e.Cardno, e.Status })
                    .HasName("blocklist_key2");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membersid)
                    .HasColumnName("membersid")
                    .HasDefaultValueSql("'-1'::integer");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Cardinfo>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("cardinfo_pkey");

                entity.ToTable("cardinfo");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Membersid })
                    .HasName("cardinfo_key2");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Cardno, e.Status })
                    .HasName("cardinfo_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("'G'::bpchar");

                entity.Property(e => e.Carduid)
                    .IsRequired()
                    .HasColumnName("carduid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Groupaccess)
                    .IsRequired()
                    .HasColumnName("groupaccess")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Isotype).HasColumnName("isotype");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");
            });

            modelBuilder.Entity<CardinfoAccessgroup>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("cardinfo_accessgroup_pkey");

                entity.ToTable("cardinfo_accessgroup");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Accessgroupsid, e.Cardno })
                    .HasName("cardinfo_accessgroup_key1");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Accessgroupsid).HasColumnName("accessgroupsid");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<CardinfoAccessgroupBackup>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Backupdat, e.Empno, e.Backupstatus, e.Sid })
                    .HasName("cardinfo_accessgroup_backup_pkey");

                entity.ToTable("cardinfo_accessgroup_backup");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Backupdat).HasColumnName("backupdat");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Backupstatus)
                    .HasColumnName("backupstatus")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Accessgroupsid).HasColumnName("accessgroupsid");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasColumnName("empname")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<CardinfoBackup>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Backupdat, e.Empno, e.Backupstatus, e.Sid })
                    .HasName("cardinfo_backup_pkey");

                entity.ToTable("cardinfo_backup");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Backupdat).HasColumnName("backupdat");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Backupstatus)
                    .HasColumnName("backupstatus")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("'G'::bpchar");

                entity.Property(e => e.Carduid)
                    .IsRequired()
                    .HasColumnName("carduid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasColumnName("empname")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Groupaccess)
                    .IsRequired()
                    .HasColumnName("groupaccess")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Isotype).HasColumnName("isotype");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");
            });

            modelBuilder.Entity<Cardparkinginfo>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("cardparkinginfo_pkey");

                entity.ToTable("cardparkinginfo");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Cardno, e.Status })
                    .HasName("cardparkinginfo_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid)
                    .HasColumnName("carparkid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Parkingtype)
                    .HasColumnName("parkingtype")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasongroupname)
                    .HasColumnName("seasongroupname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasontype)
                    .HasColumnName("seasontype")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CardparkinginfoBackup>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Backupdat, e.Empno, e.Backupstatus, e.Sid })
                    .HasName("cardparkinginfo_backup_pkey");

                entity.ToTable("cardparkinginfo_backup");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Backupdat).HasColumnName("backupdat");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Backupstatus)
                    .HasColumnName("backupstatus")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid)
                    .HasColumnName("carparkid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasColumnName("empname")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Parkingtype).HasColumnName("parkingtype");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasongroupname)
                    .IsRequired()
                    .HasColumnName("seasongroupname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasontype)
                    .IsRequired()
                    .HasColumnName("seasontype")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Carparkavailablelot>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Carparkid, e.Zoneid })
                    .HasName("carparkavailablelot_pkey");

                entity.ToTable("carparkavailablelot");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid)
                    .HasColumnName("carparkid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Controltype).HasColumnName("controltype");

                entity.Property(e => e.Occupiedhourly).HasColumnName("occupiedhourly");

                entity.Property(e => e.Occupiedseason).HasColumnName("occupiedseason");

                entity.Property(e => e.Relay).HasColumnName("relay");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Reservedforseason).HasColumnName("reservedforseason");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totallots).HasColumnName("totallots");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Carparkconf>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("carparkconf_pkey");

                entity.ToTable("carparkconf");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Alternativename)
                    .IsRequired()
                    .HasColumnName("alternativename")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkname)
                    .IsRequired()
                    .HasColumnName("carparkname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totalzonenumber)
                    .HasColumnName("totalzonenumber")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Carparkzoneconf>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Carparkid, e.Sid })
                    .HasName("carparkzoneconf_pkey");

                entity.ToTable("carparkzoneconf");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid)
                    .HasColumnName("carparkid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Alternativename)
                    .IsRequired()
                    .HasColumnName("alternativename")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Parkigtype)
                    .HasColumnName("parkigtype")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totalzonenumber)
                    .HasColumnName("totalzonenumber")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Zonename)
                    .IsRequired()
                    .HasColumnName("zonename")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<Discountcard>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("discountcard_pkey");

                entity.ToTable("discountcard");

                entity.HasIndex(e => new { e.Sid, e.Ticketno })
                    .HasName("discountcard_key1");

                entity.HasIndex(e => new { e.Sid, e.Usecount })
                    .HasName("discountcard_key2");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Createdat)
                    .IsRequired()
                    .HasColumnName("createdat")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Createuser).HasColumnName("createuser");

                entity.Property(e => e.Discountmodel)
                    .HasColumnName("discountmodel")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Discountvalue)
                    .IsRequired()
                    .HasColumnName("discountvalue")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Ticketno)
                    .IsRequired()
                    .HasColumnName("ticketno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat)
                    .IsRequired()
                    .HasColumnName("updatedat")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Usecount).HasColumnName("usecount");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 01010000'::bpchar");
            });

            modelBuilder.Entity<Discountticket>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("discountticket_pkey");

                entity.ToTable("discountticket");

                entity.HasIndex(e => new { e.Sid, e.Serialno })
                    .HasName("discountticket_key1");

                entity.HasIndex(e => new { e.Sid, e.Ticketno })
                    .HasName("discountticket_key2");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Chargeid).HasColumnName("chargeid");

                entity.Property(e => e.Discountmodel)
                    .HasColumnName("discountmodel")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Discountvalue)
                    .IsRequired()
                    .HasColumnName("discountvalue")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Identityid)
                    .IsRequired()
                    .HasColumnName("identityid")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Serialno)
                    .IsRequired()
                    .HasColumnName("serialno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Ticketno)
                    .IsRequired()
                    .HasColumnName("ticketno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat)
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 01010000'::bpchar");
            });

            modelBuilder.Entity<Locationinfo>(entity =>
            {
                entity.HasKey(e => e.Locationname)
                    .HasName("locationinfo_pkey");

                entity.ToTable("locationinfo");

                entity.Property(e => e.Locationname)
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Buildname)
                    .IsRequired()
                    .HasColumnName("buildname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Defaultaccessgroup)
                    .IsRequired()
                    .HasColumnName("defaultaccessgroup")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Floornum)
                    .HasColumnName("floornum")
                    .HasDefaultValueSql("9999");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Roomname)
                    .IsRequired()
                    .HasColumnName("roomname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Memberaccessgroup>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("memberaccessgroup_pkey");

                entity.ToTable("memberaccessgroup");

                entity.HasIndex(e => new { e.Sid, e.Membersid, e.Validfrom, e.Validto, e.Status })
                    .HasName("memberaccessgroup_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Closedat).HasColumnName("closedat");

                entity.Property(e => e.Closeuser).HasColumnName("closeuser");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Readerlist)
                    .IsRequired()
                    .HasColumnName("readerlist")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom).HasColumnName("validfrom");

                entity.Property(e => e.Validto).HasColumnName("validto");
            });

            modelBuilder.Entity<Memberinfo>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("memberinfo_pkey");

                entity.ToTable("memberinfo");

                entity.HasIndex(e => new { e.Sid, e.Identityid })
                    .HasName("memberinfo_key2");

                entity.HasIndex(e => new { e.Sid, e.Name })
                    .HasName("memberinfo_key1");

                entity.HasIndex(e => new { e.Sid, e.Updatedat })
                    .HasName("memberinfo_key4");

                entity.HasIndex(e => new { e.Sid, e.Phone1, e.Phone2 })
                    .HasName("memberinfo_key3");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Accessauthority)
                    .IsRequired()
                    .HasColumnName("accessauthority")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Attention).HasColumnName("attention");

                entity.Property(e => e.Attentiondat)
                    .IsRequired()
                    .HasColumnName("attentiondat")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Attentionuser).HasColumnName("attentionuser");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasColumnName("contact")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Contactphone)
                    .IsRequired()
                    .HasColumnName("contactphone")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'U'::bpchar");

                entity.Property(e => e.Identityid)
                    .IsRequired()
                    .HasColumnName("identityid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membertype)
                    .IsRequired()
                    .HasColumnName("membertype")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<MemberinfoBackup>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Backupdat, e.Empno, e.Backupstatus, e.Sid })
                    .HasName("memberinfo_backup_pkey");

                entity.ToTable("memberinfo_backup");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Backupdat).HasColumnName("backupdat");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Backupstatus)
                    .HasColumnName("backupstatus")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Accessauthority)
                    .IsRequired()
                    .HasColumnName("accessauthority")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Attention).HasColumnName("attention");

                entity.Property(e => e.Attentiondat)
                    .IsRequired()
                    .HasColumnName("attentiondat")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Attentionuser).HasColumnName("attentionuser");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasColumnName("contact")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Contactphone)
                    .IsRequired()
                    .HasColumnName("contactphone")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasColumnName("empname")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'U'::bpchar");

                entity.Property(e => e.Identityid)
                    .IsRequired()
                    .HasColumnName("identityid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membertype)
                    .IsRequired()
                    .HasColumnName("membertype")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Memberinfoext>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("memberinfoext_pkey");

                entity.ToTable("memberinfoext");

                entity.HasIndex(e => new { e.Sid, e.Loginid, e.Pwd })
                    .HasName("memberinfoext_key2");

                entity.HasIndex(e => new { e.Sid, e.Membersid, e.Visitorsid, e.Exttype })
                    .HasName("memberinfoext_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Exttype)
                    .HasColumnName("exttype")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Loginid)
                    .IsRequired()
                    .HasColumnName("loginid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Mailcheck).HasColumnName("mailcheck");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phonecheck).HasColumnName("phonecheck");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Visitorsid).HasColumnName("visitorsid");
            });

            modelBuilder.Entity<Messageinfo>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("messageinfo_pkey");

                entity.ToTable("messageinfo");

                entity.HasIndex(e => new { e.Sid, e.Parentsid, e.Status })
                    .HasName("messageinfo_key3");

                entity.HasIndex(e => new { e.Sid, e.Membersid, e.Sendmail, e.Showmessage, e.Status })
                    .HasName("messageinfo_key1");

                entity.HasIndex(e => new { e.Sid, e.Membersid, e.Locationname, e.Validfrom, e.Validto, e.Status })
                    .HasName("messageinfo_key2");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Closedat).HasColumnName("closedat");

                entity.Property(e => e.Closeuser).HasColumnName("closeuser");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnName("context")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Createdat).HasColumnName("createdat");

                entity.Property(e => e.Createuser).HasColumnName("createuser");

                entity.Property(e => e.Lastreaddat).HasColumnName("lastreaddat");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membersid).HasColumnName("membersid");

                entity.Property(e => e.Messagetype).HasColumnName("messagetype");

                entity.Property(e => e.Parentsid).HasColumnName("parentsid");

                entity.Property(e => e.Readcount).HasColumnName("readcount");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sendmail).HasColumnName("sendmail");

                entity.Property(e => e.Showmessage).HasColumnName("showmessage");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom).HasColumnName("validfrom");

                entity.Property(e => e.Validto).HasColumnName("validto");
            });

            modelBuilder.Entity<Parameterlist>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("parameterlist_pkey");

                entity.ToTable("parameterlist");

                entity.HasIndex(e => new { e.Sid, e.Classify })
                    .HasName("parameterlistkey1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Classify)
                    .IsRequired()
                    .HasColumnName("classify")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnName("context")
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Iso3166)
                    .IsRequired()
                    .HasColumnName("iso3166")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");
            });

            modelBuilder.Entity<Parkinglotstatus>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("parkinglotstatus_pkey");

                entity.ToTable("parkinglotstatus");

                entity.HasIndex(e => new { e.Cardno, e.Carparkidx, e.Zoneidx })
                    .HasName("parkinglotstatus_key2");

                entity.HasIndex(e => new { e.Sid, e.Carparkidx, e.Zoneidx })
                    .HasName("parkinglotstatus_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("'3'::bpchar");

                entity.Property(e => e.Carparkidx)
                    .HasColumnName("carparkidx")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Entrytime)
                    .IsRequired()
                    .HasColumnName("entrytime")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Zoneidx)
                    .HasColumnName("zoneidx")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<PosExportinfo>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("pos_exportinfo_pkey");

                entity.ToTable("pos_exportinfo");

                entity.HasIndex(e => new { e.Guid, e.Sid })
                    .HasName("pos_exportinfokey1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Denomination).HasColumnName("denomination");

                entity.Property(e => e.Exportnumber).HasColumnName("exportnumber");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<PosInit>(entity =>
            {
                entity.HasKey(e => new { e.Posid, e.Sid })
                    .HasName("pos_init_pkey");

                entity.ToTable("pos_init");

                entity.Property(e => e.Posid)
                    .HasColumnName("posid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Createdat).HasColumnName("createdat");

                entity.Property(e => e.Createuser)
                    .IsRequired()
                    .HasColumnName("createuser")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Enddat).HasColumnName("enddat");

                entity.Property(e => e.Enduser)
                    .IsRequired()
                    .HasColumnName("enduser")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnName("hostname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Initmoney).HasColumnName("initmoney");

                entity.Property(e => e.Machineid)
                    .IsRequired()
                    .HasColumnName("machineid")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totalmoney).HasColumnName("totalmoney");
            });

            modelBuilder.Entity<PosReceipt>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("pos_receipt_pkey");

                entity.ToTable("pos_receipt");

                entity.HasIndex(e => new { e.Guid, e.Posid, e.InitSid, e.Receiptdat })
                    .HasName("pos_receiptkey1");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Discountamount).HasColumnName("discountamount");

                entity.Property(e => e.Discountmodel)
                    .HasColumnName("discountmodel")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Estackid)
                    .IsRequired()
                    .HasColumnName("estackid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnName("hostname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.InitSid).HasColumnName("init_sid");

                entity.Property(e => e.Initmoney).HasColumnName("initmoney");

                entity.Property(e => e.Machineid)
                    .IsRequired()
                    .HasColumnName("machineid")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Memberitem).HasColumnName("memberitem");

                entity.Property(e => e.Payment).HasColumnName("payment");

                entity.Property(e => e.Posid)
                    .IsRequired()
                    .HasColumnName("posid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Productitem).HasColumnName("productitem");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Receiptdat).HasColumnName("receiptdat");

                entity.Property(e => e.Recepitid)
                    .IsRequired()
                    .HasColumnName("recepitid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totalmoney).HasColumnName("totalmoney");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser)
                    .IsRequired()
                    .HasColumnName("updateuser")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Vat).HasColumnName("vat");

                entity.Property(e => e.Visitoritem).HasColumnName("visitoritem");
            });

            modelBuilder.Entity<PosReceiptitem>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("pos_receiptitem_pkey");

                entity.ToTable("pos_receiptitem");

                entity.HasIndex(e => new { e.Guid, e.Sid })
                    .HasName("pos_receiptitemkey1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Totalcount).HasColumnName("totalcount");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnName("unit")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");
            });

            modelBuilder.Entity<PosReceiptmember>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("pos_receiptmember_pkey");

                entity.ToTable("pos_receiptmember");

                entity.HasIndex(e => new { e.Guid, e.Sid })
                    .HasName("pos_receiptmemberkey1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Addtionmonth).HasColumnName("addtionmonth");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Carparkindex).HasColumnName("carparkindex");

                entity.Property(e => e.Cartype).HasColumnName("cartype");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Newvalidto)
                    .IsRequired()
                    .HasColumnName("newvalidto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Validstart)
                    .IsRequired()
                    .HasColumnName("validstart")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Zoneindex).HasColumnName("zoneindex");
            });

            modelBuilder.Entity<PosReceiptvisitor>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("pos_receiptvisitor_pkey");

                entity.ToTable("pos_receiptvisitor");

                entity.HasIndex(e => new { e.Guid, e.Sid })
                    .HasName("pos_receiptvisitorkey1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cartype).HasColumnName("cartype");

                entity.Property(e => e.Checkinplate)
                    .IsRequired()
                    .HasColumnName("checkinplate")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Checkoutplate)
                    .IsRequired()
                    .HasColumnName("checkoutplate")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Discountamount).HasColumnName("discountamount");

                entity.Property(e => e.Discountmodel)
                    .HasColumnName("discountmodel")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Entrytime)
                    .IsRequired()
                    .HasColumnName("entrytime")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Estackid)
                    .IsRequired()
                    .HasColumnName("estackid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Exittime)
                    .IsRequired()
                    .HasColumnName("exittime")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Parkingtime).HasColumnName("parkingtime");

                entity.Property(e => e.Parkingtimestr)
                    .IsRequired()
                    .HasColumnName("parkingtimestr")
                    .HasMaxLength(99)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Zoneindex).HasColumnName("zoneindex");
            });

            modelBuilder.Entity<Programlist>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("programlist_pkey");

                entity.ToTable("programlist");

                entity.HasIndex(e => new { e.Sid, e.Programtype })
                    .HasName("programlist_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Groupseq).HasColumnName("groupseq");

                entity.Property(e => e.Imageformat)
                    .IsRequired()
                    .HasColumnName("imageformat")
                    .HasMaxLength(500000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Programdat).HasColumnName("programdat");

                entity.Property(e => e.Programname)
                    .IsRequired()
                    .HasColumnName("programname")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Programseq)
                    .HasColumnName("programseq")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Programtype)
                    .IsRequired()
                    .HasColumnName("programtype")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sharedata)
                    .IsRequired()
                    .HasColumnName("sharedata")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Showname)
                    .IsRequired()
                    .HasColumnName("showname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateitem)
                    .HasColumnName("updateitem")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.Updateuser)
                    .IsRequired()
                    .HasColumnName("updateuser")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<Programlog>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("programlog_pkey");

                entity.ToTable("programlog");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Devicename)
                    .IsRequired()
                    .HasColumnName("devicename")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Lasttime).HasColumnName("lasttime");

                entity.Property(e => e.Nowtime).HasColumnName("nowtime");

                entity.Property(e => e.Programtype)
                    .IsRequired()
                    .HasColumnName("programtype")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<Readerinfo>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("readerinfo_pkey");

                entity.ToTable("readerinfo");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Readername })
                    .HasName("readerinfo_key2");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Readertype })
                    .HasName("readerinfo_key1");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config")
                    .HasMaxLength(3999)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Defaultconfig)
                    .IsRequired()
                    .HasColumnName("defaultconfig")
                    .HasMaxLength(3999)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Dooraccessport)
                    .HasColumnName("dooraccessport")
                    .HasDefaultValueSql("3001");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("ipaddress")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Parentname)
                    .IsRequired()
                    .HasColumnName("parentname")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Readerid)
                    .HasColumnName("readerid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Readername)
                    .IsRequired()
                    .HasColumnName("readername")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Readertype)
                    .HasColumnName("readertype")
                    .HasDefaultValueSql("'D'::bpchar");

                entity.Property(e => e.ServerIp)
                    .IsRequired()
                    .HasColumnName("server_ip")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'192.168.1.41'::character varying");

                entity.Property(e => e.ServerPort)
                    .HasColumnName("server_port")
                    .HasDefaultValueSql("9999");

                entity.Property(e => e.Transferport)
                    .HasColumnName("transferport")
                    .HasDefaultValueSql("3002");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<ReaderinfoAccessgroup>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("readerinfo_accessgroup_pkey");

                entity.ToTable("readerinfo_accessgroup");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Accessgroupsid })
                    .HasName("readerinfo_accessgroup_key1");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Accessgroupsid).HasColumnName("accessgroupsid");

                entity.Property(e => e.Readerinfosid).HasColumnName("readerinfosid");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Readerstatus>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("readerstatus_pkey");

                entity.ToTable("readerstatus");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Readername, e.Readertype, e.Updatedat })
                    .HasName("readerstatus_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Dattm)
                    .IsRequired()
                    .HasColumnName("dattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erractive)
                    .IsRequired()
                    .HasColumnName("erractive")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erractivedattm)
                    .IsRequired()
                    .HasColumnName("erractivedattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errio)
                    .IsRequired()
                    .HasColumnName("errio")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erriodattm)
                    .IsRequired()
                    .HasColumnName("erriodattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errstatus)
                    .IsRequired()
                    .HasColumnName("errstatus")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errstatusdattm)
                    .IsRequired()
                    .HasColumnName("errstatusdattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erruart)
                    .IsRequired()
                    .HasColumnName("erruart")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erruartdattm)
                    .IsRequired()
                    .HasColumnName("erruartdattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Iocontext)
                    .IsRequired()
                    .HasColumnName("iocontext")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Iodattm)
                    .IsRequired()
                    .HasColumnName("iodattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membername)
                    .IsRequired()
                    .HasColumnName("membername")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Messagedattm)
                    .IsRequired()
                    .HasColumnName("messagedattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Readername)
                    .IsRequired()
                    .HasColumnName("readername")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Readertype)
                    .HasColumnName("readertype")
                    .HasDefaultValueSql("'S'::bpchar");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Watchdog)
                    .IsRequired()
                    .HasColumnName("watchdog")
                    .HasMaxLength(22)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");
            });

            modelBuilder.Entity<Seasongroup>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("seasongroup_pkey");

                entity.ToTable("seasongroup");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Seasongroupname })
                    .HasName("seasongroup_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid1).HasColumnName("carparkid_1");

                entity.Property(e => e.Carparkid2).HasColumnName("carparkid_2");

                entity.Property(e => e.Carparkid3).HasColumnName("carparkid_3");

                entity.Property(e => e.Carparkid4).HasColumnName("carparkid_4");

                entity.Property(e => e.Carparkid5).HasColumnName("carparkid_5");

                entity.Property(e => e.Ctrlcarpark).HasColumnName("ctrlcarpark");

                entity.Property(e => e.Membersid)
                    .HasColumnName("membersid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Parkingtype).HasColumnName("parkingtype");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasongroupcount)
                    .HasColumnName("seasongroupcount")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Seasongroupname)
                    .IsRequired()
                    .HasColumnName("seasongroupname")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasontype)
                    .IsRequired()
                    .HasColumnName("seasontype")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom)
                    .IsRequired()
                    .HasColumnName("validfrom")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("''::bpchar");

                entity.Property(e => e.Validto)
                    .IsRequired()
                    .HasColumnName("validto")
                    .HasMaxLength(17)
                    .IsFixedLength()
                    .HasDefaultValueSql("'29991231 00000000'::bpchar");

                entity.Property(e => e.Zoneid1).HasColumnName("zoneid_1");

                entity.Property(e => e.Zoneid2).HasColumnName("zoneid_2");

                entity.Property(e => e.Zoneid3).HasColumnName("zoneid_3");

                entity.Property(e => e.Zoneid4).HasColumnName("zoneid_4");

                entity.Property(e => e.Zoneid5).HasColumnName("zoneid_5");
            });

            modelBuilder.Entity<Seasongroupdetail>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("seasongroupdetail_pkey");

                entity.ToTable("seasongroupdetail");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Seasongroupsid).HasColumnName("seasongroupsid");
            });

            modelBuilder.Entity<Stationinfo>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Carparkid, e.Zoneid, e.Sid })
                    .HasName("stationinfo_pkey");

                entity.ToTable("stationinfo");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Carparkid)
                    .HasColumnName("carparkid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Zoneid)
                    .HasColumnName("zoneid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config")
                    .HasMaxLength(3999)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Defaultconfig)
                    .IsRequired()
                    .HasColumnName("defaultconfig")
                    .HasMaxLength(3999)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("ipaddress")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasDefaultValueSql("3001");

                entity.Property(e => e.ServerIp)
                    .IsRequired()
                    .HasColumnName("server_ip")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'192.168.1.41'::character varying");

                entity.Property(e => e.ServerPort)
                    .HasColumnName("server_port")
                    .HasDefaultValueSql("9999");

                entity.Property(e => e.Stationname)
                    .IsRequired()
                    .HasColumnName("stationname")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Stationtype)
                    .HasColumnName("stationtype")
                    .HasDefaultValueSql("'E'::bpchar");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");
            });

            modelBuilder.Entity<Stationstatus>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("stationstatus_pkey");

                entity.ToTable("stationstatus");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Stationname, e.Updatedat })
                    .HasName("stationstatus_key1");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Blob)
                    .IsRequired()
                    .HasColumnName("blob")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Dattm)
                    .IsRequired()
                    .HasColumnName("dattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erractive)
                    .IsRequired()
                    .HasColumnName("erractive")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erractivedattm)
                    .IsRequired()
                    .HasColumnName("erractivedattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errio)
                    .IsRequired()
                    .HasColumnName("errio")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erriodattm)
                    .IsRequired()
                    .HasColumnName("erriodattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errstatus)
                    .IsRequired()
                    .HasColumnName("errstatus")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Errstatusdattm)
                    .IsRequired()
                    .HasColumnName("errstatusdattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erruart)
                    .IsRequired()
                    .HasColumnName("erruart")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Erruartdattm)
                    .IsRequired()
                    .HasColumnName("erruartdattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Iocontext)
                    .IsRequired()
                    .HasColumnName("iocontext")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Iodattm)
                    .IsRequired()
                    .HasColumnName("iodattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Lastled)
                    .IsRequired()
                    .HasColumnName("lastled")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Lastleddattm)
                    .IsRequired()
                    .HasColumnName("lastleddattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Membername)
                    .IsRequired()
                    .HasColumnName("membername")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Messagedattm)
                    .IsRequired()
                    .HasColumnName("messagedattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Newled)
                    .IsRequired()
                    .HasColumnName("newled")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Newleddattm)
                    .IsRequired()
                    .HasColumnName("newleddattm")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Parkfee).HasColumnName("parkfee");

                entity.Property(e => e.Pgs)
                    .IsRequired()
                    .HasColumnName("pgs")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Pgsphoto1)
                    .IsRequired()
                    .HasColumnName("pgsphoto1")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Pgsphoto2)
                    .IsRequired()
                    .HasColumnName("pgsphoto2")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Pgsphoto3)
                    .IsRequired()
                    .HasColumnName("pgsphoto3")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Projectid)
                    .IsRequired()
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Stationname)
                    .IsRequired()
                    .HasColumnName("stationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Stationtype)
                    .IsRequired()
                    .HasColumnName("stationtype")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Takepicture1)
                    .IsRequired()
                    .HasColumnName("takepicture1")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Takepicture2)
                    .IsRequired()
                    .HasColumnName("takepicture2")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Takepicturedattm1)
                    .IsRequired()
                    .HasColumnName("takepicturedattm1")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Takepicturedattm2)
                    .IsRequired()
                    .HasColumnName("takepicturedattm2")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Watchdog)
                    .IsRequired()
                    .HasColumnName("watchdog")
                    .HasMaxLength(22)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<Visitorinfo>(entity =>
            {
                entity.HasKey(e => new { e.Projectid, e.Sid })
                    .HasName("visitorinfo_pkey");

                entity.ToTable("visitorinfo");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Identityid })
                    .HasName("visitorinfo_key2");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Name })
                    .HasName("visitorinfo_key1");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Phone })
                    .HasName("visitorinfo_key3");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Cardno, e.Status })
                    .HasName("visitorinfo_key4");

                entity.HasIndex(e => new { e.Projectid, e.Sid, e.Cardno, e.Validfrom, e.Validto })
                    .HasName("visitorinfo_key5");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cardno)
                    .IsRequired()
                    .HasColumnName("cardno")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Filename1)
                    .IsRequired()
                    .HasColumnName("filename1")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Filename2)
                    .IsRequired()
                    .HasColumnName("filename2")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Filename3)
                    .IsRequired()
                    .HasColumnName("filename3")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Groupaccess)
                    .IsRequired()
                    .HasColumnName("groupaccess")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Identityid)
                    .IsRequired()
                    .HasColumnName("identityid")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Interviewee)
                    .IsRequired()
                    .HasColumnName("interviewee")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Intervieweesid).HasColumnName("intervieweesid");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("locationname")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasColumnName("plate")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasColumnName("purpose")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Updatedat).HasColumnName("updatedat");

                entity.Property(e => e.Updateuser).HasColumnName("updateuser");

                entity.Property(e => e.Validfrom).HasColumnName("validfrom");

                entity.Property(e => e.Validfromuser).HasColumnName("validfromuser");

                entity.Property(e => e.Validto).HasColumnName("validto");

                entity.Property(e => e.Validtouser).HasColumnName("validtouser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
