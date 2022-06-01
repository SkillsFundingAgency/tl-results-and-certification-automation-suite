using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class SpecialConsiderationHoursPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-special-consideration-hours";
    private static string PageTitle { get; } = "Special consideration hours - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Special consideration hours - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By TextBoxHours = By.Id("hours");   
    private static readonly By ContinueBtn = By.Id("ContinueButton");
    private static readonly By backLink = By.Id("backLink");
 



    public static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifySpecialConsiderationHoursPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "How many industry placement hours did " + LearnerName + " complete?";
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
     
    }
    protected static void VerifyErrorSpecialConsiderationHoursPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void EnterHours(string Hours)
    {
        WebDriver.FindElement(TextBoxHours).SendKeys(Hours);
        WebDriver.FindElement(ContinueBtn).Click();
    }

}