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
    public class httpclientdata
    {
        //public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7021/") };
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://userdatawebapi20220829195800.azurewebsites.net/") };
        public static List<UserData> result = new List<UserData>();
        public static async Task<List<UserData>> Get()
        {
            try
            {
                return await client.GetFromJsonAsync<List<UserData>>("/userdata");
                
                //return result;
            }
            catch
            {
                result = new List<UserData>();
                return result;
            }
        }
        //public static async Task<String> Post(UserData userData)
        //{
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //    new MediaTypeWithQualityHeaderValue("application/json"));
        //    string json = JsonConvert.SerializeObject(userData);
        //    // 將轉為 string 的 json 依編碼並指定 content type 存為 httpcontent
        //    HttpContent contentPost = new StringContent(json, Encoding.UTF8, "application/json");
        //    // 發出 post 並取得結果
        //    HttpResponseMessage response = client.PostAsync("UserData", contentPost).GetAwaiter().GetResult();

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        string err = await response.Content.ReadAsStringAsync();
        //        return err;
        //    }
        //    else
        //    {
        //        return "scuess";
        //    }
        //}
        //public static async Task<string> delete(string atr)
        //{
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //    new MediaTypeWithQualityHeaderValue("application/json"));
        //    // 發出 post 並取得結果
        //    HttpResponseMessage response = client.DeleteAsync("UserData/" + atr).GetAwaiter().GetResult();
        //    if (!response.IsSuccessStatusCode)
        //    {
        //        string err = await response.Content.ReadAsStringAsync();
        //        return err;
        //    }
        //    else
        //    {
        //        return "scuess";
        //    }
        //}
    }
}
