using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web.Http;
using XSMB_API.Models;

namespace XSMB_API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (id == 1)
            {
                var date = DateTime.Parse("2005-01-01");
                WebClient webC = new WebClient();
                webC.Encoding = Encoding.UTF8;
                string f = "";
                while (date < DateTime.Parse(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day))
                {
                    try {
                    string k = webC.DownloadString("http://www.xoso.net/getkqxs/mien-bac/" + date.Day + "-" + date.Month + "-" + date.Year + ".js");

                    if (k.IndexOf("<tbody>") == -1)
                    {
                        date = date.AddDays(1);
                        continue;
                    }
                
                    string j= k.Substring(k.IndexOf("<tbody>"),k.LastIndexOf("</tbody>")-k.IndexOf("<tbody>")+8);

                    j = j.Replace("\t", "").Replace(" ","").Replace("\\","");
                    string giaidb = j.Substring(j.IndexOf("giaidb\">")+8, 5);
                    string giai1 = j.Substring(j.IndexOf("giai1\">")+7, 5);
                    string giai2 = j.Substring(j.IndexOf("giai2\">")+7, 11);
                    string giai3 = j.Substring(j.IndexOf("giai3\">")+7, 35);
                    string giai4 = j.Substring(j.IndexOf("giai4\">")+7, 19);
                    string giai5 = j.Substring(j.IndexOf("giai5\">")+7, 29);
                    string giai6 = j.Substring(j.IndexOf("giai6\">")+7, 11);
                    string giai7 = j.Substring(j.IndexOf("giai7\">")+7, 11);
                    f += giai1+"\n"+ giai2 + "\n"+giai3 + "\n"+giai4 + "\n"+giai5 + "\n"+giai6 + "\n"+giai7 + "\n";
                        int test = 0;
                        if (!int.TryParse(giaidb,out test))
                    {
                        date = date.AddDays(1);
                        continue;
                    }
                    tbl_time temp = new tbl_time()
                    {
                        time = date,
                        tbl_giaidb = new tbl_giaidb()
                        {
                            so1 = int.Parse(giaidb)
                        },
                        tbl_giai1 = new tbl_giai1()
                        {
                            so1 = int.Parse(giai1)
                        },
                        tbl_giai2 = new tbl_giai2()
                        {
                            so1 = int.Parse(giai2.Split('-')[0]),
                            so2 = int.Parse(giai2.Split('-')[1])
                        },
                        tbl_giai3 = new tbl_giai3()
                        {
                            so1 = int.Parse(giai3.Split('-')[0]),
                            so2 = int.Parse(giai3.Split('-')[1]),
                            so3 = int.Parse(giai3.Split('-')[2]),
                            so4 = int.Parse(giai3.Split('-')[3]),
                            so5 = int.Parse(giai3.Split('-')[4]),
                            so6 = int.Parse(giai3.Split('-')[5])
                        },
                        tbl_giai4 = new tbl_giai4()
                        {
                            so1 = int.Parse(giai4.Split('-')[0]),
                            so2 = int.Parse(giai4.Split('-')[1]),
                            so3 = int.Parse(giai4.Split('-')[2]),
                            so4 = int.Parse(giai4.Split('-')[3])
                        },
                        tbl_giai5 = new tbl_giai5()
                        {
                            so1 = int.Parse(giai5.Split('-')[0]),
                            so2 = int.Parse(giai5.Split('-')[1]),
                            so3 = int.Parse(giai5.Split('-')[2]),
                            so4 = int.Parse(giai5.Split('-')[3]),
                            so5 = int.Parse(giai5.Split('-')[4]),
                            so6 = int.Parse(giai5.Split('-')[5])
                        },
                        tbl_giai6 = new tbl_giai6()
                        {
                            so1 = int.Parse(giai6.Split('-')[0]),
                            so2 = int.Parse(giai6.Split('-')[1]),
                            so3 = int.Parse(giai6.Split('-')[2])
                        },
                        tbl_giai7 = new tbl_giai7()
                        {
                            so1 = int.Parse(giai7.Split('-')[0]),
                            so2 = int.Parse(giai7.Split('-')[1]),
                            so3 = int.Parse(giai7.Split('-')[2]),
                            so4 = int.Parse(giai7.Split('-')[3])
                        },
                    };
                    add(temp);
                    date = date.AddDays(1);
                    }
                    catch
                    {
                        Thread.Sleep(2000);
                    }
                } 
                return REST.GetHttpResponseMessFromObject((f));
            }
                return REST.GetHttpResponseMessFromObject(null);
        }
        public void add(tbl_time values)
        {
            using (DB db = new DB())
            {
                var check = db.tbl_time.Where(p => p.time == values.time).FirstOrDefault();
                if (check == null)
                {
                    db.tbl_time.Add(values);
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
