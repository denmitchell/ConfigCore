﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigApi_Certificate.Models
{
    public class DataFactory
    {
        public static List<ConfigEntity> GetSettingList()
        {
            return new List<ConfigEntity>()
        {
            new ConfigEntity(){Id=1,AppId="ConfigApiClient_Certificate",SettingKey="Setting1",SettingValue="Setting 1 - Value for ConfigApiClient_Certificate"},
            new ConfigEntity(){Id=2,AppId="ConfigApiClient_Certificate",SettingKey="Setting2",SettingValue="Setting 2 - Value for ConfigApiClient_Certificate"},
            new ConfigEntity(){Id=3,AppId="ConfigApiClient_Certificate",SettingKey="Setting3",SettingValue="Setting 3 - Value for ConfigApiClient_Certificate"},
            new ConfigEntity(){Id=4,AppId="ConfigApiClient_Certificate",SettingKey="Setting4",SettingValue="Setting 4 - Value for ConfigApiClient_Certificate"},
            new ConfigEntity(){Id=5,AppId="ConfigApiClient_Certificate",SettingKey="Setting5",SettingValue="Setting 5 - Value for ConfigApiClient_Certificate"}
        };

        }
    }
}
