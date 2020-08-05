using System.Configuration;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;
        private readonly string _browser;
        private readonly string _baseUrl;
        private readonly string _dfESignInUrl;
        private readonly string _dfeUserName;
        private readonly string _dfePassword;

        private Configurator()
        {
            _browser = ConfigurationManager.AppSettings["Browser"];
            _baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            _dfESignInUrl = ConfigurationManager.AppSettings["DfESignInUrl"];
            _dfeUserName = ConfigurationManager.AppSettings["DfEUserName"];
            _dfePassword = ConfigurationManager.AppSettings["DfEPassword"];
        }

        public static Configurator GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new Configurator();
            }

            return configuratorInstance;
        }

        public string GetBrowser()
        {
            return _browser;
        }

        public string GetBaseUrl()
        {
            return _baseUrl;
        }

        public string GetDfESignInUrl()
        {
            return _dfESignInUrl;
        }

        public string GetDfEUserName()
        {
            return _dfeUserName;
        }

        public string GetDfEPassword()
        {
            return _dfePassword;
        }

        public string DfeSigninUrl()
        {
            var dfeSignInUrl = ConfigurationManager.AppSettings["DfESignInUrl"];
            return dfeSignInUrl;
        }
    }
}
