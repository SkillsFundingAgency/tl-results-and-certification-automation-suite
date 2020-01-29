using System;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
        private By pageHeading = By.CssSelector("h1");

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        protected abstract Boolean SelfVerify();

        protected string GetPageHeading()
        {
            return webDriver.FindElement(pageHeading).Text;
        }
    }
}
