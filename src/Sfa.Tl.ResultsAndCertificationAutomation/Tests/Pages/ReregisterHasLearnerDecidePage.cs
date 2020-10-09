using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ReregisterHasLearnerDecidePage : ElementHelper
    {
        private static string ExpectedPageTitle { get; } = "Register learner on a new course - Has the learner decided on the specialism page – Manage T Level results – GOV.UK";
        private static string ExpectedPageHeader { get; } = "Has the learner decided on the specialism?";
        private static readonly string ExpectedUrl = "register-learner-new-course-has-learner-decided-specialism";
        public static By AddSpecialismNow { get; } = By.Id("haslearnerdecidedspecialism");
        public static By AddSpecialismLater { get; } = By.Id("specialismdecided-no");
        private static By ContinueBtn = By.XPath("//button[contains(text(),'Continue')]");
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string SelectProvider = "Automation Test3 (99999903)";
        private static string SelectCore = "Agriculture, Environmental and Animal Care (77777777)";
        private static string ExpectedSelectedCore { get; } = "77777777";
        private static string ErrorMsg { get; } = "Select yes if the learner has decided on the specialism";
        private static By ErrorElement { get; } = By.XPath("//a[@href='#haslearnerdecidedspecialism']");
        private static string ExpectedErrorPageTitle { get; } = "Error: Register learner on a new course - Has the learner decided on the specialism page – Manage T Level results – GOV.UK";
        private static By SelectedCore { get; } = By.Id("selectedcorecode");
        private static string ExpectedCorePageTitle { get; } = "Register learner on a new course - Select the core page – Manage T Level results – GOV.UK";
        private static string ExpectedCorePageUrl { get; } = "register-learner-new-course-select-core";
        public static By Backlink { get; } = By.Id("backLink");
        public static void ClickContinueBtn()
        {
            ClickButton(ContinueBtn);
        }

        public static void VerifyReregisterLearnerDecidePage()
        {
            Assert.AreEqual(ExpectedPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedUrl));
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
        public static void CheckRadioOptionsReregisterLearnerDecide()
        {
            Assert.AreEqual(false, WebDriver.FindElement(AddSpecialismNow).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(AddSpecialismLater).Selected);
        }

        public static void SelectProviderAndCore()
        {
            RegistrationsManualPage.SelectProviderFromList(SelectProvider);
            ClickContinueBtn();
            RegistrationsManualPage.SelectCoreFromList(SelectCore);
            ClickContinueBtn();
        }
        public static void VerifyReregisterLearnerDecideErrorPage()
        {
            Assert.AreEqual(ExpectedErrorPageTitle, WebDriver.Title);
            Assert.AreEqual(ErrorMsg, WebDriver.FindElement(ErrorElement).Text);
        }
        public static void VerifyReregisterCorePage()
        {
            SelectElement selectElement = new SelectElement(WebDriver.FindElement(SelectedCore));
            string selectedValue = selectElement.SelectedOption.GetAttribute("value");
            Assert.AreEqual(ExpectedSelectedCore, selectedValue);
            Assert.AreEqual(ExpectedCorePageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(ExpectedCorePageUrl));
            Assert.AreEqual("Select the core", WebDriver.FindElement(PageHeader).Text);
        }
    }
}
