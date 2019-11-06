using BLL.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pages
{
    public class PageBase
    {
        public IWebDriver Driver;
        public PageBase(IWebDriver driver)
        {
            driver = this.Driver;
        }

        public static void ClickButton(IWebElement button)
        {
            button.Click();
        }

        public static void SetTextToElement(IWebElement TextBox, String TextValue)
        {
            TextBox.Clear();
            TextBox.SendKeys(TextValue);
        }
    }
}
