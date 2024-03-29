﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.AssessmentEntries
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("4704 - BULK UPLOAD ASSESSMENT: Single occupational specialism and core stage 4 va" +
        "lidations")]
    public partial class _4704_BULKUPLOADASSESSMENTSingleOccupationalSpecialismAndCoreStage4ValidationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "4704-AssessmentEntry-BULKUPLOAD_SingleOccupationSpecialismStage4Validations.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/AssessmentEntries", "4704 - BULK UPLOAD ASSESSMENT: Single occupational specialism and core stage 4 va" +
                    "lidations", @"		As users can now add specialisms to a series, we need to ensure all the validation rules are in place to ensure only the correct information is entered into the database
		This is applicable to resit.

		*Prevent adding single occupational specialism to next assessment series as previous entry has no result 
		*If a result associated to the assessment entry and user attempts to remove assessment entry - validation message ", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line hidden
#line 9
testRunner.Given("I have logged in as a \"CityAndGuildsAdmin\" user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4704 Attempt to add a specialism assessment entry through bulk upload for current" +
            " series when previous specialism assessment series does not have a result added")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntries")]
        [NUnit.Framework.TestCaseAttribute("9900000005", null)]
        public void _4704AttemptToAddASpecialismAssessmentEntryThroughBulkUploadForCurrentSeriesWhenPreviousSpecialismAssessmentSeriesDoesNotHaveAResultAdded(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntries"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4704 Attempt to add a specialism assessment entry through bulk upload for current" +
                    " series when previous specialism assessment series does not have a result added", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 13
testRunner.And(string.Format("I have a registration with Specialism assessment series added for previous assess" +
                            "ment year with no grade with {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
testRunner.And("I am on Assessment entries upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
testRunner.And("I have a active Specialism Assessment Series in \"4704AssessmentEntryData.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
testRunner.When("I upload \"4704AssessmentEntryData.csv\" file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
testRunner.And("I click on \"Upload\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
testRunner.And("I download the error file and verify", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
testRunner.Then("I should see all of the stage 4 validation errors related to Assessments in file " +
                        "\"4704ExpectedErrorReport.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4704 Cannot remove previous specialism assessment entry which has a result using " +
            "bulk assessment upload file")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntries")]
        [NUnit.Framework.TestCaseAttribute("9900000005", null)]
        public void _4704CannotRemovePreviousSpecialismAssessmentEntryWhichHasAResultUsingBulkAssessmentUploadFile(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntries"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4704 Cannot remove previous specialism assessment entry which has a result using " +
                    "bulk assessment upload file", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 28
testRunner.And(string.Format("I have a registration with Specialism assessment series added for previous assess" +
                            "ment year with a grade with {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
testRunner.And("I am on Assessment entries upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
testRunner.When("I upload \"4704AssessmentEntryDataRemoveAssessSeries.csv\" file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
testRunner.And("I click on \"Upload\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
testRunner.And("I download the error file and verify", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
testRunner.Then("I should see all of the stage 4 validation errors related to Assessments in file " +
                        "\"4704AssessmentEntryDataRemoveAssessSeriesErrReport.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4704 Attempt to remove current specialism assessment entry which has a result thr" +
            "ough bulk upload")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntries")]
        [NUnit.Framework.TestCaseAttribute("9900000005", null)]
        public void _4704AttemptToRemoveCurrentSpecialismAssessmentEntryWhichHasAResultThroughBulkUpload(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntries"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4704 Attempt to remove current specialism assessment entry which has a result thr" +
                    "ough bulk upload", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 41
testRunner.And(string.Format("I have a registration with Specialism assessment series added for current assessm" +
                            "ent series with a grade with {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
testRunner.And("I am on Assessment entries upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
testRunner.When("I upload \"4704AssessmentEntryDataRemoveAssessSeries.csv\" file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
testRunner.And("I click on \"Upload\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
testRunner.And("I download the error file and verify", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
testRunner.Then("I should see all of the stage 4 validation errors related to Assessments in file " +
                        "\"4704AssessmentEntryDataRemoveAssessSeriesErrReport.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
