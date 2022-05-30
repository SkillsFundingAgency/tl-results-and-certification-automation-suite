using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class CheckYourAnswersPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-check-your-answers";
    private static string PageTitle { get; } = "Check your answers - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Check your answers";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By SubmitBtn = By.XPath("//*[@id='main-content']//button");
    private static readonly By backLink = By.Id("backLink");
    private static readonly By IPStatusChangeLink = By.Id("ipstatus");
    private static readonly By IPModelsUsedChangeLink = By.Id("isipmodelused");
    private static readonly By MultipleEmployerModelsChangeLink = By.Id("ismultiempmodel");
    private static readonly By SelectedIModelsPChangeLink = By.Id("selectedplacementmodellist");
    private static readonly By TempFlexibilitiesChangeLink = By.Id("istempflexused");
    private static readonly By BlendedChangeLink = By.Id("isblendedplacementused");
    private static readonly By EmployerLedActivitiesChangeLink = By.Id("anyothertempflexlist");
    private static readonly By SelectedTempFlexibilitiesChangeLink = By.Id("tempflexusedlist");


    protected static void ClickSubmitBtn() => ClickButton(SubmitBtn);
    public static void ClickBackLink() => ClickButton(backLink);

    public static void VerifyCheckYourAnswersPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
       
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void ClickChangeLink(string ChangeLink)
    {
        switch (ChangeLink)
        {
            case "Industry placement status":
                ClickElement(IPStatusChangeLink);
                break;

            case "Industry placement models used":
                ClickElement(IPModelsUsedChangeLink);
                 break;

            case "Multiple employer model used":
                ClickElement(MultipleEmployerModelsChangeLink);
                break;

            case "Selected industry placement models":
                ClickElement(SelectedIModelsPChangeLink);
                break;

            case "Temporary flexibilities used":
                ClickElement(TempFlexibilitiesChangeLink);
                break;

            case "Blended placement temporary flexibility used":
                ClickElement(BlendedChangeLink);
                break;

            case "Employer-led activities/projects temporary flexibility used":
                ClickElement(EmployerLedActivitiesChangeLink);
                break;

            case "Selected temporary flexibilities":
                ClickElement(SelectedTempFlexibilitiesChangeLink);
                break;

        }
    }

}