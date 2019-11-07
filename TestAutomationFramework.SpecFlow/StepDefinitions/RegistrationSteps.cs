using System;
using TechTalk.SpecFlow;
using Faker;
using BLL.Utilities;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationFramework.SpecFlow.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        Helper help = new Helper();


        [When(@"I click ""(.*)""")]
        public void WhenIClick(string Text)
        {
            help.SelectByText(Text);
        }

        [When(@"I go to ""(.*)"" page")]
        public void WhenIGotoPage(string PageName)
        {
            help.ValidateCurrentPage(PageName);
        }

        [When(@"I enter ""(.*)"" into ""(.*)"" textbox")]
        public void WhenIEnterIntoTextbox(string InputName, string Value)
        {
            if (Value == "Email")
            {
                Value = Internet.Email();
            }
            else
                Value = Name.First();
            help.SendKeyToInput(InputName, Value);
            Console.WriteLine(InputName + " is: " + Value);
        }

        [When(@"I invoke ""(.*)"" button")]
        public void WhenIInvokeButton(string ButtonValue)
        {
            help.ClickButtonByValue(ButtonValue);
        }
    }
}
