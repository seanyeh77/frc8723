using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ShareClassLibrary
{
    public class httpclientfacebook
    {
        //public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7021/") };
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://userdatawebapi20220502202651.azurewebsites.net/") };
        public static async Task<List<string>> Get()
        {
            try
            {
                return await client.GetFromJsonAsync<List<string>>("Image");

                //return result;
            }
            catch
            {
                return null;
            }
        }
        public static async Task<string> Geticon()
        {
            try
            {
                return await client.GetStringAsync("Image/icon");

                //return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static async Task<List<string>> Getteamimg()
        {
            try
            {
                return await client.GetFromJsonAsync<List<string>>("Image/teamimg");

                //return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
