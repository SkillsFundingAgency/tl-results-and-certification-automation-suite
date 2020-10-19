using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ReregisterCheckAndSubmitPage : ReregisterHasLearnerDecidePage
    {
        private static string ExpectedCheckAndSubmitPageTitle { get; } = "Register learner on a new course - Check and submit page – Manage T Level results – GOV.UK";
        private static string ExpectedCheckAndSubmitPageHeader { get; } = "Check and submit";
        private static string ExpectedCheckAndSubmitUrl { get; } = "register-learner-new-course-check-and-submit";
        public static By ChangeBtn { get; } = By.Id("submitButton");
        public static By ContinueBtn { get; } = By.Id("continueButton");
        public static By ChangeProvider { get; } = By.Id("provider");
        public static By ChangeCore { get; } = By.Id("core");
        public static By ChangeSpecialism { get; } = By.Id("specialisms");
        public static By ChangeAcademicYear { get; } = By.Id("academicyear");
        private static readonly string ExpectedUln = "9900000001";
        private static readonly string ExpectedProvider = "Automation Test3 (99999903)";
        private static readonly string ExpectedCore = "Agriculture, Environmental and Animal Care (77777777)";
        public static readonly string ExpectedSpecialism = "Animal Care and Management (70000001)";
        public static readonly string ExpectedSpecialism2 = "Agriculture, Land Management and Production (70000002)";
        private static readonly string ExpectedProviderValue = "99999903";
        private static readonly string ExpectedCoreValue = "77777777";
        public static readonly string ChangeAnotherProvider = "Automation Test4 (99999904)";
        public static By SubmitButton { get; } = By.XPath("//*[@id='main-content']//p[2]/button");

        private static By SelectProvider { get; } = By.Id("selectedproviderukprn");
        private static By SelectCore { get; } = By.Id("selectedcorecode");

        public static void VerifyReregisterCheckAndSubmitPage()
        {
            Assert.AreEqual(ExpectedCheckAndSubmitPageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedCheckAndSubmitPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedCheckAndSubmitUrl));
        }

        public static void VerifyReregisterData()
        {
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(ExpectedUln));
            RegistrationsSearchPage.VerifyProvider(ExpectedProvider);
            RegistrationsSearchPage.VerifyCore(ExpectedCore);
            RegistrationsSearchPage.VerifySpecialism(ExpectedSpecialism);
        }
        public static void VerifyReregisterChangeLinks()
        {
            Assert.AreEqual(true, WebDriver.FindElement(ChangeProvider).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ChangeCore).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ChangeSpecialism).Displayed);
            Assert.AreEqual(true, WebDriver.FindElement(ChangeAcademicYear).Displayed);
        }
        public static void VerifyChangeProviderValue()
        {
            SelectElement selectElement = new SelectElement(WebDriver.FindElement(SelectProvider));
            string selectedValue = selectElement.SelectedOption.GetAttribute("value");
            Assert.AreEqual(ExpectedProviderValue, selectedValue);
        }
        public static void VerifyChangeCoreValue()
        {
            SelectElement selectElement = new SelectElement(WebDriver.FindElement(SelectCore));
            string selectedValue = selectElement.SelectedOption.GetAttribute("value");
            Assert.AreEqual(ExpectedCoreValue, selectedValue);
        }
        public static void VerifyChangeCoreDefaultValue()
        {
            SelectElement selectElement = new SelectElement(WebDriver.FindElement(SelectCore));
            string selectedValue = selectElement.SelectedOption.GetAttribute("value");
            Assert.AreEqual("", selectedValue);
        }

        public static void VerifyUpdatedReregisterData()
        {

            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(Constants.ManualRegULN));
            RegistrationsSearchPage.VerifyProvider(Constants.ManualRegUpdatedProvider);
            RegistrationsSearchPage.VerifyCore(Constants.ManualRegUpdatedCore);
            RegistrationsSearchPage.VerifySpecialism(Constants.ManualRegUpdatedSpecialism);
            //RegistrationsSearchPage.VerifyAcademicYearChangePage();
        }

        public static void ClickSubmitButton()
        {
            ClickElement(SubmitButton);
        }


    }
}
