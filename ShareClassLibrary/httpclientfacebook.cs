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
        public static HttpClient client = new HttpClient() { BaseAddress = new Uri("https://userdatawebapi20220829195800.azurewebsites.net/") };
        public static async Task<List<string>> Get()
        {
            try
            {
                return await client.GetFromJsonAsync<List<string>>("Image");
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
            }
            catch
            {
                return null;
            }
        }
        public static async Task<List<string>> frcview(string language)
        {
            try
            {
                return await client.GetFromJsonAsync<List<string>>($"Image/frcview/{language}");
            }
            catch
            {
                return null;
            }
        }
        public static async Task<string> teamview(string language)
        {
            try
            {
                return await client.GetStringAsync($"Image/teamview/{language}");
            }
            catch
            {
                return null;
            }
        }
    }
}
