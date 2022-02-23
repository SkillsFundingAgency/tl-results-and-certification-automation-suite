using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5488_TransferResultsBulkuploadStepDefinitions : ResultsDashboardPage
    {
        [Given(@"I have below registration with core and specialism assessments results")]
        public void GivenIHaveBelowRegistrationWithCoreAndSpecialismAssessmentsResults(Table table)
        {
            var row = table.Rows;
            var uln = row[0]["Uln"];
            RegistrationCityAndGuilds.RegWithCoreAndSpecialismAssessmentResults(uln);
        }

        [Then(@"results shown for new provider")]
        public void ThenResultsShownForNewProvider()
        {
            throw new PendingStepException();
        }
    }
}
