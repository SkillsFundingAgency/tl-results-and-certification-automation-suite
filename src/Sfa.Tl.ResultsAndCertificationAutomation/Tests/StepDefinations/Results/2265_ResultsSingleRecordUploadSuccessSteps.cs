using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsSingleRecordUploadSuccessSteps : ResultsDashboardPage
    {
        [Then(@"I should see single record has been uploaded message")]
        public void ThenIShouldSeeSingleRecordHasBeenUploadedMessage()
        {
            VerifyResultsUploadCount(ResultSingleSuccessMsg);
        }
    }
}
