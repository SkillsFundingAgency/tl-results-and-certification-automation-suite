using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers;

[Binding]
public class _6545_WhichIpModelsWereUsedStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    public _6545_WhichIpModelsWereUsedStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    [Given(@"I have registration for Education and Childcare without maths English and Ip")]
    public void GivenIHaveRegistrationForEducationAndChildcareWithoutMathsEnglishAndIp()
    {
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationsForSoa.RegistrationForEducationChildCare(uln);
    }

    [Given(@"I select '([^']*)' radio in was Ip model used page")]
    public void GivenISelectRadioInWasIpModelUsedPage(string p0)
    {
        throw new PendingStepException();
    }

    [When(@"I select '([^']*)' in multiple employer model page")]
    public void WhenISelectInMultipleEmployerModelPage(string p0)
    {
        throw new PendingStepException();
    }

    [Then(@"the following radio options seen on which Ip models used by page")]
    public void ThenTheFollowingRadioOptionsSeenOnWhichIpModelsUsedByPage(Table table)
    {
        throw new PendingStepException();
    }
}