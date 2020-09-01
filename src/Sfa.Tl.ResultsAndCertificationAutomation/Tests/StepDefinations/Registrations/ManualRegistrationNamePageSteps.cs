using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class ManualRegistrationNamePageSteps : ManualRegistrationPage
    {
        [Given(@"I have entered all valid data to navigate to ""(.*)""")]
        public void GivenIHaveEnteredAllValidDataToNavigateTo(string pagePath)
        {
            NavigateToManualRegistrationNamePage();
            Assert.AreEqual(pagePath.FullUrl(), CommonPage.CurrentUrl);
        }

        [Given(@"I see following fields are available")]
        public void GivenISeeFollowingFieldsAreAvailable(Table table)
        {
            CommonPage.VerifyExpectedFieldsPresent(table);
        }

        [Then(@"I should see the following error messages")]
        public void ThenIShouldSeeTheFollowingErrorMessages(Table table)
        {
            CommonPage.VerifyValidationMessages(table);
        }

        [Then(@"I should see the following error summary messages")]
        public void ThenIShouldSeeTheFollowingErrorSummaryMessages(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

        [Given(@"I have entered a string with length ""(.*)"" in ""(.*)"" field")]
        public void GivenIHaveEnteredAStringWithLengthInField(int strlength, string fieldname)
        {
            base.FillDataWithLength(fieldname, strlength);
        }

        [Then(@"I should be navigated to the Dateofbirth page\.")]
        public void ThenIShouldBeNavigatedToTheDateofbirthPage_()
        {
            Assert.IsTrue(base.IsNavigatedToDateofBirthPage());
        }

        [Then(@"I should be navigated to the Uln page\.")]
        public void ThenIShouldBeNavigatedToTheUlnPage_()
        {
            Assert.IsTrue(base.IsNavigatedToUlnPage());
        }

        [Then(@"I see Uln value is populated")]
        public void ThenISeeUlnValueIsPopulated()
        {
            var expectedVal = (string)ScenarioContext.Current["ValidUln"];
            var actualVal = base.GetUlnFieldValue();
            Assert.AreEqual(expectedVal, actualVal);
        }
    }
}
