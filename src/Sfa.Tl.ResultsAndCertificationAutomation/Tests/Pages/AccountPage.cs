using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class AccountPage : ElementHelper
    {
        private readonly By AccountLink = By.XPath("//a[contains(text(),'Account')]");
        private const string ExpectedUrl = "https://pp-profile.signin.education.gov.uk/";
        private readonly By PageTitle = By.TagName("h1");
        private const string PageHeader = "Profile";

        public void ClickAccountLink()
        {
            ClickElement(AccountLink);
        }

        public void VarifyProfilePage()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(ExpectedUrl, WebDriver.Url);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageTitle).Text);
        }
    }
}
