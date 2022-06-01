using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class IndustryPlacementModelsUsedPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-models";
    private static string PageTitle { get; } = "Industry placement models - Manage learner – Manage T Level results – GOV.UK";
    private static string errorPageTitle { get; } = "Error: Industry placement models - Industry placement - Manage learner – Manage T Level results – GOV.UK";

    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By CheckboxRelevantPartTimeWork = By.Id("isipmodelselected");
    private static readonly By CheckboxOnsiteSENDStudents = By.Id("isipmodelselected-1");
    private static readonly By CheckboxOnsiteYoungPeople = By.Id("isipmodelselected-2");
    private static readonly By CheckboxRouteLevelPlacements = By.Id("isipmodelselected-3");
    private static readonly By CheckboxUseOfSkillsHubs = By.Id("isipmodelselected-5");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By backLink = By.Id("backLink");
 



    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifyIndustryPlacementModelsUsedPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Which industry placement models were used by " + LearnerName + "?";
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));

    }

    public static void VerifyErrorIndustryPlacementModelsUsedPage()
    {
        Assert.AreEqual(errorPageTitle, WebDriver.Title);
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
            case "Use of skills hubs or employer training centres":
                ClickElement(CheckboxUseOfSkillsHubs);
                ClickButton(ContinueBtn);
                break;
        }
    }

}