using System;
using TechTalk.SpecFlow;
using Faker;
using BLL.Utilities;

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
            if (InputName == "Email")
            {
                Value = Internet.Email();
            }
            else if(InputName == "Password" || InputName == "ConfirmPassword")
            {
                Value = "12345678";
            }else
                Value = Name.First();
            help.SendKeyToInput(InputName, Value);
            Console.WriteLine(InputName + " is: " + Value);
        }

        [When(@"I invoke ""(.*)"" button")]
        public void WhenIInvokeButton(string ButtonValue)
        {
            help.ClickButtonByValue(ButtonValue);
        }

        [Then(@"""(.*)"" should be ""(.*)""")]
        public void ThenShouldBe(string MsgElement, string MsgText)
        {
            help.CheckMsg(MsgElement, MsgText);
        }

    }
}
