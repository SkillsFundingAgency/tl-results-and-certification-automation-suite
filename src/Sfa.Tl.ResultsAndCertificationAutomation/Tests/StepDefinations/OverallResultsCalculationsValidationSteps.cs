using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;
using System;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class OverallGradeCalculationValidation
    {
        public string OverallGrade;

        [Given(@"I have run the query to return all results from Overall Grade Lookup table using ""([^""]*)"" ""([^""]*)"" ""([^""]*)""")]
        public void GivenIHaveRunTheQueryToReturnAllResultsFromOverallGradeLookupTableUsing(string TLevel, string CoreGrade, string SpecialismGrade)
        {
            Console.WriteLine(TLevel);
            Console.WriteLine(CoreGrade);
            Console.WriteLine(SpecialismGrade);
            var ActualOverallGrade = SqlQueries.ReturnOverallGrade(TLevel, CoreGrade, SpecialismGrade);
            OverallGrade = ActualOverallGrade;
        }

        [Then(@"I should see the Overall Result match the ""([^""]*)""")]
        public void ThenIShouldSeeTheOverallResultMatchThe(string ExpectedOverallGrade)
        {
            Assert.AreEqual(OverallGrade, ExpectedOverallGrade);
        }
    }
}