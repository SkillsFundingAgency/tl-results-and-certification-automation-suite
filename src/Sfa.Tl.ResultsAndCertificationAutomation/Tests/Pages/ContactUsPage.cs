using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ContactUsPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "contact-us");
        private static readonly string PageTitle = "Contact us page – Manage T Level results – GOV.UK";

        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static readonly string ExpectedPageHeaderText = "Contact us";

        private static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static readonly string ExpectedHomeBreadcrumbText = "Home";
        private static By ContactBreadCrumb { get; } = By.Id("breadcrumb1");
        private static readonly string ExpectedContactBreadcrumbText = "Contact us";



        public static void VerifyContactUsPage(string ExpectedH1Text)
        {
            Assert.AreEqual(PageUrl,WebDriver.Url);
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedH1Text, WebDriver.FindElement(PageHeader).Text);
            
        }

        public static void VerifyContactUsPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
        }


        public static void VerifyBreadcrumbs()
        {
            Assert.AreEqual(ExpectedHomeBreadcrumbText, WebDriver.FindElement(HomeBreadcrumb).Text);
            Assert.AreEqual(ExpectedContactBreadcrumbText, WebDriver.FindElement(ContactBreadCrumb).Text);
        }

        public static void VerifyBreadcrumbsNotPresent()
        {
            bool BCPresent = IsPresent(HomeBreadcrumb);
            bool ExpectedBCPresence = false;
            Assert.AreEqual(ExpectedBCPresence, BCPresent);
        }

        public static void ClickHomeBreadcrumb()
        {
            ElementHelper.ClickElement(HomeBreadcrumb);
        }
    }
}
