using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _3001_AddSENDStatusToLearnerTLevelRecordPageSteps : SqlQueries
    {

        private readonly ScenarioContext _scenarioContext;
        public _3001_AddSENDStatusToLearnerTLevelRecordPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [When(@"I update the registration profile record so Send is ""(.*)"" and IsEMAchieved is ""(.*)"" and RCFeed is ""(.*)""")]
        public void WhenIUpdateTheRegistrationProfileRecordSoSendIsAndIsEMAchievedIsAndRCFeedIs(string SendStatus, string EMStatus, string ISRCFeed)
        {

            var uln = _scenarioContext["uln"] as string;

            if (SendStatus == "false")
            {
                if (EMStatus == "true")
                {
                    String SQL = "update TqRegistrationProfile set Issendlearner = 'false', IsEnglishAndMathsAchieved = 'true', isrcfeed = 'false' 	where uniquelearnernumber = " + uln;
                    UpdateRegistrationProfileRecord(SQL);
                }

                else

                {
                    String SQL = "update TqRegistrationProfile set Issendlearner = null, IsEnglishAndMathsAchieved = 'false', isrcfeed = 'false' where uniquelearnernumber =" + uln;
                    UpdateRegistrationProfileRecord(SQL);
                }
            }
                 else if (SendStatus == "true")
            {
                    String SQL = "update TqRegistrationProfile set Issendlearner = 'true', IsEnglishAndMathsAchieved = 'true', isrcfeed = 'false' where uniquelearnernumber = " + uln;
                    UpdateRegistrationProfileRecord(SQL);
            }
                 else
            {
                String SQL = "update TqRegistrationProfile set Issendlearner = null, IsEnglishAndMathsAchieved = 'true', isrcfeed = 'false' where uniquelearnernumber = " + uln;
                UpdateRegistrationProfileRecord(SQL);
            }
                

        }
        
        [Then(@"the Learner Record page is displayed with EM status ""(.*)""")]
        public void ThenTheLearnerRecordPageIsDisplayedWithEMStatus(string expectedText)
        {
            ElementHelper.RefreshPage();
            LearnerRecordPage_ToBeDeleted.VerifyEMStatus(expectedText);
        }
    }
}
