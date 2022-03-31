using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class AddAppealOutcomePage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-add-appeal-outcome";
    private static string PageTitle { get; } = "Appeal outcome - Post-results – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Appeal outcome - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Add an appeal outcome";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
    private static readonly By RadioNoGradeChange = By.Id("appealoutcome");
    private static readonly By RadioGradeChanged = By.Id("appealoutcome-gradechanged");
    private static readonly By RadioAppealWithdrawn = By.Id("appealoutcome-withdraw");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By BackLink = By.Id("backLink");
    private static readonly By SubmitBtn = By.Id("submitButton");
    public static void ClickSubmitBtn() => ClickButton(SubmitBtn);
    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void VerifyAddAppealOutcomePage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }
    protected static void VerifyAddAppealOutcomeErrorPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void AddAppealOutcomeOptions(string optionName)
    {
        switch (optionName)
        {
            case "No change to grade":
                ClickElement(RadioNoGradeChange);
                ClickButton(ContinueBtn);
                break;
            case "The grade has changed":
                ClickElement(RadioGradeChanged);
                ClickButton(ContinueBtn);
                break;
            case "Appeal withdrawn":
                ClickElement(RadioAppealWithdrawn);
                ClickButton(ContinueBtn);
                break;
        }
    }
    protected static void VerifyLearnerCoreDetailsAddAppealOutcomePage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbCoreComponent));
    }
    protected static void VerifyLearnerOs1DetailsAddAppealOutcomePage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbOs1Component));
    }
}