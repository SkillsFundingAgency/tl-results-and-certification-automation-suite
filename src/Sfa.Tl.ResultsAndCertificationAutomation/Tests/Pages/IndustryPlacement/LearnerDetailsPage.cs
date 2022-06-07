using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;

public class LearnerDetailsPage : ElementHelper
{
    private static string PageUrl { get; } = "learner-record-page";
    private static string PageTitle { get; } = "Learner T Level record page – Manage T Level results – GOV.UK";
    
    private static By LearnerName = By.XPath("//*[@class='record-header']");
    private static By AddMathsLink = By.Id("mathsstatus");
    private static By AddEnglishLink = By.Id("englishstatus");
    private static By AddIpLink = By.Id("industryplacement");
    private static By AddIpFromBanner = By.LinkText("Add industry placement details");
    private static By AddMathsFromBanner = By.LinkText("Add maths level details");
    private static By AddEnglishFromBanner = By.LinkText("Add English level details");
    private static By backToListOfLearnersBtn = By.Id("backToLearnersListButton");
    private static By backToHomeBtn = By.Id("backToHomeButton");
    private static By SuccessBanner = By.XPath("//*[@id='main-content']//h3");
    private static By BackLink = By.Id("backLink");
    private static By LearnerDetails = By.XPath("//*[@id='main-content']/div/div/dl[1]");

    public static void VerifyLearnerRecordPage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void VerifyLearnerDetails(string uln)
    {
       // Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("Jonny Walker"));
       // Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("ULN: " + uln));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("Barnsley College"));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("10000536"));
    }

    public static void VerifySuccessBanner()
    {
        Assert.IsTrue(WebDriver.FindElement(SuccessBanner).Text.Contains("Industry placement status added"));       
    }

    public static void VerifyAddIPLinkNotPresent()
    {
        bool IPLinkPresent = IsPresent(AddIpLink);
        bool ExpectedIPLinkPresence = false;
        Assert.AreEqual(ExpectedIPLinkPresence, IPLinkPresent);
    }
    public static void VerifyAddIPLinkIsPresent()
    {
        bool IPLinkPresent = IsPresent(AddIpLink);
        bool ExpectedIPLinkPresence = true;
        Assert.AreEqual(ExpectedIPLinkPresence, IPLinkPresent);
    }

    

    public static void VerifyLearnerDetailsForAgricultureAndAnimalCare()
    {
        Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("01 January 2001"));
        Assert.IsTrue(WebDriver.FindElement(LearnerDetails).Text.Contains("Barnsley College"));

    }
    public static void AddEmip(string status)
    {
        switch (status)
        {
            case "Add English":
                ClickElement(AddEnglishLink);
                break;
            case "Add maths":
                ClickElement((AddMathsLink));
                break;
            case "Add Ip":
                ClickElement(AddIpLink);
                break;
            case "Add English link":
                ClickElement(AddEnglishFromBanner);
                break;
            case "Add maths link":
                ClickElement(AddMathsFromBanner);
                break;
            case "Add Ip link":
                ClickElement(AddIpFromBanner);
                break;
        }
    }

    public static void ClickBackLink()
    {
        ClickElement(BackLink);

    }

    public static void ClickBackToListOfLearners()
    {
        ClickElement(backToListOfLearnersBtn);
    }

    public static void ClickBackToHome()
    {
        ClickElement(backToHomeBtn);
    }

    //public static void NavigateLearnerDetailsPage(string uln)
    //{
    //    ClickLinkByLabel("Manage learner records");
    //    SearchLearnerPage.SearchUln(uln);
    //    VerifyLearnerRecordPage();
    //}
}