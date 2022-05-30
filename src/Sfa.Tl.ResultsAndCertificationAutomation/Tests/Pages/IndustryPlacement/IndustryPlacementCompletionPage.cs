using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class IndustryPlacementCompletionPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-completion";
    private static string PageTitle { get; } = "Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Industry placement completion - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
    private static readonly By RadioYes = By.Id("industryplacementstatus");
    private static readonly By RadioYesCWSC = By.Id("industryplacementstatus-cwspc");
    private static readonly By RadioNo = By.Id("appealoutcome-withdraw");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By backLink = By.Id("backLink");
 



    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
    public static void ClickBackLink() => ClickButton(backLink);
    public static void VerifyIndustryPlacementCompletionPage(string ULN)
    {
        string LearnerName = SqlQueries.GetLearnerName(ULN);
        string ExpectedHeader = "Has " + LearnerName + " completed their industry placement?";
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ExpectedHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }
    protected static void VerifyErrorIndustryPlacementCompletionPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }   

    public static void ClickRadioButton(string optionName)
    {
        switch (optionName)
        {
            case "Yes, completed":
                ClickElement(RadioYes);
                ClickButton(ContinueBtn);
                break;
            case "Yes, completed with special consideration":
                ClickElement(RadioYesCWSC);
                ClickButton(ContinueBtn);
                break;
            case "No, still to be completed":
                ClickElement(RadioNo);
                ClickButton(ContinueBtn);
                break;
        }
    }

}