using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XSMB_API.Models
{
    public class DB : DbContext
    {
        public DB() : base("DefaultConnection")
        {
            //var initializer = new MigrateDatabaseToLatestVersion<DB, QLKTX_API_V2.Migrations.Configuration>();
            //Database.SetInitializer(initializer);

        }
        public DbSet<tbl_time> tbl_time { get; set; }
        public DbSet<tbl_giaidb> tbl_giaidb { get; set; }
        public DbSet<tbl_giai1> tbl_giai1 { get; set; }
        public DbSet<tbl_giai2> tbl_giai2 { get; set; }
        public DbSet<tbl_giai3> tbl_giai3 { get; set; }
        public DbSet<tbl_giai4> tbl_giai4 { get; set; }
        public DbSet<tbl_giai5> tbl_giai5 { get; set; }
        public DbSet<tbl_giai6> tbl_giai6 { get; set; }
        public DbSet<tbl_giai7> tbl_giai7 { get; set; }
    }
    public class tbl_time
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_time_ID { get; set; }
        public Nullable<DateTime> time { get; set; }
        public string ghichu { get; set; }
        public virtual tbl_giaidb tbl_giaidb { get; set; }
        public virtual tbl_giai1 tbl_giai1 { get; set; }
        public virtual tbl_giai2 tbl_giai2 { get; set; }
        public virtual tbl_giai3 tbl_giai3 { get; set; }
        public virtual tbl_giai4 tbl_giai4 { get; set; }
        public virtual tbl_giai5 tbl_giai5 { get; set; }
        public virtual tbl_giai6 tbl_giai6 { get; set; }
        public virtual tbl_giai7 tbl_giai7 { get; set; }
    }

    public class tbl_giaidb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giaidb_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai1_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai2_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai3_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public Nullable<int> so3 { get; set; }
        public Nullable<int> so4 { get; set; }
        public Nullable<int> so5 { get; set; }
        public Nullable<int> so6 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai4_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public Nullable<int> so3 { get; set; }
        public Nullable<int> so4 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai5
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai5_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public Nullable<int> so3 { get; set; }
        public Nullable<int> so4 { get; set; }
        public Nullable<int> so5 { get; set; }
        public Nullable<int> so6 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai6
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai6_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public Nullable<int> so3 { get; set; }
        public string ghichu { get; set; }
    }
    public class tbl_giai7
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tbl_giai7_ID { get; set; }
        public int tbl_time_ID { get; set; }
        public Nullable<int> so1 { get; set; }
        public Nullable<int> so2 { get; set; }
        public Nullable<int> so3 { get; set; }
        public Nullable<int> so4 { get; set; }
        public string ghichu { get; set; }
    }


}