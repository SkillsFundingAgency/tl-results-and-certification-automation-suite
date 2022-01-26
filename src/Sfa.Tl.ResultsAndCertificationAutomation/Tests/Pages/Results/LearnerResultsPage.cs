using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerResultsPage: ElementHelper
    {
        private static string PageUrl { get; } = "learner-results";
        private static string PageTitle { get; } = "Learner's results – Manage T Level results – GOV.UK";

        public static void VerifyLearnerResultsPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }
    }
}
