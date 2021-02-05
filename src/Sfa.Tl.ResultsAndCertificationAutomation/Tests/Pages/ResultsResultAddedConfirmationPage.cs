using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ResultsResultAddedConfirmationPage : ElementHelper
    {
        private static readonly string PageUrl = string.Concat(StartPage.StartPageUrl, "result-added-confirmation");
        private static readonly string PageTitle = "Result added confirmation page – Manage T Level results – GOV.UK";
        
        public static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        public static readonly string ExpectedPageHeaderText = "Result added successfully";
        public static By BackToLearnersResultsButton { get; } = By.Id("backToResultsButton");
        public static readonly string ExpectedButtonText = "Back to learner’s results";
        public static By SubHeader { get; } = By.XPath("//*[contains(text(),'ULN')]");
     


        public static new void ClickButton(By locator)
        {
            WebDriver.FindElement((locator)).Click();
        }
        public static void VerifyResultAddeddConfirmationPage(string ULN)
        {
            string SubHeaderText = "ULN: " + ULN;
           
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(ExpectedPageHeaderText));
            Assert.AreEqual(SubHeaderText, WebDriver.FindElement(SubHeader).Text);
            Assert.IsTrue(WebDriver.FindElement(BackToLearnersResultsButton).Text.Contains(ExpectedButtonText));
        }

        public static void ClickBackToLearnersResultsButton()
        {
           ClickElement(BackToLearnersResultsButton);
        }

    }
}
