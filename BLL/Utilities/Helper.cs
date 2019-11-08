using BLL.Browser;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BLL.Utilities
{
    public class Helper
    {
        By ByXpath;

        public void WaitForElementpresence(By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            wait.Until(c => c.FindElement(by));
        }

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void SelectByText(String Text)
        {
            ByXpath = By.XPath($"//*[text()='{Text}']");
            WaitForElementpresence(ByXpath);
            IWebElement element = Driver.WebDriver.FindElement(ByXpath);
            ScrollToElement(element);
            element.Click();
        }

        public void ValidateCurrentPage(String CurrentPage)
        {
            ByXpath = By.XPath($"//title[contains(text(), '{CurrentPage}')]");
            IWebElement PageName = Driver.WebDriver.FindElement(ByXpath);
            String GetPageName = PageName.Text;
            GetPageName.Should().ContainAny(CurrentPage, GetPageName);
        }

        public void SendKeyToInput(String InputName, String TextValue)
        {
            ByXpath = By.XPath($"//input[@id='{InputName}']");
            WaitForElementpresence(ByXpath);
            IWebElement Input = Driver.WebDriver.FindElement(ByXpath);
            ScrollToElement(Input);
            Input.Clear();
            Input.SendKeys(TextValue);
        }

        public void ClickButtonByValue(String ButtonValue)
        {
            ByXpath = By.XPath($"//input[@value='{ButtonValue}']");
            WaitForElementpresence(ByXpath);
            IWebElement button = Driver.WebDriver.FindElement(ByXpath);
            ScrollToElement(button);
            button.Click();
        }

        public void CheckMsg(String MsgElement, String MsgText)
        {
            ByXpath = By.XPath($"//div[@class='{MsgElement}']");
            WaitForElementpresence(ByXpath);
            IWebElement Msg = Driver.WebDriver.FindElement(ByXpath);
            MsgText.Should().Be(Msg.Text).ToString();
        }
    }
}
