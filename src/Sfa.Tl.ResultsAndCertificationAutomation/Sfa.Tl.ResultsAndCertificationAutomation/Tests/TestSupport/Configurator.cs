using System.Configuration;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;
        private string _browser;
        private string _baseUrl;
        private string _dfESignInUrl;
        private string _dfeUserName;
        private string _dfePassword;

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

        public string dfeSigninUrl()
        {
            var dfeSignInUrl = ConfigurationManager.AppSettings["DfESignInUrl"];
            return dfeSignInUrl;
        }
    }
}
