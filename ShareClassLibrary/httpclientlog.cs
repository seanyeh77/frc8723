using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net;
//using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Net.Http.Headers;
//using System.Web.Script.Serialization;

namespace ShareClassLibrary
{
    public class httpclientlog
    {
        //public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7021/") };
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://userdatawebapi20220502202651.azurewebsites.net/") };
        public static async Task<IEnumerable<UserPoint>?> Get()
        {
            try
            {
                return await client.GetFromJsonAsync<IEnumerable<UserPoint>>("/UserLog/table");
            }
            catch
            {
                return null;
            }
        }
    }
}
