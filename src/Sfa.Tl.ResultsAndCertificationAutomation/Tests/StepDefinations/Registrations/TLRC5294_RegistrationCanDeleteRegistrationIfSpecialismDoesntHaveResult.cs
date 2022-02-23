using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries;

[Binding]
public class TLRC5294_RegistrationCanDeleteRegistrationIfSpecialismDoesntHaveResult : ElementHelper
{
    private readonly ScenarioContext _scenarioContext;
    public TLRC5294_RegistrationCanDeleteRegistrationIfSpecialismDoesntHaveResult(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }


    [Given(@"I navigate to the Are you sure you want to delete this registration permanently\? page and click Yes, delete this registration")]
    public void GivenINavigateToTheAreYouSureYouWantToDeleteThisRegistrationPermanentlyPageAndClickYesDeleteThisRegistration()
    {
        var uln = _scenarioContext["uln"] as string;
        TlevelDashboardPage.ClickRegistrationsLink();
        RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
        
        RegistrationsSearchPage.SearchForULN(uln);
        RegistrationsSearchPage.VerifySearchResultPage();
        ClickElement(RegistrationReactivate.ChangeStatusLink);
        ClickElement(RegistrationDeletePage.DeleteRadioBtn);
        ClickElement(RegistrationDeletePage.ContinueBtn);
        ClickElement(RegistrationDeletePage.DeleteYesRadio);
        ClickElement(RegistrationDeletePage.SubmitBtn);

    }

    [Given(@"I navigate to the What would you like to with this active registration\? page and click Continue")]
    public void GivenINavigateToTheWhatWouldYouLikeToWithThisActiveRegistrationPageAndClickContinue()
    {
        var uln = _scenarioContext["uln"] as string;
        TlevelDashboardPage.ClickRegistrationsLink();
        RegistrationsPage.ClickElement(RegistrationsSearchPage.SearchRegistrationLink);

        RegistrationsSearchPage.SearchForULN(uln);
        RegistrationsSearchPage.VerifySearchResultPage();
        ClickElement(RegistrationReactivate.ChangeStatusLink);
        ClickElement(RegistrationDeletePage.DeleteRadioBtn);
        ClickElement(RegistrationDeletePage.ContinueBtn);
    }


}