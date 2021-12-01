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
    [NUnit.Framework.DescriptionAttribute("4713_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - Details page - New learner")]
    public partial class _4713_MANUALJOURNEYASSESSMENTENTRYCHANGES_DetailsPage_NewLearnerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "4713_AssessmentEntryDetailsPageNewLearner.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/AssessmentEntries", "4713_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - Details page - New learner", "\tGive users clear understanding of the learner’s assessment entries status, provi" +
                    "des more learner details, \r\n\tlearner details structured with accessibility in mi" +
                    "nd, \r\n\tgive clear information of what learner can add and not add and when.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
testRunner.Given("I have logged in as a \"CityAndGuildsAdmin\" user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
testRunner.And("I am on Registrations upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
testRunner.And("I am on upload registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
testRunner.And("I have a Academic Year in \"4713RegistrationsData.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
testRunner.When("I upload \"4714RegistrationsData.csv\" file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
testRunner.And("I click on \"Upload\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
testRunner.And("I navigated Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
testRunner.And("I navigate to the Search for a learner page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4713_Navigate to Assessment Details page for a new learner with a single speciali" +
            "sm code")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntriesUpload")]
        [NUnit.Framework.TestCaseAttribute("9900000011", null)]
        public virtual void _4713_NavigateToAssessmentDetailsPageForANewLearnerWithASingleSpecialismCode(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntriesUpload"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4713_Navigate to Assessment Details page for a new learner with a single speciali" +
                    "sm code", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 18
testRunner.When(string.Format("I enter the following {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
testRunner.Then(string.Format("I am navigated to the Assessment Details page for {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
testRunner.And("the Core section will state \"You cannot register this learner for a core componen" +
                        "t assessment until the summer 2022 window opens.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
testRunner.And("the core code will display \"Building Services Engineering (60369115)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
testRunner.And("the specialism section will state \"You cannot register this learner for an occupa" +
                        "tional specialism assessment until the summer 2023 window opens.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
testRunner.And("the Specialism code will display \"Gas Engineering (ZTLOS029)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4713_Navigate to Assessment Details page for a new learner with no specialism cod" +
            "es recorded")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntriesUpload")]
        [NUnit.Framework.TestCaseAttribute("9900000013", null)]
        public virtual void _4713_NavigateToAssessmentDetailsPageForANewLearnerWithNoSpecialismCodesRecorded(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntriesUpload"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4713_Navigate to Assessment Details page for a new learner with no specialism cod" +
                    "es recorded", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 33
testRunner.When(string.Format("I enter the following {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
testRunner.Then(string.Format("I am navigated to the Assessment Details page for {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
testRunner.And("the Core section will state \"You cannot register this learner for a core componen" +
                        "t assessment until the summer 2022 window opens.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
testRunner.And("the core code will display \"Building Services Engineering (60369115)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
testRunner.And("the specialism section will state \"This learner does not have an occupational spe" +
                        "cialism recorded on this service\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
testRunner.And("when I click on the Add an occupational specialism recorded on this service link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
testRunner.Then(string.Format("I am navigated to the Registration Details page for the learner\'s {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4713_Navigate to Assessment Details page for a new learner with multiple speciali" +
            "sm codes")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntriesUpload")]
        [NUnit.Framework.TestCaseAttribute("9900000012", null)]
        public virtual void _4713_NavigateToAssessmentDetailsPageForANewLearnerWithMultipleSpecialismCodes(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntriesUpload"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4713_Navigate to Assessment Details page for a new learner with multiple speciali" +
                    "sm codes", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 50
testRunner.When(string.Format("I enter the following {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
testRunner.Then(string.Format("I am navigated to the Assessment Details page for {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
testRunner.And("the Core section will state \"You cannot register this learner for a core componen" +
                        "t assessment until the summer 2022 window opens.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
testRunner.And("the core code will display \"Building Services Engineering (60369115)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
testRunner.And("the specialism section will state \"You cannot register this learner for an occupa" +
                        "tional specialism assessment until the summer 2023 window opens.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
testRunner.And("the Specialism code will display \"Heating Engineering (10202101) and Plumbing (10" +
                        "202102)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4713_Validate the breadcrumbs on the Assessment Entry Learner Details page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("AssessmentEntriesUpload")]
        [NUnit.Framework.TestCaseAttribute("9900000012", null)]
        public virtual void _4713_ValidateTheBreadcrumbsOnTheAssessmentEntryLearnerDetailsPage(string uLN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest",
                    "AssessmentEntriesUpload"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ULN", uLN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4713_Validate the breadcrumbs on the Assessment Entry Learner Details page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 64
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 65
testRunner.When(string.Format("I enter the following {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
testRunner.Then(string.Format("I am navigated to the Assessment Details page for {0}", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
testRunner.When("I click the Search for a learner breadcrumb on the Assessment Entry Learner Detai" +
                        "ls page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
testRunner.Then("I am navigated to the Search for a learner page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
testRunner.When(string.Format("I search for the {0} and click the Asessments breadcrumb on the Assessment Entry " +
                            "Learner Details page", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
testRunner.Then("I am navigated to the assessments dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
testRunner.When(string.Format("I search for the {0} and click the Home breadcrumb on the Assessment Entry Learne" +
                            "r Details page", uLN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
testRunner.Then("I am navigated to the Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
