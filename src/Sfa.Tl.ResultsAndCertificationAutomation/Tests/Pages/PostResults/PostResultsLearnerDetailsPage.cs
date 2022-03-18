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
    private static readonly By SuccessBannerElement = By.XPath("//*[@id='main-content']//h2");
    private static readonly By MessageHeaderElement = By.XPath("//*[@id='main-content']//h3");
    private static readonly By CoreAddOutcomeBtn = By.XPath("//a[contains(text(), 'Add outcome')][1]");
    private static readonly By CoreAddRommBtn = By.XPath("//a[contains(text(), 'Add ROMM')][1]");
    private static readonly By CoreAddAppealBtn = By.XPath("//a[contains(text(), 'Add appeal')][1]");

    public static void VerifyPostResultsLearnerDetailsPage()
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
    private static void ClickCoreAddRommOutcome()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add outcome')]"));
        element[0].Click();
    }
    private static void ClickAssessment1AddRommOutcome()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add outcome')]"));
        element[1].Click();
    }

    private static void ClickAssessment2AddRommOutcome()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add outcome')]"));
        element[2].Click();
    }
    private static void ClickCoreAddAppeal()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add appeal')]"));
        element[0].Click();
    }
    private static void ClickAssessment1AddAppeal()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add appeal')]"));
        element[1].Click();
    }

    private static void ClickAssessment2AddAppeal()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add appeal')]"));
        element[2].Click();
    }
    private static void ClickCoreRequestChange()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Request change')]"));
        element[0].Click();
    }
    private static void ClickAssessment1RequestChange()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Request change')]"));
        element[1].Click();
    }

    private static void ClickAssessment2RequestChange()
    {
        IList<IWebElement> element = WebDriver.FindElements(By.XPath("//*[contains(text(),'Request change')]"));
        element[2].Click();
    }
    public static void AddRommBtn(string buttonName)
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
            case "Add core outcome":
                ClickCoreAddRommOutcome();
                break;
            case "Add specialism1 outcome":
                ClickAssessment1AddRommOutcome();
                break;
            case "Add specialism2 outcome":
                ClickAssessment2AddRommOutcome();
                break;
            case "Add core appeal":
                ClickCoreAddAppeal();
                break;
            case "Add specialism1 appeal":
                ClickAssessment1AddAppeal();
                break;
            case "Add specialism2 appeal":
                ClickAssessment2AddAppeal();
                break;
            case "Core request change":
                ClickCoreRequestChange();
                break;
            case "Specialism1 request change":
                ClickAssessment1RequestChange();
                break;
            case "Specialism2 request change":
                ClickAssessment2RequestChange();
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

    protected static void VerifyRommAddedSuccessfully()
    {
        Assert.AreEqual("Success",WebDriver.FindElement(SuccessBannerElement).Text);
        Assert.AreEqual("ROMM recorded",WebDriver.FindElement(MessageHeaderElement).Text);
    }
    protected static void VerifyRommWithdrawnSuccessfully()
    {
        Assert.AreEqual("Success", WebDriver.FindElement(SuccessBannerElement).Text);
        Assert.AreEqual("ROMM withdrawn", WebDriver.FindElement(MessageHeaderElement).Text);
    }
    protected static void VerifyRommOutcomeRecordedSuccessfully()
    {
        Assert.AreEqual("Success", WebDriver.FindElement(SuccessBannerElement).Text);
        Assert.AreEqual("ROMM outcome recorded", WebDriver.FindElement(MessageHeaderElement).Text);
    }

    protected static void IsCoreAddOutcomeBtnVisible()
    {
        IsPresent(CoreAddOutcomeBtn);
    }
    protected static void IsCoreAdRommBtnVisible()
    {
        IsPresent(CoreAddRommBtn);
    }
    protected static void IsCoreAddAppealBtnVisible()
    {
        IsPresent(CoreAddAppealBtn);
    }
}