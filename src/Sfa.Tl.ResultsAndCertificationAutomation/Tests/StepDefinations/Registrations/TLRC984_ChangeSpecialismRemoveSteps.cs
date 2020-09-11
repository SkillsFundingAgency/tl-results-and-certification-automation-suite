using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC984_ChangeSpecialismRemoveSteps : RegistrationsSearchPage
    {
        [When(@"i click radio buton No on Has the learner decided spesialism page")]
        public void WhenIClickRadioButonNoOnHasTheLearnerDecidedSpesialismPage()
        {
            ClickElement(DecideSpecialismNo);
        }
                
        [Then(@"Specialism code should not be listed in registration details page")]
        public void ThenSpecialismCodeShouldNotBeListedInRegistrationDetailsPage()
        {
            ClickButton(BackToRegistrationDetailsBtn);
            VerifySearchResultPage();
            Assert.IsFalse(WebDriver.FindElement(By.Id("main-content")).Text.Contains("Legal (50000001)"));
        }
    }
}
