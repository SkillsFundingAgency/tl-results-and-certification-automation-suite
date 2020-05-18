using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.Threading;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ProviderPage : ElementHelper
    {
        private static By ProviderLink = By.XPath("//a[contains(text(),'Providers')]");
        public static string ProviderUrl => string.Concat(StartPage.StartPageUrl, "find-provider");
        public static string SubmitTlevel => string.Concat(StartPage.StartPageUrl, "submit-successful");
        public static string SelectProviderUrl => string.Concat(StartPage.StartPageUrl, "select-providers-tlevels");
        public static string ProviderTlevelUrl => string.Concat(StartPage.StartPageUrl, "provider-tlevels");
        public static string YourProviderUrl => string.Concat(StartPage.StartPageUrl, "your-providers");
        public static string TlevelRemoveConfUrl => string.Concat(StartPage.StartPageUrl, "tlevel-removed-confirmation");
        public static string AddAdditionalTlevelUrl => String.Concat(StartPage.StartPageUrl, "add-additional-tlevels");
        public static string RemoveTlvelUrl => string.Concat(StartPage.StartPageUrl, "remove-tlevel");
        public static string AddTlevelPageTitle = "Add T Levels page – Manage T Level results – GOV.UK";
        public const string YourProviderTitle = "Your providers list page – Manage T Level results – GOV.UK";
        public const string YourProviderHeader = "Your providers";
        public const string FindProviderPageHead = "Find a provider";
        public const string FindProviderPageTitle = "Find a provider page – Manage T Level results – GOV.UK";
        public const string SelectProvidersTlevelPageTitle = "Select provider’s T Levels page – Manage T Level results – GOV.UK";
        public static string ProviderTLevelPageHeader = "Provider's T Levels";
        public static string ProviderTLevelPageTitle = "Provider’s T Levels list page – Manage T Level results – GOV.UK";
        public static string RemoveTLevelPageTitle = "Are You Sure You want to Remove This T Level page – Manage T Level results – GOV.UK";
        //public static string RemoveTLevelPageTitle = "Remove T Level";
        public static string TLevelRemovedPageTitle = "T Level removed successfully confirmation page – Manage T Level results – GOV.UK";
        public static string TlevelsAddedSuccessPageTitle = "T Levels added successfully page – Manage T Level results – GOV.UK";
        public static string TlevelAddedSuccessPageTitle = "T Level added successfully page – Manage T Level results – GOV.UK";
        public static string TlevelSuccessMsg = "T Level added successfully";
        public string TlevelsSuccessMsg = "T Levels added successfully";
        public string TlevelRemoved = "T Level removed successfully";
        private By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private By SearchProvider = By.Id("search");
        public static string SearchProviderTxt = "Derby College";
        public By PageHeader = By.TagName("h1");
        public By SelectProviderPageHeader = By.TagName("h2");
        private readonly By Health = By.XPath("//*[contains(text(),'T Level in Health')]");
        public readonly By Legal = By.XPath("//*[contains(text(),'T Level in Legal')]");
        private readonly By Engineering = By.XPath("//*[contains(text(),'T Level in Engineering')]");
        public readonly By Agriculture = By.XPath("//*[contains(text(),'T Level in Agriculture')]");
        public readonly By Education = By.XPath("//*[contains(text(),'T Level in Education')]");
        private By TlevelSubmit = By.XPath("//button[contains (text(), 'Submit')]");
        private By ManageProviderLink = By.XPath("//a[contains(text(),'Manage provider')]");
        private static string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private const string SQLDeleteProviderTlevel = "Delete from TqProvider where TlProviderId In (select Id from TlProvider where Name='Derby College')";
        private By RemoveTlevelLink = By.XPath("//a[contains(text(),'Remove')]");
        public By RemoveTlevelYes = By.Id("canremovetlevel");
        public By RemoveTlevelNo = By.Id("tl-remove-no");
        public By PageContent = By.XPath("//*[@id='main-content']");
        public By BackLink = By.XPath("//a[@id='backLink']");
        public By AddAnotherTlevelBtn = By.XPath("//a[contains(text(),'Add another T Level')]");
        //Breadcrumb
        public By BcProviderTlevel = By.XPath("//a[@id='breadcrumb2']");
        public By BcYourProvider = By.XPath("//a[@id='breadcrumb1']");
        public By BcHome = By.XPath("//a[@id='breadcrumb0']");

        public void DeleteTlevelFromDB()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(SQLDeleteProviderTlevel, ConnectionString);
        }

        public static void ClickProviderLink()
        {
            ClickElement(ProviderLink);
        }
        public void ManageTlevels()
        {
            ClickElement(ManageProviderLink);
        }

        public void FindProvider()
        {
            Assert.AreEqual(FindProviderPageHead, WebDriver.FindElement(PageHeader).Text);
            EnterText(SearchProvider, SearchProviderTxt);
            Thread.Sleep(1000);
            PressEnter();
            Thread.Sleep(1000);
            ClickElement(ContinueBtn);
        }

        public void SelectTlevel(By Tlevel)
        {
            ClickElement(Tlevel);
        }
        public void Submit()
        {
            ClickElement(TlevelSubmit);
        }

        public void ClickRemoveTlevel()
        {
            ClickElement(RemoveTlevelLink);
        }
        
        public void SubmitTlevelInProvider()
        {
            Assert.AreEqual(TlevelSuccessMsg, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SubmitTlevel, WebDriver.Url);
        }

        public void AddTlevel()
        {
            SelectTlevel(Agriculture);
            Submit();
            SubmitTlevelInProvider();
        }
    }
}
