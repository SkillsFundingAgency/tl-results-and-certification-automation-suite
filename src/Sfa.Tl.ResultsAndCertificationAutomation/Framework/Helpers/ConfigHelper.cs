using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class ConfigHelper
    {
        private static IConfigurationRoot _config;

        private static IConfigurationRoot Config
        {
            get
            {
                if (_config != null) return _config;
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true);

                _config = builder.Build();

                return _config;
            }
        }

        public static bool GetHeadless()
        {
            bool.TryParse(Config["Headless"], out var result);
            return result;
        }


        public static string GetWebDriver()
        {
            return Config["WebDriver"];
        }

        public static string GetBrowser()
        {
            return Config["Browser"];
        }

        public static string GetDownloadFolder()
        {
            return Config["DownloadFolder"];
        }

        public static string GetAppInsightsInstrumentationKey()
        {
            return Config["APPINSIGHTS_INSTRUMENTATIONKEY"];
        }

        public static string GetAOAdminUser()
        {
            return Config["AOAdminUser"];
        }

        public static string GetAOAllUser()
        {
            return Config["AOAllUser"];
        }

        public static string GetBaseUrl()
        {
            return Config["BaseUrl"];
        }

        public static string GetAPRevProUser()
        {
            return Config["APRevProUser"];
        }

        public static string GetAOReviewer()
        {
            return Config["AOReviewer"];
        }

        public static string GetAOProviderEditor()
        {
            return Config["AOProviderEditor"];
        }

        public static string GetAOPassword()
        {
            return Config["AOPassword"];
        }

        public static string GetDBConnectionString()
        {
           return Config["DBConnectionString"];
        }

        public static string GetPearsonAdminUser()
        {
           return Config["PearsonAdminUser"];
        }

        public static string GetAORegistrationEditor()
        {
           return Config["AORegistrationEditor"];
        }

        public static string GetAONoRole()
        {
           return Config["AONoRole"];
        }

        public static string GetAONoService()
        {
           return Config["AONoService"];
        }
    }
}