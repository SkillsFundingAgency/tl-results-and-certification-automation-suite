using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5891_ChangeTheGradeAfterAppealCoreStepDefinitions : ChangeTheGradeAfterAppealPage
{
    private readonly ScenarioContext _scenarioContext;

    public _5891_ChangeTheGradeAfterAppealCoreStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    [Given(@"I have a registration with appeal recorded")]
    public void GivenIHaveARegistrationWithAppealRecorded()
    {
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationCityAndGuilds.RegWithAppealRecord(uln);
    }
    [Given(@"I select ""([^""]*)"" in appeal outcome page")]
    [When(@"I select ""([^""]*)"" in appeal outcome page")]
    public void WhenISelectInAppealOutcomePage(string option)
    {
        AddAppealOutcomePage.AddAppealOutcomeOptions(option);
    }

    [Then(@"change the grade after appeal page is shown")]
    public void ThenChangeTheGradeAfterAppealPageIsShown()
    {
        VerifyChangeTheGradeAfterAppealPage();
    }
    [Then(@"core deails shown on change the grade after appeal page")]
    public void ThenCoreDeailsShownOnChangeTheGradeAfterAppealPage()
    {
        VerifyLearnerCoreDetailsChangeGradeAfterAppealPage();
    }

    [Then(@"back link takes me to add an appeal outcome page")]
    public void ThenBackLinkTakesMeToAddAnAppealOutcomePage()
    {
        BackLinkToAddAppealOutcomePage();
    }
    [Then(@"error message shown on change grade after appeal page")]
    public void ThenErrorMessageShownOnChangeGradeAfterAppealPage(Table table)
    {
        VerifyChangeTheGradeAfterAppealErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"error summary shown on change grade after appeal page")]
    public void ThenErrorSummaryShownOnChangeGradeAfterAppealPage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }
    [Then(@"back link takes me to do you know the appeal outcome page")]
    public void ThenBackLinkTakesMeToDoYouKnowTheAppealOutcomePage()
    {
        BackLinkToDoYouKnowAppealOutcomePage();
    }
    [Then(@"specialism deails shown on change the grade after appeal page")]
    public void ThenSpecialismDeailsShownOnChangeTheGradeAfterAppealPage()
    {
        VerifyLearnerOsDetailsChangeGradeAfterAppealPage();
    }

}