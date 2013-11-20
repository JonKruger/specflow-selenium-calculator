using System;
using System.Configuration;
using FluentAutomation;
using TechTalk.SpecFlow;

namespace specflow_selenium_calculator
{
    [Binding]
    public class CalculatorSteps 
    {
        private CalculatorPage _calculator;

        [BeforeScenario()]
	public void BeforeScenario()
	{
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Firefox);
            FluentAutomation.Settings.DefaultWaitUntilTimeout = new TimeSpan(0, 0, 3);
	}

        [Given(@"I have opened the calculator")]
        public void GivenIHaveOpenedTheCalculator()
        {
            _calculator = new CalculatorPage();
            _calculator.Open();
        }

        [When(@"I press ""(.*)""")]
        public void WhenIPress(string buttons)
        {
	    _calculator.ClickButtons(buttons);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string result)
        {
            _calculator.ValidateResult(result);
        }
    }
}
