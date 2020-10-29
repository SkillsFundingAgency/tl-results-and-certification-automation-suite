using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository
{
    public class CommonObjects : ElementHelper
    {
        public static By BreadcrumbHome = By.Id("breadcrumb0");
        private static By BreadcrumbMain = By.Id("breadcrumb1");
    }
}
