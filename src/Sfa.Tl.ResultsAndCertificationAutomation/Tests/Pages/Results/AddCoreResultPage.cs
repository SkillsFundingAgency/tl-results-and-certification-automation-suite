using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;

public class AddCoreResultPage : ElementHelper
{
    private static string PageUrl { get; } = "select-core-result";
    private static string PageTitle { get; } = "Select core result – Manage T Level results – GOV.UK";
    private static string ErrorPageTitle { get; } = "Error: Select core result – Manage T Level results – GOV.UK";
    private static By SelectGradeAStar { get; } = By.Id("selectedgradecode");
    private static By SelectGradeA { get; } = By.Id("selectedgradecode-1");
    private static By SelectGradeB { get; } = By.Id("selectedgradecode-2");
    private static By SelectGradeC { get; } = By.Id("selectedgradecode-3");
    private static By SelectGradeD { get; } = By.Id("selectedgradecode-4");
    private static By SelectGradeE { get; } = By.Id("selectedgradecode-5");
    private static By SelectGradeUnclassified { get; } = By.Id("selectedgradecode-6");
    private static By SelectGradeNotReceived { get; } = By.Id("selectedgradecode-7");

    public static void VerifyLearnerCoreResultsPage()
    {
        Assert.AreEqual(PageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }
    public static void VerifyLearnerCoreResultsErrorPage()
    {
        Assert.AreEqual(ErrorPageTitle, WebDriver.Title);
        Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
    }

    public static void VerifyAddGradesUnchecked()
    {
        Assert.False(WebDriver.FindElement(SelectGradeAStar).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeA).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeB).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeC).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeD).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeE).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeUnclassified).Selected);
    }
    public static void VerifyChangeGradesUnchecked()
    {
        Assert.False(WebDriver.FindElement(SelectGradeAStar).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeA).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeB).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeC).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeD).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeE).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeUnclassified).Selected);
        Assert.False(WebDriver.FindElement(SelectGradeNotReceived).Selected);
    }

    public static void SelectGrade(string grade)
    {
        switch (grade)
        {
            case "Grade A*" :
                ClickElement(SelectGradeAStar);
                break;
            case "Grade A":
                ClickElement((SelectGradeA));
                break;
            case "Grade B":
                ClickElement(SelectGradeB);
                break;
            case "Grade C":
                ClickElement(SelectGradeC);
                break;
            case "Grade D":
                ClickElement(SelectGradeD);
                break;
            case "Grade E":
                ClickElement(SelectGradeE);
                break;
            case "Grade Unclassified":
                ClickElement(SelectGradeUnclassified);
                break;
            case "Grade not received":
                ClickElement(SelectGradeNotReceived);
                break;
            case "Grade Distinction":
                ClickElement(SelectGradeAStar);
                break;
            case "Grade Merit":
                ClickElement((SelectGradeA));
                break;
            case "Grade PAss":
                ClickElement(SelectGradeB);
                break;
            case "Unclassified":
                ClickElement(SelectGradeC);
                break;
        }
    }
    public static void ClickBackLink()
    {
        ClickElement(WebDriver.FindElement(By.Id("backLink")));
    }
}