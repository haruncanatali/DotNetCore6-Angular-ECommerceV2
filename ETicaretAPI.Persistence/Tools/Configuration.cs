using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence.Tools
{
    public static class Configuration
    {
        public static string GetDbConnectionString
        {
            get
            {
                ConfigurationManager cManager = new();
                cManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ETicaretAPI.API"));
                cManager.AddJsonFile("appsettings.json");

                return cManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
