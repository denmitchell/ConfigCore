﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigApi_ApiKey.Models
{
    public class DataFactory
    {
        public static List<ConfigEntity> GetSettingList()
        {
            return new List<ConfigEntity>()
        {
            new ConfigEntity(){Id=1,AppId="ConfigApiClient_ApiKey",SettingKey="Setting1",SettingValue="Setting 1 - Api Configuration Client with API Key Authorization"},
            new ConfigEntity(){Id=2,AppId="ConfigApiClient_ApiKey",SettingKey="Setting2",SettingValue="Setting 2 - Api Configuration Client with API Key Authorization"},
            new ConfigEntity(){Id=3,AppId="ConfigApiClient_ApiKey",SettingKey="Setting3",SettingValue="Setting 3 - Api Configuration Client with API Key Authorization"},
            new ConfigEntity(){Id=4,AppId="ConfigApiClient_ApiKey",SettingKey="Setting4",SettingValue="Setting 4 - Api Configuration Client with API Key Authorization"},
            new ConfigEntity(){Id=5,AppId="ConfigApiClient_ApiKey",SettingKey="Setting5",SettingValue="Setting 5 - Api Configuration Client with API Key Authorization"}
        };

        }
    }
}
