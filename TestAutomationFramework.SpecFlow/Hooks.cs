using BLL.Browser;
using BLL.Utilities;
using System.Configuration;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.SpecFlow
{
    [Binding]
    public sealed class Hooks
    {
        private static readonly string browserName = ConfigurationManager.AppSettings["browser"];
        private readonly ScenarioContext Context;

        public Hooks(ScenarioContext Context)
        {
            this.Context = Context;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Driver.OpenBrowser(browserName);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (Context.TestError != null)
            {
                ScreenShot.TakeScreenShot();
            }
            //TODO: implement logic that has to run after executing each scenario
            Driver.CloseBrowser();
        }
    }
}
