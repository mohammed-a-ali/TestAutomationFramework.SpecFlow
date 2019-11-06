using BLL.Browser;
using BLL.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.SpecFlow.StepDefinitions
{
    [Binding]
    public class ValidateHomePageSteps
    {
        private static readonly string baseURL = ConfigurationManager.AppSettings["Test"];
        HomePageElements home = new HomePageElements();

        [Given(@"I am on the Home Page")]
        public void GivenIAmOnTheHomePage()
        {
            Driver.VisitURL(baseURL);
        }

        [Then(@"I should see nopcommerce Logo")]
        public void ThenIShouldSeenopcommerceLogo()
        {
            //home = new HomePageElements();
            //get the image path
            IWebElement homePageimage = home.HomePageImage;
            //Check the image presence
            bool ImagePresent = homePageimage.Displayed;
            //Validate the image appears
            ImagePresent.Should().BeTrue();
        }
    }
}
