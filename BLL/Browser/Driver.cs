using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace BLL.Browser
{
    public class Driver
    {
        public const String Chrome = "Chrome";
        public const String Firefox = "Firefox";
        public static IWebDriver WebDriver;

        public static IWebDriver OpenBrowser(String browserName)
        {
            WebDriver = null;
            switch (browserName)
            {
                case Chrome:
                    if (WebDriver == null)
                    {
                        WebDriver = new ChromeDriver();
                    }
                    break;

                case Firefox:
                    if (WebDriver == null)
                    {
                        WebDriver = new FirefoxDriver();
                    }
                    break;
            }
            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static void CloseBrowser()
        {
            WebDriver.Quit();
        }

        public static void VisitURL(String URL)
        {
            WebDriver.Navigate().GoToUrl(URL);
        }
    }
}
