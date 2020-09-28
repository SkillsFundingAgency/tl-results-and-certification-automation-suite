using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1487_ReactivateConfirmationRegDetailsSteps : RegistrationReactivate
    {
        [When(@"I click on view this registration details button")]
        public void WhenIClickOnViewThisRegistrationDetailsButton()
        {
            VerifyReactivateSuccessPage();
            ClickElement(ViewRegBtn);
        }
        
        [Then(@"I should see active registration details page")]
        public void ThenIShouldSeeActiveRegistrationDetailsPage()
        {
            VerifyRegDetails();
            Assert.IsTrue(WebDriver.FindElement(By.XPath("//*[@class='govuk-summary-list']")).Text.Contains("ACTIVE"));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
