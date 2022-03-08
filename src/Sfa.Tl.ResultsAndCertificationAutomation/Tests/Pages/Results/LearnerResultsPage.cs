using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;

public class LearnerResultsPage : ElementHelper
{
    private static string PageUrl { get; } = "learner-results";
    private static string PageTitle { get; } = "Learner's results – Manage T Level results – GOV.UK";
    private static By AddCoreAssessment { get; } = By.Id(("addCoreAssessmentLink"));
    private static By AddSpecialismAssessment { get; } = By.Id(("addSpecialismAssessmentLink"));
    private static By SuccessBanner { get; } = By.XPath("//*[@id='main-content']//h2");
    private static By SuccessMessage { get; } = By.XPath("//*[@id='main-content']//h3");

    private static By AddResultToPreviousSpecialismLink { get; } =
        By.XPath("//*[contains (text(),'add a result to this learner')]");

    protected static void VerifyLearnerResultsPage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    protected static void AddAssessmentLink(string linkName)
    {
        switch (linkName)
        {
            case "Add core assessment":
                ClickElement(AddCoreAssessment);
                break;
            case "Add specialism assessment":
                ClickElement(AddSpecialismAssessment);
                break;
            case "Core add result":
                ClickCoreAddResult();
                break;
            case "Specialism1 add result":
                ClickAssessment1AddResult();
                break;
            case "Specialism2 add result":
                ClickAssessment2AddResult();
                break;
            case "Core change result":
                ClickCoreChangeResult();
                break;
            case "Specialism1 change result":
                ClickAssessment1ChangeResult();
                break;
            case "Specialism2 change result":
                ClickAssessment2ChangeResult();
                break;
        }
    }

    private static void ClickCoreAddResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
        element[0].Click();
    }

    private static void ClickAssessment1AddResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
        element[1].Click();
    }

    private static void ClickAssessment2AddResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
        element[2].Click();
    }

    private static void ClickCoreChangeResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Change')]"));
        element[0].Click();
    }

    private static void ClickAssessment1ChangeResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Change')]"));
        element[1].Click();
    }

    private static void ClickAssessment2ChangeResult()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Change')]"));
        element[2].Click();
    }

    protected static void VerifyBanner(string message)
    {
        Assert.AreEqual("Success", WebDriver.FindElement(SuccessBanner).Text);
        Assert.IsTrue(WebDriver.FindElement(SuccessMessage).Text.Contains(message));
    }

    protected static void VerifyCountOfAddResultToPreviousSpecialismLinksDsplayed(int countOfLinksDisplayed)
    {
        IList<IWebElement> element =
            WebDriver.FindElements(By.XPath("//*[contains(text(),'add a result to this learner')]"));
        var count = element.Count;
        Assert.AreEqual(countOfLinksDisplayed, count);
    }

    protected static void ClickAddResultToPreviousSpecialism()
    {
        ClickElement(AddResultToPreviousSpecialismLink);
    }

    protected static void VerifyAddResultToPreviousSpecialismLinksNotDisplayed()
    {
        var notPresent = IsPresent(AddResultToPreviousSpecialismLink);
        Assert.AreEqual(false, notPresent);
    }
}