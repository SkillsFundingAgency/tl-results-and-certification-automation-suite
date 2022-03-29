using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5750_CheckTheRommOutcomePageStepDefinitions : CheckRommOutcomePage
{
    [Then(@"check the ROMM outcome page is shown")]
    public void ThenCheckTheROMMOutcomePageIsShown()
    {
        VerifyCheckRommOutcomePage();
    }

    [Then(@"back link takes me to add ROMM outcome page")]
    public void ThenBackLinkTakesMeToAddROMMOutcomePage()
    {
        BackLinkToAddRommOutcomePage();
    }
    [Then(@"specialism details shown in check the Romm oucome page")]
    public void ThenSpecialismDetailsShownInCheckTheRommOucomePage()
    {
        VerifyLearnerOs1DetailsAdddRommOutcomePage();
    }

}