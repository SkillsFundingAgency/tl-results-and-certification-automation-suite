using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class PageHelper : ElementHelper
    {
        public static bool CheckForLink(string url)
        {
            var element = Driver.FindElement(By.LinkText(url));
            return element != null;
        }

        public static string TitleByTag(string titleTag)
        {
            var titleText = Driver.FindElement(By.TagName(titleTag)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TitleByxPath(string xPath)
        {
            var titleText = Driver.FindElement(By.XPath(xPath)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TitelById(string iD)
        {
            var titleText = Driver.FindElement(By.Id(iD)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TextDisplayByCss(string displayText)
        {
            var header = Driver.FindElement(By.CssSelector(displayText));
            return header != null ? header.Text : string.Empty;
        }

        public static bool CssElement(string name)
        {
            var element = Driver.FindElement(By.CssSelector(name));
            return element != null;
        }

        public static void WaitForPageElement(string elementId, int maxWaitTimeInSeconds)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

            wait.Until(
                d =>
                {
                    bool result;

                    try
                    {
                        result = Driver.FindElement(By.Id(elementId)) != null;
                    }
                    catch (NoSuchElementException)
                    {
                        throw new Exception("Element not found");
                    }

                    return result;
                });
        }

        public static void WaitForPageElementBy(int maxWaitTimeInSeconds, By @by)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

            wait.Until(d =>
            {
                bool result;

                try
                {
                    result = Driver.FindElement(@by) != null;
                }
                catch (NoSuchElementException)
                {
                    throw new Exception("Element not found");
                }
                return result;
            });
        }

        public static void InputBoxByName(string boxId, string term)
        {
            var searchBox = Driver.FindElement(By.Name(boxId));
            searchBox.SendKeys(term);
        }

        public static void SelectRadioButtonById(string radioButtonId)
        {
            var radioButton = Driver.FindElement(By.Id(radioButtonId));
            radioButton.Click();
        }

        public static void ClickOnLink(string text)
        {
            var linkText = Driver.FindElement(By.Id(text));
            linkText.Click();
        }

        public static IWebElement FindElementIfExists(By by)
        {
            var elements = Driver.FindElements(by);
            return (elements.Count >= 1) ? elements.First() : null;
        }
    }
}