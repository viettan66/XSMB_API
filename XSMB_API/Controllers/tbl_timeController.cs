using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XSMB_API.Models;

namespace XSMB_API.Controllers
{//https://www.xoso.net/getkqxs/mien-bac/01-01-2005.js
    [RoutePrefix("api/tbl_time")]
    public class tbl_timeController : ApiController
    {
        public struct data
        {
            public Nullable<int> giai1_so1 { get; set; }
            public Nullable<DateTime> time{ get; set; }
            public Nullable<int> giai2_so1 { get; set; }
            public Nullable<int> giai2_so2 { get; set; }
            public Nullable<int> giai3_so1 { get; set; }
            public Nullable<int> giai3_so2 { get; set; }
            public Nullable<int> giai3_so3 { get; set; }
            public Nullable<int> giai3_so4 { get; set; }
            public Nullable<int> giai3_so5 { get; set; }
            public Nullable<int> giai3_so6 { get; set; }
            public Nullable<int> giai4_so1 { get; set; }
            public Nullable<int> giai4_so2 { get; set; }
            public Nullable<int> giai4_so3 { get; set; }
            public Nullable<int> giai4_so4 { get; set; }
            public Nullable<int> giai5_so1 { get; set; }
            public Nullable<int> giai5_so2 { get; set; }
            public Nullable<int> giai5_so3 { get; set; }
            public Nullable<int> giai5_so4 { get; set; }
            public Nullable<int> giai5_so5 { get; set; }
            public Nullable<int> giai5_so6 { get; set; }
            public Nullable<int> giai6_so1 { get; set; }
            public Nullable<int> giai6_so2 { get; set; }
            public Nullable<int> giai6_so3 { get; set; }
            public Nullable<int> giai7_so1 { get; set; }
            public Nullable<int> giai7_so2 { get; set; }
            public Nullable<int> giai7_so3 { get; set; }
            public Nullable<int> giai7_so4 { get; set; }
            public Nullable<int> giaidb_so1 { get; set; }
        }
        [Route("Getall")]
        [HttpGet]
        public HttpResponseMessage Getall()
        {
            using (DB db = new DB())
            {
                var data = db.Database.SqlQuery<data>(@"SELECT        dbo.tbl_giai1.so1 AS [giai1_so1], dbo.tbl_time.time, dbo.tbl_giai2.so1 AS [giai2_so1], dbo.tbl_giai2.so2 AS [giai2_so2], dbo.tbl_giai3.so1 AS [giai3_so1], dbo.tbl_giai3.so2 AS [giai3_so2], dbo.tbl_giai3.so3 AS [giai3_so3], 
                         dbo.tbl_giai3.so4 AS [giai3_so4], dbo.tbl_giai3.so5 AS [giai3_so5], dbo.tbl_giai3.so6 AS [giai3_so6], dbo.tbl_giai4.so1 AS [giai4_so1], dbo.tbl_giai4.so2 AS [giai4_so2], dbo.tbl_giai4.so3 AS [giai4_so3], 
                         dbo.tbl_giai4.so4 AS [giai4_so4], dbo.tbl_giai5.so1 AS [giai5_so1], dbo.tbl_giai5.so2 AS [giai5_so2], dbo.tbl_giai5.so3 AS [giai5_so3], dbo.tbl_giai5.so4 AS [giai5_so4], dbo.tbl_giai5.so5 AS [giai5_so5], 
                         dbo.tbl_giai5.so6 AS [giai5_so6], dbo.tbl_giai6.so1 AS [giai6_so1], dbo.tbl_giai6.so2 AS [giai6_so2], dbo.tbl_giai6.so3 AS [giai6_so3], dbo.tbl_giai7.so1 AS [giai7_so1], dbo.tbl_giai7.so2 AS [giai7_so2], 
                         dbo.tbl_giai7.so3 AS [giai7_so3], dbo.tbl_giai7.so4 AS [giai7_so4], dbo.tbl_giaidb.so1 AS [giaidb_so1]
FROM            dbo.tbl_giai1 INNER JOIN
                         dbo.tbl_time ON dbo.tbl_giai1.tbl_giai1_ID = dbo.tbl_time.tbl_giai1_tbl_giai1_ID INNER JOIN
                         dbo.tbl_giai2 ON dbo.tbl_time.tbl_giai2_tbl_giai2_ID = dbo.tbl_giai2.tbl_giai2_ID INNER JOIN
                         dbo.tbl_giai3 ON dbo.tbl_time.tbl_giai3_tbl_giai3_ID = dbo.tbl_giai3.tbl_giai3_ID INNER JOIN
                         dbo.tbl_giai4 ON dbo.tbl_time.tbl_giai4_tbl_giai4_ID = dbo.tbl_giai4.tbl_giai4_ID INNER JOIN
                         dbo.tbl_giai5 ON dbo.tbl_time.tbl_giai5_tbl_giai5_ID = dbo.tbl_giai5.tbl_giai5_ID INNER JOIN
                         dbo.tbl_giai6 ON dbo.tbl_time.tbl_giai6_tbl_giai6_ID = dbo.tbl_giai6.tbl_giai6_ID INNER JOIN
                         dbo.tbl_giai7 ON dbo.tbl_time.tbl_giai7_tbl_giai7_ID = dbo.tbl_giai7.tbl_giai7_ID INNER JOIN
                         dbo.tbl_giaidb ON dbo.tbl_time.tbl_giaidb_tbl_giaidb_ID = dbo.tbl_giaidb.tbl_giaidb_ID");
                return REST.GetHttpResponseMessFromObject(data.ToList());
            }
        }
        [Route("add")]
        [HttpPost]
        public HttpResponseMessage add([FromBody]tbl_time values)
        {
            using (DB db = new DB())
            {
                var check = db.tbl_time.Where(p => p.time == values.time);
                if (check == null)
                {
                    db.tbl_time.Add(values);
                    db.SaveChanges();
                return REST.GetHttpResponseMessFromObject(new { code="OK" });
                }
                return REST.GetHttpResponseMessFromObject(new { code="EXIST" });
            }
        }
    }
}
