using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;

public class AddRommPage : ElementHelper
{
    private static string PageUrl { get; } = "post-results-add-romm";
    private static string PageTitle { get; } = "Add a ROMM - Post-results – Manage T Level results – GOV.UK";
    private static string PageErrorTitle { get; } = "Error: Add a ROMM - Post-results – Manage T Level results – GOV.UK";
    private static string PageHeader { get; } = "Add a ROMM";
    private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
    private static readonly By RadioBtnYes = By.Id("rommrequested");
    private static readonly By RadioBtnNo = By.Id("rommrequested-no");
    private static readonly By ContinueBtn = By.Id("continueButton");
    private static readonly By BackLink = By.Id("backLink");

    protected static void ClickBackLink() => ClickElement(BackLink);
    protected static void ClickContinueBtn() => ClickButton(ContinueBtn);

    public static void VerifyAddRommPage()
    {
        Assert.AreEqual(PageTitle,WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        Assert.AreEqual(PageHeader,WebDriver.FindElement(PageHeaderElement).Text);
    }

    protected static void VerifyAddRommErrorPage()
    {
        Assert.AreEqual(PageErrorTitle,WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
    protected static void AddRommBtn(string buttonName)
    {
        switch (buttonName)
        {
            case "Yes, request Romm":
                ClickElement(RadioBtnYes);
                ClickButton(ContinueBtn);
                break;
            case "No, request Romm":
                ClickElement(RadioBtnNo);
                ClickButton(ContinueBtn);
                break;
        }
    }
}