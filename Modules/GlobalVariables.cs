using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace WebApi.Modules
{
    public class GlobalVariables
    {
        private static IHttpContextAccessor _httpContextAccessor;
        public static readonly string AppHost = "https://admin.izpalapp.com";
        public static readonly string AppOwnCloud = "https://vettale.izpalstorage.com";
        public static readonly string DemoOwnCloud = "https://ssl.vettale.link";
        public static readonly string URLRegisterLink = "https://app.vettale.com/account/generateregisterlink";

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        /// URL เข้าถึงการกระทำระดับ Users
        public static string OwnCloudURLUsers
        {
            get
            {
                if (_httpContextAccessor != null && _httpContextAccessor.HttpContext != null)
                {
                    if (_httpContextAccessor.HttpContext.Request.Headers[HeaderNames.Origin].ToString() == AppHost)
                    {
                        return AppOwnCloud + "/ocs/v1.php/cloud/users";
                    }
                    else
                    {
                        return DemoOwnCloud + "/ocs/v1.php/cloud/users";
                    }
                }
                else
                {
                    return "";
                }
            }
        }

        public static string DefaultPassword = "Izpal1234";
    }
}