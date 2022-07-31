using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class httpclientlogdata
    {
        //public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7021/") };
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://userdatawebapi20220502202651.azurewebsites.net/") };
        public static async Task<IEnumerable<Userlogdataprint>> Get()
        {
            try
            {
                return await client.GetFromJsonAsync<IEnumerable<Userlogdataprint>>("/LineBotWebHook/userdaylog");
            }
            catch
            {
                return null;
            }
        }
    }
}
