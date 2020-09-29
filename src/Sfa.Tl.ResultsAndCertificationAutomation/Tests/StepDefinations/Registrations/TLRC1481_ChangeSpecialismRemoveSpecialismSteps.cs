using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1481_ChangeSpecialismRemoveSpecialismSteps : RegistrationsSearchPage
    {
        [When(@"click on change button")]
        public void WhenClickOnChangeButton()
        {
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should not see Specialism in registration details page")]
        public void ThenIShouldNotSeeSpecialismInRegistrationDetailsPage()
        {
            ClickButton(BackToRegistrationDetailsBtn);
            VerifySearchResultPage();
            Assert.IsFalse(WebDriver.FindElement(By.Id("main-content")).Text.Contains("Legal (50000001)"));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
