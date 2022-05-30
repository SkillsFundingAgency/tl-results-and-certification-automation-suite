using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class AnyOtherIndustryPlacementModelsPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-other-models";
    private static string PageTitle { get; } = "Other models - Industry placement - Manage learner – Manage T Level results – GOV.UK";
 
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By CheckboxRelevantPartTimeWork = By.Id("otherplacement");
    private static readonly By CheckboxOnsiteSENDStudents = By.Id("otherplacement-1");
    private static readonly By CheckboxOnsiteYoungPeople = By.Id("otherplacement-2");
    private static readonly By CheckboxRouteLevelPlacements = By.Id("otherplacement-3");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By backLink = By.Id("backLink");
 



    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifyAnyOtherIndustryPlacementModelsPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Did " + LearnerName + " use any other industry placement models?";
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void ClickCheckBox(string optionName)
    {
        switch (optionName)
        {
            case "Relevant part-time work":
                ClickElement(CheckboxRelevantPartTimeWork);
                ClickButton(ContinueBtn);
                break;
            case "On-site facilities for SEND students":
                ClickElement(CheckboxOnsiteSENDStudents);
                ClickButton(ContinueBtn);
                break;
            case "On-site facilities for young people in young offender institutions":
                ClickElement(CheckboxOnsiteYoungPeople);
                ClickButton(ContinueBtn);
                break;
            case "Route-level placements":
                ClickElement(CheckboxRouteLevelPlacements);
                ClickButton(ContinueBtn);
                break;
            
        }
    }

}