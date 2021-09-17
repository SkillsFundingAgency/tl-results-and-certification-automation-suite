using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ContactUsPage : ElementHelper
    {
        private static readonly string PageURL = string.Concat(StartPage.StartPageUrl, "contact-us");
        private static readonly string PageTitle = "Contact us page – Manage T Level results – GOV.UK";

        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static string ExpectedPageHeaderText = "Contact us";
        public static By SubPageHeader { get; } = By.XPath("//*[@id='main-content']//h2");
        public static readonly string ExpectedSubHeaderText = "Discussion forum";
        
        public static By HomeBreadcrumb { get; } = By.Id("breadcrumb0");
        public static readonly string ExpectedHomeBreadcrumbText = "Home";
        public static By ContactBreadCrumb { get; } = By.Id("breadcrumb1");
        public static readonly string ExpectedContactBreadcrumbText = "Contact us";

        public static By DiscussionLink { get; } = By.XPath("//*[@id='main-content']//p[3]/a");
        public static readonly string ExpectedDiscussionLink = WebDriver.FindElement(DiscussionLink).GetAttribute("href");


        public static void VerifyContactUsPage(string ExpectedH1Text)
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageURL));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedH1Text, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSubHeaderText, WebDriver.FindElement(SubPageHeader).Text);
            
        }

        public static void VerifyContactUsPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(PageURL));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeaderText, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedSubHeaderText, WebDriver.FindElement(SubPageHeader).Text);
        }

        public static void SupportLink()
        {
         Assert.AreEqual(ExpectedDiscussionLink, "https://support.tlevels.gov.uk/hc/en-gb/community/posts");
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
