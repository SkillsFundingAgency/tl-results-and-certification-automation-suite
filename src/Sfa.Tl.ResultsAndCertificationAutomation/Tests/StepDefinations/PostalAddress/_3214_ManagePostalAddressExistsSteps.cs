using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3214_ManagePostalAddressExistsSteps
    {
        [Given(@"I deleted the exisintg address and created a new address in database")]
        public void GivenIDeletedTheExisintgAddressAndCreatedANewAddressInDatabase()
        {
            SqlQueries.DeleteAddress();
            SqlQueries.InsertAddress();
        }
    }
}
