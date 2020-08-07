using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeSpecialismWithYesSteps : RegistrationsManualPage
    {
        [Given(@"I select Yes from has decided specialism and click Continue")]
        public void GivenISelectYesFromHasDecidedSpecialismAndClickContinue()
        {
            ClickElement(DecideYes);
            ClickContiune();
        }
        
        [Given(@"I select the specialism")]
        public void GivenISelectTheSpecialism()
        {
            ClickElement(SelectSpecialismLegal);
            ClickContiune();
        }
        
        [Given(@"I click on Specialism change link")]
        public void GivenIClickOnSpecialismChangeLink()
        {
            ClickChangeSpecialismLink();
        }
        
        [Given(@"I select another speciallism and click continue")]
        public void GivenISelectAnotherSpeciallismAndClickContinue()
        {
            Assert.AreEqual(Constants.SpecialismDecideTitle, WebDriver.Title);
            Assert.AreEqual(SpecialismDecideHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(SpecialismDecidePageUrl));
            ClickElement(SelectSpecialismFinancial);
            ClickChangeBtn();
        }
        
        [Then(@"I should see changed specialism in the Check and submit page")]
        public void ThenIShouldSeeChangedSpecialismInTheCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
