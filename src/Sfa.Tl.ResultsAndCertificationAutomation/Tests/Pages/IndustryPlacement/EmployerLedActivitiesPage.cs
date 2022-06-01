using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class EmployerLedActivitiesPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-temporary-flexibility-employer-led";
    private static string PageTitle { get; } = "Employer-led activities or projects - Temporary flexibility - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Employer-led activities or projects - Temporary flexibility - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");

    private static readonly By RadioYes = By.Id("isemployerledused");
    private static readonly By RadioNo = By.Id("isemployerledused-no");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By backLink = By.Id("backLink");
 



    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
   
    public static void VerifyEmployerLedActivitiesPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Did " + LearnerName + " use the employer-led activities/projects temporary flexibility?";
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }
    protected static void VerifyErrorEmployerLedActivitiesPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void ClickRadioButton(string optionName)
    {
        switch (optionName)
        {
            case "Yes":
                ClickElement(RadioYes);
                ClickButton(ContinueBtn);
                break;
     
            case "No":
                ClickElement(RadioNo);
                ClickButton(ContinueBtn);
                break;
        }
    }

}