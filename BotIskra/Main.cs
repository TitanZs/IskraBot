using Microsoft.Extensions.Configuration;
using System;

namespace BotIskra
{
    public static class Main
    {
        public static IConfiguration Configuration { get; private set; }
        public static bool Init()
        {
            try
            {
                
                Configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .Build();
                return true;
            }
            catch
            {
                return false;
            }   
        }
    }
}
