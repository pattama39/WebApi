using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using WebApi.Services;

namespace WebApi.Modules
{
    public class GlobalFunctions
    {
        private static IHttpContextAccessor _httpContextAccessor;

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public static string GetConnection()
        {
            var jwtToken = _httpContextAccessor.HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            try
            {
                return IzpalCryptography.DecodeJWTToken(jwtToken, true);
            }
            catch
            {
                var databaseId = _httpContextAccessor.HttpContext.Session.GetString(ModSession.CURRENTDATABASEID_SESSION);
                var connStr = DbContextFactory.ConnectionStrings[databaseId];
                return IzpalCryptography.DecrypString(connStr, IzpalCryptography.IZPAL_KEY);
            }
        }

        // OwnCloud 
        public static string BasicAuthorization(string username, string password)
        {
            string userpassEncode;
            var plainTextBytes = Encoding.UTF8.GetBytes(username + ":" + password);
            userpassEncode = Convert.ToBase64String(plainTextBytes);
            return "Basic " + userpassEncode;
        }

        public static async Task<string> OwnCloudADMIN(string pURL = "", string pMethod = "GET")
        {
            string URL = GlobalVariables.OwnCloudURLUsers + pURL;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Headers.Add("Authorization", BasicAuthorization("admin", GlobalVariables.DefaultPassword));
            request.Method = pMethod;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "application/x-www-form-urlencoded";

            try
            {
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                var responseString = await readStream.ReadToEndAsync();
                response.Close();
                readStream.Close();
                return responseString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<XmlNodeList> GetOwnCloudStorage(string pHospitalCode)
        {
            var result = await OwnCloudADMIN("/" + pHospitalCode);
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(result);
                var nodes = xmlDoc.SelectNodes("ocs/data/quota");
                return nodes;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return null;
            }
        }

        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public static async Task<string> GetSMSBalance(string user, string pass)
        {
            string URL = "http://api.ants.co.th/account/1/balance";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Accept = "application/json";
            request.Headers.Add("Authorization", BasicAuthorization(user, pass));
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                var responseString = await readStream.ReadToEndAsync();
                return responseString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}