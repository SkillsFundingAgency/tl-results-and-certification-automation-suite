using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class CommonPage : ElementHelper
    {
        // Constants
        private static readonly string _backLinkId = "backLink";
        private static readonly string _buttonWithLabel = "//button[contains(text(),'{0}')]";
        private static readonly string errorClassName = "govuk-error-message";
        private static readonly string errorSummaryClassName = "govuk-error-summary__list";

        // Properties
        private static By BackLink { get { return By.Id(_backLinkId); } }
        private static By ButtonWithLabel { get { return By.XPath(_buttonWithLabel); } }

        public static string CurrentUrl { get { return WebDriver.Url;  } }

        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void NavigateToUrl(string url)
        {
            NavigateTo(url);
        }

        public static void VerifyExpectedFieldsPresent(Table table)
        {
            foreach (var row in table.Rows)
            {
                var id = row[0].GetIdByName();
                var isDisplayed = IsDisplayed(By.Id(id));
                
                Assert.IsTrue(isDisplayed, $"{row[0]} is not visible.");
            }
        }

        public static void FillFormWithData(Table table)
        {
            foreach (var row in table.Rows)
            {
                var id = By.Id(row[0].GetIdByName());
                EnterText(id, row[1]);
            }
        }

        public static void ClickButtonByLabel(string label)
        {
            var buttonWithLabel = By.XPath(string.Format(_buttonWithLabel, label));
            ClickElement(buttonWithLabel);
        }

        public static void VerifyValidationMessages(Table table)
        {
            var errors = GetElementsByClassName(errorClassName);
            foreach (var row in table.Rows)
            {
                var expectedError = $"Error:\r\n" + row[1];
                Assert.IsTrue(errors.Select(x => x.Text).Contains(expectedError));
            }
        }

        public static void VerifyValidationSummaryMessages(Table table)
        {
            var errors = GetElementsByClassName(errorSummaryClassName);
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(errors.FirstOrDefault().Text.Contains(row[0]));
            }
        }
    }
}
