using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class WasIpModelUsedPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-model-used";
    private static string PageTitle { get; } = "Industry placement model - Manage learner - Manage T Levels service - GOV.UK – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Industry placement model - Manage learner - Manage T Levels service - GOV.UK – Manage T Level results – GOV.UK";
    private static readonly By IpModelUsedYes = By.Id("isipmodelused");
    private static readonly By IpModelUsedNo = By.Id("isipmodelused-no");
    private static readonly By ContinueBtn = By.Id("continueButton");

    public static void VerifyWasIpModelUsedPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageTitle, WebDriver.Title);
    }
    protected static void VerifyWasIpModelUsedErrorPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
    }

    public static void SelectIpModelOption(string option)
    {
        switch (option)
        {
            case "Yes, Ip model used":
                ClickElement(IpModelUsedYes);
                ClickButton(ContinueBtn);
                break;
            case "No, Ip model used":
                ClickElement(IpModelUsedNo);
                ClickButton(ContinueBtn);
                break;
        }
    }

    public static void ClickContinue() => ClickButton(ContinueBtn);
}