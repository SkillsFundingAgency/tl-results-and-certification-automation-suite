using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress
{
    public class AddAddressConfirmationPage : ElementHelper
    {
        //Add postcode
        private static string PageUrl { get; } = string.Concat(StartPage.StartPageUrl, "add-postal-address-confirmation");
        private static string PageHeader { get; } = "Organisation's postal address added successfully";
        private static string PageTitle { get; } = "Organisation's postal address added confirmation page – Manage T Level results – GOV.UK";
        private static By PageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By RequestSOABtn { get; } = By.Id("requestSoaButton");
        private static By BackToHomeLink { get; } = By.Id("backToHome");
     


        public static void VerifyAddPostalAddressPage()
        {
            Assert.AreEqual(PageUrl, WebDriver.Url);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
            Assert.AreEqual(PageTitle, WebDriver.Title);
        }
      
        public static void ClickRequestSOABtn()
        {
            ClickElement(RequestSOABtn);
        }

        public static void ClickBackToHomeLink()
        {
            ClickElement(BackToHomeLink);
        }


        public static void VerifyAddressAdded(string expDeptName, string expOrganisation, string expAddLine1, string expAddLine2, string expTown, string expPostcode)
        {
            string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
            string SQL = "  select * from TlProviderAddress where TlProviderId = 2 and id in (select max(id) from TlProviderAddress)";
            var queryResults = SqlDatabaseConncetionHelper.ReadDataFromDataBase(SQL, ConnectionString);

            foreach (object[] fieldNo in queryResults)
            {
            
                //Assign values to variables from the SQL query run
                string DepartmentName = fieldNo[2].ToString();
                string OrganisationName = fieldNo[3].ToString();
                string AddressLine1 = fieldNo[4].ToString();
                string AddressLine2 = fieldNo[5].ToString();
                string Town = fieldNo[6].ToString();
                string PostCode = fieldNo[7].ToString();

                Console.WriteLine("Show the dept name: " + DepartmentName);
                Console.WriteLine("Show the Org name: " + OrganisationName);
                Console.WriteLine("Show the ExpOrg name: " + AddressLine1);
                Console.WriteLine("Show the DEPR name: " + AddressLine2);
                Console.WriteLine("Show the DEPR name: " + Town);
                Console.WriteLine("Show the DEPR name: " + PostCode);
                //Assert values on database match expected address values
                Assert.AreEqual(expOrganisation, OrganisationName);
                Assert.AreEqual(expDeptName, DepartmentName);
                Assert.AreEqual(expAddLine1, AddressLine1);
                Assert.AreEqual(expAddLine2, AddressLine2);
                Assert.AreEqual(expTown, Town);
                Assert.AreEqual(expPostcode, PostCode);


            }

        }

    }
}
