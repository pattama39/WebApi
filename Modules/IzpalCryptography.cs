using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Modules
{
    public class IzpalCryptography
    {
        public const string IZPAL_KEY = "IzpalCorp";
        private static izdbWebCenterContext _centerdb;

        public static void Configure(izdbWebCenterContext centerdb)
        {
            _centerdb = centerdb;
        }

        public static string DecrypString(string str, string Key)
        {
            AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(Key);
            provider.Key = ResizeBytesArray(bytes, provider.Key.Length);
            provider.IV = ResizeBytesArray(bytes, provider.IV.Length);
            MemoryStream stream2 = new MemoryStream(Convert.FromBase64String(str));
            ICryptoTransform transform = provider.CreateDecryptor();
            CryptoStream stream = new CryptoStream(stream2, transform, CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string str3 = reader.ReadToEnd();

            reader.Close();
            reader.Dispose();

            stream.Close();
            stream.Dispose();

            stream2.Close();
            stream2.Dispose();

            return str3;
        }

        private static byte[] ResizeBytesArray(byte[] bytes, int newSize)
        {
            byte[] buffer = new byte[newSize];
            if (bytes.Length <= newSize)
            {
                int num4 = bytes.Length - 1;
                int j = 0;
                do
                {
                    buffer[j] = bytes[j];
                    j += 1;
                } while (j <= num4);
                return buffer;
            }

            int index = 0;
            int num5 = bytes.Length - 1;
            int i = 0;
            do
            {
                buffer[index] = (byte)((buffer[index] ^ bytes[i]));
                index += 1;
                if (index >= buffer.Length)
                {
                    index = 0;
                }
                i++;
            } while (i <= num5);

            return buffer;
        }

        public static string DecodeJWTToken(string jwtToken, bool isConnStr)
        {
            if (isConnStr == true)
            {
                var handler = new JwtSecurityTokenHandler();
                var tokenS = handler.ReadToken(jwtToken) as JwtSecurityToken;
                var databaseId = tokenS.Claims.First(claim => claim.Type == "database_id").Value;

                var connStr = DbContextFactory.ConnectionStrings[databaseId];
                return DecrypString(connStr, IZPAL_KEY);
            } else
            {
                return "";
            }
        }
    }
}