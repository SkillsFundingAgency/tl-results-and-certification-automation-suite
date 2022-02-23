using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries;

[Binding]
public class Tlrc4764CannotAddSpecialismEntryWhenPreviousEntryHasNoGradeSteps : LearnerResultsPage
{
    private readonly ScenarioContext _scenarioContext;
    public Tlrc4764CannotAddSpecialismEntryWhenPreviousEntryHasNoGradeSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }


    [Given(@"I have a registration with Specialism assessment series added for previous assessment year with no grade")]
    public void GivenIHaveARegistrationWithSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithNoGrade()
    {
        var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationCityAndGuilds.RegWithResitSpecialismAssessment(uln, summer2021SpecialismAssessSeriesId);
    }

    [Given(@"I have a registration with couplet specialism assessment series added for previous assessment year with no grade")]
    public void GivenIHaveARegistrationWithCoupletSpecialismAssessmentSeriesAddedForPreviousAssessmentYearWithNoGrade()
    {
        var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationCityAndGuilds.RegWithResitCoupletSpecialismAssessment(uln, summer2021SpecialismAssessSeriesId);
    }



    [Given(@"I navigate to the Learner's Assessment Entries page")]
    public void GivenINavigateToTheLearnersAssessmentEntriesPage()
    {
        var uln = _scenarioContext["uln"] as string;
        ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
        ClickElement(AssessmentEntriesPage.SearchForLearnerLink);
        AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
        AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
    
    }

    [Then(@"the user will be notified that they must add a result to this learner's previous assessment before entering new assessment details")]
    public void ThenTheUserWillBeNotifiedThatTheyMustAddAResultToThisLearnersPreviousAssessmentBeforeEnteringNewAssessmentDetails()
    {
       VerifyCountOfAddResultToPreviousSpecialismLinksDsplayed(1);
    }

    [Then(@"the user will be notified that they must add a result to both of this learner's previous specialism assessment before entering new assessment details")]
    public void ThenTheUserWillBeNotifiedThatTheyMustAddAResultToBothOfThisLearnersPreviousSpecialismAssessmentBeforeEnteringNewAssessmentDetails()
    {
        VerifyCountOfAddResultToPreviousSpecialismLinksDsplayed(2);
    }

    [When(@"the user adds a result to both the previous specialism assessment entry")]
    public void WhenTheUserAddsAResultToBothThePreviousSpecialismAssessmentEntries()
    {
        ClickAddResultToPreviousSpecialism();
        //using core add link because we are clicking 1st instance of Add link (typically this would be core but no core available here)
        LearnerResultsPage.AddAssessmentLink("Core add result");
        AddSpecialismResultPage.SelectGrade("Grade Distinction");
        AddSpecialismResultPage.pressSubmitButton();
        //using core add link because we are clicking 1st instance of Add link (typically this would be core but no core available here and no 1st specialism because a grade was just added to it.)
        LearnerResultsPage.AddAssessmentLink("Core add result");
        AddSpecialismResultPage.SelectGrade("Grade Distinction");
        AddSpecialismResultPage.pressSubmitButton();
        AddSpecialismResultPage.pressHomeBreadcrumb();
        var uln = _scenarioContext["uln"] as string;
        AssessmentEntriesPage.ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
        AssessmentEntriesPage.ClickElement(AssessmentEntriesPage.SearchForLearnerLink);
        AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
        AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
    }

    [When(@"the user adds a result to the previous specialism assessment entry")]
    public void WhenTheUserAddsAResultToThePreviousSpecialismAssessmentEntry()
    {
        ClickAddResultToPreviousSpecialism();
        //using core add link because we are clicking 1st instance of Add link (typically this would be core but no core available here)
        LearnerResultsPage.AddAssessmentLink("Core add result");
        AddSpecialismResultPage.SelectGrade("Grade Distinction");
        AddSpecialismResultPage.pressSubmitButton();
        //using core add link because we are clicking 1st instance of Add link (typically this would be core but no core available here and no 1st specialism because a grade was just added to it.)
        AddSpecialismResultPage.pressHomeBreadcrumb();
        var uln = _scenarioContext["uln"] as string;
        AssessmentEntriesPage.ClickElement(AssessmentEntriesPage.AssessmentEntriesLink);
        AssessmentEntriesPage.ClickElement(AssessmentEntriesPage.SearchForLearnerLink);
        AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
        AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
    }




    [Then(@"the user will be able to add the current specialism assessment entry")]
    public void ThenTheUserWillBeAbleToAddTheCurrentSpecialismAssessmentEntry()
    {
        VerifyAddResultToPreviousSpecialismLinksNotDisplayed();
    }

    [Given(@"I have a registration with couplet specialism assessment series without result added for previous assessment year with no grade")]
    public void GivenIHaveARegistrationWithCoupletSpecialismAssessmentSeriesWithoutResultAddedForPreviousAssessmentYearWithNoGrade()
    {
        var summer2021SpecialismAssessSeriesId = SqlQueries.InsertSummer2021SpecialismAssessSeries();
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationCityAndGuilds.RegWithResitCoupletSpecialismAssessmentWithoutResult(uln, summer2021SpecialismAssessSeriesId);
    }


    [Given(@"I have a registration with couplet specialism assessment series and a core assessment with no grade")]
    public void GivenIHaveARegistrationWithCoupletSpecialismAssessmentSeriesAndACoreAssessmentWithNoGrade()
    {
        var uln = UlnHelper.GenerateUln().ToString();
        _scenarioContext["uln"] = uln;
        RegistrationCityAndGuilds.RegWithCoreAndSpecialismAssessment(uln);
    }


}