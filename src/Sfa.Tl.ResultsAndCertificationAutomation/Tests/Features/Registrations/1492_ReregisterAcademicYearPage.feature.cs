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
namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Registrations
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("1492_ReregisterAcademicYearPage")]
    public partial class _1492_ReregisterAcademicYearPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "1492_ReregisterAcademicYearPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/Registrations", "1492_ReregisterAcademicYearPage", "\tAs a Registrations Editor\r\n\tI need to select Academic Year\r\n\tSo record can be up" +
                    "dated", ProgrammingLanguage.CSharp, featureTags);
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
#line 6
#line hidden
#line 7
testRunner.Given("I have logged in as a \"RegistrationEditor\" user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
testRunner.And("I have a registration in Withdrawn state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
testRunner.And("I click on Change status link in registraion details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1492_Verify Reregister Academic year Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("ReactivateRegistration")]
        public void _1492_VerifyReregisterAcademicYearPage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "ReactivateRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1492_Verify Reregister Academic year Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 6
this.FeatureBackground();
#line hidden
#line 13
testRunner.And("I select register learner on different course and click on continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
testRunner.And("I select the provider and core from dropdown and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
testRunner.And("I select Add specialism option and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
testRunner.And("I select the Specialism in reregister specialism page and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
testRunner.Then("I should see Reregister Academic year page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1492_Verify Reregister Academic year Back link")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("ReactivateRegistration")]
        public void _1492_VerifyReregisterAcademicYearBackLink()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "ReactivateRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1492_Verify Reregister Academic year Back link", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 22
testRunner.And("I select register learner on different course and click on continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
testRunner.And("I select the provider and core from dropdown and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
testRunner.And("I select Add specialism option and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
testRunner.And("I select the Specialism in reregister specialism page and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
testRunner.When("I click on Back link on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
testRunner.Then("I should be navigated back to reregister select specalism page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1492_Reregister Academic year From Learner Decide Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("ReactivateRegistration")]
        public void _1492_ReregisterAcademicYearFromLearnerDecidePage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "ReactivateRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1492_Reregister Academic year From Learner Decide Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 32
testRunner.And("I select register learner on different course and click on continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
testRunner.And("I select the provider and core from dropdown and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
testRunner.And("I select No from has decided specialism and click Continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
testRunner.Then("I should see Reregister Academic year page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1492_Reregister Academic year Back To Learner Decide Page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("ReactivateRegistration")]
        public void _1492_ReregisterAcademicYearBackToLearnerDecidePage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "ReactivateRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1492_Reregister Academic year Back To Learner Decide Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 40
testRunner.And("I select register learner on different course and click on continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
testRunner.And("I select the provider and core from dropdown and click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
testRunner.And("I select No from has decided specialism and click Continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
testRunner.When("I click on Back link on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
testRunner.Then("I should be navigated back to Reregister Has learner decide page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
testRunner.And("previous selected radio option retained", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
testRunner.And("I cleared the data in DB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
