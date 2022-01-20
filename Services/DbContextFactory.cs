using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Modules;

namespace WebApi.Services
{
    public static class DbContextFactory
    {
        public static Dictionary<string, string> ConnectionStrings { get; set; }

        public static void SetConnectionString(Dictionary<string, string> connStrs)
        {
            ConnectionStrings = connStrs;
        }

        public static izdbDataModelSyncContext CreateClinic(string connid, izdbWebCenterContext centraldb)
        {
            string connStr;
            try
            {
                connStr = ConnectionStrings[connid];
            }
            catch
            {
                var mDatabase = centraldb.Mdatabases.ToList();
                if (mDatabase != null)
                {
                    //add DB By U 04/02/2019
                    Dictionary<string, string> connStrs = new Dictionary<string, string>();
                    foreach (var item in mDatabase)
                    {
                        connStrs.Add(item.DatabaseId, item.ConnectionString);
                    }
                    SetConnectionString(connStrs);
                    //end
                }
            }

            if (!string.IsNullOrEmpty(connid))
            {
                connStr = ConnectionStrings[connid];
                var optionsBuilder = new DbContextOptionsBuilder<izdbDataModelSyncContext>();
                optionsBuilder.UseSqlServer(IzpalCryptography.DecrypString(connStr, IzpalCryptography.IZPAL_KEY));
                return new izdbDataModelSyncContext(optionsBuilder.Options);
            }
            else
            {
                return null;
            }
        }
    }
}