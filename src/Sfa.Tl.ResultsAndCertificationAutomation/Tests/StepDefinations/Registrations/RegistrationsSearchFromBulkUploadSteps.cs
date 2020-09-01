using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsSearchFromBulkUploadSteps : RegistrationsSearchPage
    {
        [Given(@"I click on Back link")]
        public void GivenIClickOnBackLink()
        {
            ClickElement(WebDriver.FindElement(By.Id("backLink")));
        }

        [Given(@"I click on Upload registration file link")]
        public void GivenIClickOnUploadRegistrationFileLink()
        {
            SqlQueries.DeleteFromRegistrationTables();
            ClickElement(RegistrationsPage.UploadRegistationLink);
        }
        
        [Given(@"I select registration file and click submit")]
        public void GivenISelectRegistrationFileAndClickSubmit()
        {
            UploadFile(RegistrationsPage.ChooseFile, RegistrationsPage.UploadValidFileSingle);
            ClickElement(RegistrationsPage.SubmitFileBtn);
        }

        [Given(@"I entered the (.*) and click on Search")]
        public void GivenIEnteredTheAndClickOnSearch(string p0)
        {
            EnterText(SearchBox, p0);
            ClickButton(SearchBtn);
        }
        
        [Then(@"I should see Registartion data matched with uploaded data")]
        public void ThenIShouldSeeRegistartionDataMatchedWithUploadedData()
        {
            VerifySearchFromBulkUpload();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
