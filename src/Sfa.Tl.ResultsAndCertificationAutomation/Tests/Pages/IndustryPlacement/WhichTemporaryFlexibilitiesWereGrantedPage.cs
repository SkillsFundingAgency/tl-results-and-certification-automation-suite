using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class WhichTemporaryFlexibilitiesWereGrantedPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-temporary-flexibilities";
    private static string PageTitle { get; } = "Temporary flexibilities - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Temporary flexibilities - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By CheckboxJABQGRiskRatedApproach = By.Id("istempflexibilityselected");
    private static readonly By CheckboxReductionInHours = By.Id("istempflexibilityselected-1");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By backLink = By.Id("backLink");
    public static string ExpectedErrorMessage = "Select one or more temporary flexibilities";
    public static By MainErrorMsg = By.XPath("//*[@id='main-content']//div[1]//div[1]//ul/li/a");
    public static By SubErrorMsg = By.XPath("//*[@id='main-content']//div[2]//span");


    public static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifyWhichTemporaryFlexibilitiesWereGrantedPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Which temporary flexibilities were granted to " + LearnerName + "?";
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void VerifyErrorWhichTemporaryFlexibilitiesWereGrantedPage()
    {
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.IsTrue(WebDriver.FindElement(MainErrorMsg).Text.Contains(ExpectedErrorMessage));
        Assert.IsTrue(WebDriver.FindElement(SubErrorMsg).Text.Contains(ExpectedErrorMessage));
    }

    public static void ClickCheckBox(string optionName)
    {
        switch (optionName)
        {
            case "JABQG risk-rated approach":
                ClickElement(CheckboxJABQGRiskRatedApproach);
                ClickButton(ContinueBtn);
                break;
            case "Reduction in hours":
                ClickElement(CheckboxReductionInHours);
                ClickButton(ContinueBtn);
                break;            
        }
    }

}