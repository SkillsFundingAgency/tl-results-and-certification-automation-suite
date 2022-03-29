using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class CancelRommOutcomePage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-cancel-ROMM-update";
    private static string PageTitle { get; } = "Cancel ROMM update - Post-results – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Cancel ROMM update - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Are you sure you want to cancel the update to this ROMM?";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By YesCancelRadio = By.Id("areyousuretocancel");
    private static readonly By NoCancelRadio = By.Id("areyousuretocancel-no");
    private static readonly By ContinueBtn = By.Id("continueButton");

    protected static void VerifyCancelRommOutcomePage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
    }
    protected static void VerifyCancelRommOutcomeErrorPage()
    {
        Assert.AreEqual(PageErrorTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    protected static void CheckNoCancelRadio()
    {
        ClickElement(NoCancelRadio);
        ClickButton(ContinueBtn);
        CheckRommOutcomePage.VerifyCheckRommOutcomePage();
    }
    protected static void CheckYesCancelRadio()
    {
        ClickElement(YesCancelRadio);
        ClickButton(ContinueBtn);
        PostResultsLearnerDetailsPage.VerifyPostResultsLearnerDetailsPage();
    }

    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
}