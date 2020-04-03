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
        private By ProviderLink = By.XPath("//a[contains(text(),'Providers')]");
        private static string ProviderUrl => string.Concat(StartPage.StartPageUrl, "find-provider");
        private By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private By SearchProvider = By.Id("search");
        private static string SearchProviderTxt = "Derby College";
        private By SelectProviderPageHeader = By.TagName("h2");
        private readonly By Health = By.XPath("//*[contains(text(),"+ Constants.TlevelHealth +")]");
        private readonly By Legal = By.XPath("//*[contains(text(),"+ Constants.TlevelLegal +")]");
        private readonly By Engineering = By.XPath("//*[contains(text()," + Constants.TlevelEngineering + ")]");
        private readonly By Agriculture = By.XPath("//*[contains(text()," + Constants.TlevelAgricluture + ")]");
        private readonly By Education = By.XPath("//*[contains(text()," + Constants.TlevelEducation + ")]");
        private By TlevelSubmit = By.XPath("//button[contains (text(), 'Submit')]");
    }
}
