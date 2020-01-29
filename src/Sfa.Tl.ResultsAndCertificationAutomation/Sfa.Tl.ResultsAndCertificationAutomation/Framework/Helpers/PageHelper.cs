﻿using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class PageHelper : ElementHelper
    {
        public static bool CheckForLink(string url)
        {
            var element = WebDriver.FindElement(By.LinkText(url));
            return element != null;
        }

        public static string TitleByTag(string titleTag)
        {
            var titleText = WebDriver.FindElement(By.TagName(titleTag)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TitleByxPath(string xPath)
        {
            var titleText = WebDriver.FindElement(By.XPath(xPath)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TitelById(string iD)
        {
            var titleText = WebDriver.FindElement(By.Id(iD)).Text;
            return string.IsNullOrWhiteSpace(titleText) ? string.Empty : titleText;
        }

        public static string TextDisplayByCss(string displayText)
        {
            var header = WebDriver.FindElement(By.CssSelector(displayText));
            return header != null ? header.Text : string.Empty;
        }

        public static bool CssElement(string name)
        {
            var element = WebDriver.FindElement(By.CssSelector(name));
            return element != null;
        }

        public static void WaitForPageElement(string elementId, int maxWaitTimeInSeconds)
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

            wait.Until(
                d =>
                {
                    bool result;

                    try
                    {
                        result = WebDriver.FindElement(By.Id(elementId)) != null;
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
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(maxWaitTimeInSeconds));

            wait.Until(d =>
            {
                bool result;

                try
                {
                    result = WebDriver.FindElement(@by) != null;
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
            var searchBox = WebDriver.FindElement(By.Name(boxId));
            searchBox.SendKeys(term);
        }

        public static void InputBoxById(string boxId, string term)
        {
            var searchBox = WebDriver.FindElement(By.Id(boxId));
            searchBox.SendKeys(term);
        }

        public static void SelectRadioButtonById(string radioButtonId)
        {
            var radioButton = WebDriver.FindElement(By.Id(radioButtonId));
            radioButton.Click();
        }

        public static void ClickOnLink(string text)
        {
            var linkText = WebDriver.FindElement(By.Id(text));
            linkText.Click();
        }

        public static IWebElement FindElementIfExists(By by)
        {
            var elements = WebDriver.FindElements(by);
            return (elements.Count >= 1) ? elements.First() : null;
        }

        public static Boolean VerifyPageUrl(String actual, String expected)
        {
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Page URL verification failed:"
                                + "\n Expected URL: " + expected
                                + "\n Found URL: " + actual);
        }

        public static Boolean VerifyLinkIsPresent(By locator, String expected)
        {
            String actual = WebDriver.FindElement(locator).Text;
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("The following link was not found: "
                                + "\n Expected: " + expected
                                + "\n Found: " + actual);
        }

        public static Boolean VerifyPageHeading(String actual, String expected)
        {
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Page verification failed:"
                                + "\n Expected page: " + expected
                                + "\n Found page: " + actual);
        }

        public static Boolean VerifyText(String actual, String expected)
        {
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Text verification failed: "
                                + "\n Expected: " + expected
                                + "\n Found: " + actual);
        }

        public static Boolean VerifyText(By locator, int expected)
        {
            String expectedText = Convert.ToString(expected);
            return VerifyText(locator, expectedText);
        }

        public static Boolean VerifyText(By locator, String expected)
        {
            String actual = WebDriver.FindElement(locator).Text;
            return VerifyText(actual, expected);
        }

        public static void WaitForPageLoad(int waitinseconds)
        {
            Thread.Sleep(waitinseconds);
        }
    }
}