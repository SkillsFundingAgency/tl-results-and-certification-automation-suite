using System;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public abstract class BasePage
    {
        private By PageHeading = By.CssSelector("h1");

        protected abstract Boolean SelfVerify();

        protected string GetPageHeading()
        {
            return Hooks.WebDriver.FindElement(PageHeading).Text;
        }
    }
}
