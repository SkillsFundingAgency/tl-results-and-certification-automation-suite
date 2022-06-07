using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class IndustryPlacementSpecialConsiderationReasonsPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-special-consideration-reasons";
    private static string PageTitle { get; } = "Special consideration reasons - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Special consideration reasons - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By CheckboxLearnersMedicalReason = By.Id("isreasonselected");
    private static readonly By CheckboxLearnersFamilyMedicalReason = By.Id("isreasonselected-1");
    private static readonly By CheckboxBereavement = By.Id("isreasonselected-2");
    private static readonly By CheckboxDomesticCrisis = By.Id("isreasonselected-3");
    private static readonly By CheckboxTrauma = By.Id("isreasonselected-4");
    private static readonly By CheckboxAlternativePriorities = By.Id("isreasonselected-5");
    private static readonly By CheckboxUnsafePlacement= By.Id("isreasonselected-6");
    private static readonly By CheckboxPlacementWithdrawn = By.Id("isreasonselected-7");
    private static readonly By CheckboxCovid = By.Id("isreasonselected-8");
    private static readonly By ContinueBtn = By.Id("ContinueButton");
    private static readonly By backLink = By.Id("backLink");
    public static string ExpectedErrorMessage = "Select one or more reasons for granting special consideration";
    public static By MainErrorMsg = By.XPath("//*[@id='main-content']//div[1]//div[1]//ul/li/a");
    public static By SubErrorMsg = By.XPath("//*[@id='main-content']//div[2]//span");




    public static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifyIndustryPlacementSpecialConsiderationReasonsPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Why was " + LearnerName + " granted special consideration for their industry placement?";
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
    public static void VerifyErrorIndustryPlacementSpecialConsiderationReasonsPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.IsTrue(WebDriver.FindElement(MainErrorMsg).Text.Contains(ExpectedErrorMessage));
      //Assert.IsTrue(WebDriver.FindElement(SubErrorMsg).Text.Contains(ExpectedErrorMessage));
    }   

    public static void ClickCheckBox(string optionName)
    {
        switch (optionName)
        {
            case "Learner's medical reasons":
                ClickElement(CheckboxLearnersMedicalReason);
                ClickButton(ContinueBtn);
                break;
            case "Learner's family medical reasons":
                ClickElement(CheckboxLearnersFamilyMedicalReason);
                ClickButton(ContinueBtn);
                break;
            case "Bereavement":
                ClickElement(CheckboxBereavement);
                ClickButton(ContinueBtn);
                break;
            case "Domestic crisis":
                ClickElement(CheckboxDomesticCrisis);
                ClickButton(ContinueBtn);
                break;
            case "Trauma or significant change of circumstances":
                ClickElement(CheckboxTrauma);
                ClickButton(ContinueBtn);
                break;
            case "Alternative priorities: Sport, training or other competitions":
                ClickElement(CheckboxAlternativePriorities);
                ClickButton(ContinueBtn);
                break;
            case "Unsafe placement":
                ClickElement(CheckboxAlternativePriorities);
                ClickButton(ContinueBtn);
                break;
            case "Placement withdrawn":
                ClickElement(CheckboxPlacementWithdrawn);
                ClickButton(ContinueBtn);
                break;
            case "COVID-19":
                ClickElement(CheckboxCovid);
                ClickButton(ContinueBtn);
                break;
        }
    }

}