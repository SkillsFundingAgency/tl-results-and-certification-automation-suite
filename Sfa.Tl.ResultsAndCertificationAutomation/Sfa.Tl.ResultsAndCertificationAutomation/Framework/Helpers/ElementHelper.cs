using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class ElementHelper : Hooks.Hooks
    {
       public static void FindElementContainingText(string text)
       {
            Driver.FindElement(By.XPath($"//*[contains(text(),'{text}')]"));
       }
        
       public static void FindAnyAnchorLinkingToUrl(string url)
       {
           Driver.FindElement(By.XPath($"//*[contains(text(),'{url}')]"));
       }
       
       public static void ClickElement(IWebElement element)
       {
           element.Click();
       }

        public static void ClickElement(By locator)
        {
            Driver.FindElement(locator).Click();
        }

        public static void ClearText(By locator)
        {
            Driver.FindElement(locator).Clear();
        }

        public static void EnterText(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void EnterText(By locator, string text)
        {
            Driver.FindElement(locator).Clear();
            Driver.FindElement(locator).SendKeys(text);
        }

        public static void EnterText(IWebElement element, int value)
        {
            if (element != null)
            {
                element.Clear();
                element.SendKeys(value.ToString());
            }
        }

        public static void PressTabKey()
        {
            IWebElement element = Driver.FindElement(By.TagName("body"));
            element.SendKeys(Keys.Tab);
        }

        public static void SelectFromDropDownByValue(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void SelectFromDropDownByValue(By locator, string value)
        {
            IWebElement element = Driver.FindElement(locator);
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        public static void SelectFromDropDownByText(By locator, string value)
        {
            IWebElement element = Driver.FindElement(locator);
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        public static void SelectFromDropDownByText(IWebElement element, string text)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public static void SelectCheckBox(IWebElement element)
        {
            if (element != null && (element.Displayed && !element.Selected))
            {
                element.Click();
            }
        }

        public static void SelectCheckBox(By locator)
        {
            IWebElement element = Driver.FindElement(locator);
            SelectCheckBox(element);
        }

        public static void SelectRadioOptionByForAttribute(By locator, string forAttribute)
        {
            IList<IWebElement> radios = Driver.FindElements(locator);
            var radioToSelect = radios.FirstOrDefault(radio => radio.GetAttribute("for") == forAttribute);

            if (radioToSelect != null)
                ClickElement(radioToSelect);
        }

        public static void PressEnter()
        {
            IWebElement element = Driver.FindElement(By.TagName("body"));
            element.SendKeys(Keys.Enter);
        }

        public static void ClickButtonByName(string buttonName)
        {
            var buttonElement = Driver.FindElement(By.Name(buttonName));
            buttonElement.Click();
        }
    }
}
