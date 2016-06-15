using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //ScenarioContext.Current.Pending();
            calculator.values.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
             calculator.sumAllValues();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreEqual(calculator.result, p0);
        }
    }
}
