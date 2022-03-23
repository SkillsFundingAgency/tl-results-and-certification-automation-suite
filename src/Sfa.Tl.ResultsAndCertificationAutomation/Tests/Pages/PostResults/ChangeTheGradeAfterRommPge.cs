using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class ChangeTheGradeAfterRommPge : ElementHelper
{
    private static string PageUrl { get; } = "post-results-romm-change-grade";
    private static string PageTitle { get; } = "ROMM grade change - Post-results – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: ROMM grade change - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Change the grade after a ROMM";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
    private static By SelectGradeAStar { get; } = By.Id("selectedgradecode");
    private static By SelectGradeA { get; } = By.Id("selectedgradecode-1");
    private static By SelectGradeB { get; } = By.Id("selectedgradecode-2");
    private static By SelectGradeC { get; } = By.Id("selectedgradecode-3");
    private static By SelectGradeD { get; } = By.Id("selectedgradecode-4");
    private static By SelectGradeE { get; } = By.Id("selectedgradecode-5");
    private static By SelectGradeUnclassified { get; } = By.Id("selectedgradecode-6");
    private static By ContinueBtn { get; } = By.Id("continueButton");

    protected static void VerifyChangeTheGradeAfterRommPage()
    {
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader,WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void VerifyChangeTheGradeAfterRommErrorPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
    public static void SelectRommGrade(string grade)
    {
        switch (grade)
        {
            case "Grade A*":
                ClickElement(SelectGradeAStar);
                ClickButton(ContinueBtn);
                break;
            case "Grade A":
                ClickElement((SelectGradeA));
                ClickButton(ContinueBtn);
                break;
            case "Grade B":
                ClickElement(SelectGradeB);
                ClickButton(ContinueBtn);
                break;
            case "Grade C":
                ClickElement(SelectGradeC);
                ClickButton(ContinueBtn);
                break;
            case "Grade D":
                ClickElement(SelectGradeD);
                ClickButton(ContinueBtn);
                break;
            case "Grade E":
                ClickElement(SelectGradeE);
                ClickButton(ContinueBtn);
                break;
            case "Grade Unclassified":
                ClickElement(SelectGradeUnclassified);
                ClickButton(ContinueBtn);
                break;
        }
    }
    protected static void VerifyLearnerOs1DetailsChangeGradeAfterRommPage()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbOs1Component));
    }
}