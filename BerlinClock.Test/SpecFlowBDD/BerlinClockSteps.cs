using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Test.SpecFlowBDD
{
    [Binding]
    public class BerlinClockSteps
    {
        private ITimeConverter _berlinClock = new TimeConverter();
        private string _time;

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _time = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(theExpectedBerlinClockOutput, _berlinClock.ConvertTime(_time));
        }
    }
}
