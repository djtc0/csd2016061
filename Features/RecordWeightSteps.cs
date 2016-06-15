using System;
using TechTalk.SpecFlow;

namespace Features
{
    [Binding]
    public class RecordWeightSteps
    {
        [Given(@"I have entered (.*) kilos as my weight on (.*)/(.*)")]
        public void GivenIHaveEnteredKilosAsMyWeightOn(int p0, string p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press save")]
        public void WhenIPressSave()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system should display my current weight as (.*) kilos")]
        public void ThenTheSystemShouldDisplayMyCurrentWeightAsKilos(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
