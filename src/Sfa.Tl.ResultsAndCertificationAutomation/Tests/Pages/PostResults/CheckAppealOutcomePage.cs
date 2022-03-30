using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class CheckAppealOutcomePage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-appeal-check";
    private static string PageTitle { get; } = "Check appeal outcome - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Check the appeal outcome";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
    private static readonly By BackLink = By.Id("backLink");
    private static readonly By SubmitBtn = By.Id("submitButton");
    public static void ClickSubmitBtn() => ClickButton(SubmitBtn);
    public static void VerifyCheckAppealOutcomePage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }
    protected static void BackLinkToChangeTheGradeAfterAppealPage()
    {
        ClickElement(BackLink);
        ChangeTheGradeAfterAppealPage.VerifyChangeTheGradeAfterAppealPage();
    }
    protected static void BackLinkToAddAppealOutcomePage()
    {
        ClickElement(BackLink);
        AddAppealOutcomePage.VerifyAddAppealOutcomePage();
    }
    protected static void VerifyLearnerCoreDetailsCheckAppealOutcomePage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
    }
    protected static void VerifyLearnerOs1DetailsCheckAppealOutcomePage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
    }
}