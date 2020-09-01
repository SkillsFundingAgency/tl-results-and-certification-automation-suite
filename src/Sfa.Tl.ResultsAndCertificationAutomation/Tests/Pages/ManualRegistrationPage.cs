using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ManualRegistrationPage : ElementHelper
    {
        private readonly string validUln = "1234567890";
        
        private By UlnField { get { return By.Id("uln");  } }
        private By FirstnameField { get { return By.Id("lastname"); } }
        private By LastnameField { get { return By.Id("firstname"); } }

        // Todo: Dev should implement id.
        private static By ContinueBtn { get { return By.XPath("//button[contains(text(),'Continue')]"); } }
        public static By AddRegistrationLink { get { return By.XPath("//a[contains(text(),'Add a new registration')]"); } }
        public static By RegistrationLink { get { return By.XPath("//a[contains(text(),'Registrations')]"); } }

        public void NavigateToManualRegistrationNamePage()
        {
            SqlQueries.DeleteFromRegistrationTables();

            ClickElement(RegistrationLink);
            ClickElement(AddRegistrationLink);
            EnterText(UlnField, validUln);
            ClickElement(ContinueBtn);

            ScenarioContext.Current["ValidUln"] = validUln;
        }

        public bool IsNavigatedToDateofBirthPage()
        {
            var expectedUrl = UrlConstants.ManualRegistrationAddDob.FullUrl();
            return CommonPage.CurrentUrl.Equals(expectedUrl);
        }

        public bool IsNavigatedToUlnPage()
        {
            var expectedUrl = UrlConstants.ManualRegistrationAddUln.FullUrl();
            return CommonPage.CurrentUrl.Equals(expectedUrl);
        }

        public string GetUlnFieldValue()
        {
            // TODO: do we have helper already?
            var value = WebDriver.FindElement(UlnField).GetAttribute("value");
            return value;
        }

        public void FillDataWithLength(string fieldname, int strlength)
        {
            var data = new string('a', strlength);
            var id = By.Id(fieldname.GetIdByName());
            EnterText(id, data);
        }

    }
}
