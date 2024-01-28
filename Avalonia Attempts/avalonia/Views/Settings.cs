using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedApp.Views
{

    public class Settings
    {
        private IConfigurationSection pair;
        public String[] LoadSettings()
        { 
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appdata.json")
                .Build();

            pair = config.GetSection("Settings");

            String username = pair["username"], hashed_password = pair["hashed_password"];

            if (username == null || hashed_password == null) return ["cuh", ""];
            return [username, hashed_password];
        }
    }
}
