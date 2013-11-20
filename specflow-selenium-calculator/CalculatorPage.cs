using System;
using System.Configuration;

namespace specflow_selenium_calculator
{
    public class CalculatorPage : FluentAutomation.FluentTest
    {
        public void Open()
        {
            I.Open(new Uri(ConfigurationManager.AppSettings["CalculatorLocation"], UriKind.Absolute));
        }

        public void ClickButtons(string buttons)
        {
            foreach (var ch in buttons)
                I.Click(string.Format("input[value*='{0}']", ch));
        }

        public void ValidateResult(string expectedResult)
        {
            I.Expect.Text(expectedResult).In("input[name='Input']");
        }
    }
}