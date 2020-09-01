using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ManualRegistrationNamePageSteps : CommonPage
    {
        [When(@"I click on Back link on page")]
        public void WhenIClickOnBackLink()
        {
            ClickBackLink();
        }

        [Given(@"I navigated to Url ""(.*)""")]
        [When(@"I navigated to Url ""(.*)""")]
        public void WhenINavigatedToUrl(string url)
        {
            NavigateTo(url);
        }

        [When(@"click on ""(.*)"" button")]
        public void WhenClickOnButton(string label)
        {
            ClickButtonByLabel(label);
        }

        [Given(@"I filled form with following information")]
        public void GivenIFilledFormWithFollowingInformation(Table table)
        {
            FillFormWithData(table);
        }
    }
}
