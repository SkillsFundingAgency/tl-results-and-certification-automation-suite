﻿using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class PostResultsLearnerDetailsPage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-learners-grades";
    private static string PageTitle { get; } = "Learner’s grades - Post-results – Manage T Level results – GOV.UK";
    private static By SearchAgainBtn { get; } = By.Id("buttonSearchAgain");

    protected static void VerifyPostResultsLearnerDetailsPage()
    {
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
    private static void ClickCoreAddRomm()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add ROMM')]"));
        element[0].Click();
    }
    private static void ClickAssessment1AddRomm()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add ROMM')]"));
        element[1].Click();
    }

    private static void ClickAssessment2AddRomm()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add ROMM')]"));
        element[2].Click();
    }
    protected static void AddRommBtn(string buttonName)
    {
        switch (buttonName)
        {
            case "Add core ROMM":
                ClickCoreAddRomm();
                break;
            case "Add specialism1 ROMM":
                ClickAssessment1AddRomm();
                break;
            case "Add specialism2 ROMM":
                ClickAssessment2AddRomm();
                break;
        }
    }
    protected static void VerifyCountOfAddRommButtons()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add ROMM')]"));
        var count = element.Count;
        Assert.AreEqual(3, count);
    }

    protected static void ClickSearchAgainBtn()
    {
        ClickButton(SearchAgainBtn);
    }
}