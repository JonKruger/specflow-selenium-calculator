using System;
using FluentAutomation;
using TechTalk.SpecFlow;

namespace specflow_selenium_calculator
{
    [Binding]
    public class CalculatorSteps : FluentAutomation.FluentTest
    {
        [Given(@"I have opened the calculator")]
        public void GivenIHaveOpenedTheCalculator()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
            FluentAutomation.Settings.DefaultWaitUntilTimeout = new TimeSpan(0, 0, 3);
            I.Open(new Uri(@"c:\proj\specflow-selenium-calculator\specflow-selenium-calculator\calc.htm", UriKind.Absolute));
        }
        
        [When(@"I press ""(.*)""")]
        public void WhenIPress(string buttons)
        {
            foreach (var ch in buttons)
                I.Click(string.Format("input[value*='{0}']", ch));
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string result)
        {
	    I.Expect.Text(result).In("input[name='Input']");
        }
    }
}
