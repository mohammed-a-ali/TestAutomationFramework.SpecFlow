using BLL.Browser;
using FluentAssertions;
using OpenQA.Selenium;
using System;

namespace BLL.Utilities
{
    public class Helper
    {
        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void SelectByText(String Text)
        {
            IWebElement element = Driver.WebDriver.FindElement(By.XPath($"//*[text()='{Text}']"));
            element.Click();
        }

        public void ValidateCurrentPage(String CurrentPage)
        {
            IWebElement PageName = Driver.WebDriver.FindElement(By.XPath($"//title[contains(text(), '{CurrentPage}')]"));
            String GetPageName = PageName.Text;
            GetPageName.Should().ContainAny(CurrentPage, GetPageName);
        }

        public void SendKeyToInput(String InputName, String TextValue)
        {
            IWebElement Input = Driver.WebDriver.FindElement(By.XPath($"//input[@id='{InputName}']"));
            ScrollToElement(Input);
            Input.Clear();
            Input.SendKeys(TextValue);
        }

        public void ClickButtonByValue(String ButtonValue)
        {
            IWebElement button = Driver.WebDriver.FindElement(By.XPath($"//input[@value='{ButtonValue}']"));
            button.Click();
        }
    }
}
