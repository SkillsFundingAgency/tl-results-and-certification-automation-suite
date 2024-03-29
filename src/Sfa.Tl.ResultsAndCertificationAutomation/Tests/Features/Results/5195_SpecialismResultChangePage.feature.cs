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
namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Features.Results
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("5195_SpecialismResultChangePage")]
    public partial class _5195_SpecialismResultChangePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "5195_SpecialismResultChangePage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/Results", "5195_SpecialismResultChangePage", "As an AO, I need the ability to change an Occupational Specialism grade for a des" +
                    "ired ULN, so that I can update the ULN record with the latest grade achieved.", ProgrammingLanguage.CSharp, featureTags);
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
#line 5
#line hidden
#line 6
testRunner.Given("I have logged in as a \"CityAndGuildsAdmin\" user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
testRunner.And("I have a registration with core and specialism assessments results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
testRunner.And("I am on result details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5195 Change specialism result page")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("Results")]
        public void _5195ChangeSpecialismResultPage()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "Results"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5195 Change specialism result page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 12
testRunner.When("I click \'Specialism1 change result\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
testRunner.Then("change specialism result page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5195 Change specialism result page validations")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.CategoryAttribute("Results")]
        public void _5195ChangeSpecialismResultPageValidations()
        {
            string[] tagsOfScenario = new string[] {
                    "RegressionTest",
                    "Results"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5195 Change specialism result page validations", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 17
testRunner.And("I click \'Specialism2 change result\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
testRunner.When("I click on \"Change\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table113 = new TechTalk.SpecFlow.Table(new string[] {
                            "Error Messages"});
                table113.AddRow(new string[] {
                            "Please select the grade"});
#line 19
testRunner.Then("I should see the following error message on change specialism result page", ((string)(null)), table113, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table114 = new TechTalk.SpecFlow.Table(new string[] {
                            "Error Messages"});
                table114.AddRow(new string[] {
                            "Please select the grade"});
#line 22
testRunner.And("I should see the following error summary messages", ((string)(null)), table114, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
