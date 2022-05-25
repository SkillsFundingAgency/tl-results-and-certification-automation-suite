using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;

public class WasMultipleEmployerUsedPage : ElementHelper
{
    private static string PageUrl { get; } = "industry-placement-multiple-employer-model";
    private static string PageTitle { get; } = "Multiple employer model - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Multiple employer model - Industry placement - Manage learner – Manage T Level results – GOV.UK";
    private static readonly By MultipleEmployerYes = By.Id("ismultiemployermodelused");
    private static readonly By MultipleEmployerNo = By.Id("ismultiemployermodelused-no");
    private static readonly By ContinueBtn = By.Id("continueButton");

    protected static void VerifyMultipleEmployerUsedPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageTitle, WebDriver.Title);
    }
    protected static void VerifyMultipleEmployerUsedErrorPage()
    {
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
    }

    public static void SelectMultipleEmployerOption(string option)
    {
        switch (option)
        {
            case "Yes, Multiple employer used":
                ClickElement(MultipleEmployerYes);
                ClickButton(ContinueBtn);
                break;
            case "No, Multiple employer used":
                ClickElement(MultipleEmployerNo);
                ClickButton(ContinueBtn);
                break;
        }
    }
    protected static void VerifyBackLink()
    {
        ClickElement(By.Id("backLink"));
        WasIpModelUsedPage.VerifyWasIpModelUsedPage();
    }
}