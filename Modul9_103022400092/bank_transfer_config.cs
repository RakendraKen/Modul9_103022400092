using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400092
{
    internal class bank_transfer_config
    {
        public config Config;
        private const string configFilePath = "bank_transfer_config.json";

        public bank_transfer_config()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception ex)
            {
                SetDefault();
                writeNewConfig();
            }
        }
        private void ReadConfigFile()
        {
            string jsonString = System.IO.File.ReadAllText(configFilePath);
            Config = JsonSerializer.Deserialize<config>(jsonString);
        }
        private void SetDefault()
        {
            Config = new config
            {
                lang = "en",
                transfer = new transfer
                {
                    thereshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000
                },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmations = new confirmations
                {
                    en = "yes",
                    id = "ya"
                }
            };
        }
        private void writeNewConfig()
        {
            string jsonString = JsonSerializer.Serialize(Config, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(configFilePath, jsonString);
        }
    }


}
