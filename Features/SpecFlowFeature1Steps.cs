using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private readonly Calculator _calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //ScenarioContext.Current.Pending();
            _calculator.values.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
             _calculator.sumAllValues();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreEqual(_calculator.result, p0);
        }
    }
}
