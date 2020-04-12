using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AccountPage : ElementHelper
    {
        private By AccountLink = By.XPath("//a[contains(text(),'Account')]");
        private const string ExpectedUrl = "https://pp-profile.signin.education.gov.uk/";
        private By PageTitle = By.TagName("h1");
        private const string PageHeader = "Profile";

        public void ClickAccountLink()
        {
            ClickElement(AccountLink);
        }

        public void VarifyProfilePage()
        {
            Assert.AreEqual(ExpectedUrl, WebDriver.Url);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageTitle).Text);
        }
    }
}
