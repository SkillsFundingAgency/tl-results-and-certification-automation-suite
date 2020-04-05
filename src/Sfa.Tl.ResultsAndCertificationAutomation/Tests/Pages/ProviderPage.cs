﻿using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ProviderPage : ElementHelper
    {
        private static By ProviderLink = By.XPath("//a[contains(text(),'Providers')]");
        private static string ProviderUrl => string.Concat(StartPage.StartPageUrl, "find-provider");
        public static string SubmitTlevel => string.Concat(StartPage.StartPageUrl, "submit-successful");
        private string FindProviderPageHead = "Find a provider";
        private string TlevelSuccessMsg = "T Level added successfully";
        public string TlevelsSuccessMsg = "T Levels added successfully";
        private By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private By SearchProvider = By.Id("search");
        public static string SearchProviderTxt = "Derby College";
        public By PageHeader = By.TagName("h1");
        public By SelectProviderPageHeader = By.TagName("h2");
        private readonly By Health = By.XPath("//*[contains(text(),'Health')]");
        public readonly By Legal = By.XPath("//*[contains(text(),'Legal')]");
        private readonly By Engineering = By.XPath("//*[contains(text(),'Engineering')]");
        public readonly By Agriculture = By.XPath("//*[contains(text(),'Agriculture')]");
        public readonly By Education = By.XPath("//*[contains(text(),'Education')]");
        private By TlevelSubmit = By.XPath("//button[contains (text(), 'Submit')]");
        private By ManageProviderLink = By.XPath("//a[contains(text(),'Manage provider')]");
        private static string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private const string SQLDeleteProviderTlevel = "Delete from TqProvider where TlProviderId In (select Id from TlProvider where Name='Derby College')";

        public void DeleteTlevelFromDB()
        {
            //SqlDatabaseConncetionHelper.UpdateSqlCommand(SQLDeleteProviderTlevel, ConnectionString);
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
            PressEnter();
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
        
        public void SubmitTlevelInProvider()
        {
            Assert.AreEqual(TlevelSuccessMsg, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SubmitTlevel, WebDriver.Url);
        }
    }
}
