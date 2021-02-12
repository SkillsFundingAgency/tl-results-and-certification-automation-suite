using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    [TestFixture]
    public class TestClass : ElementHelper
    {
        [Test]
        public void CreateRegistation()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.DeleteRegistrationFromTables(uln);
        }

    }
}
