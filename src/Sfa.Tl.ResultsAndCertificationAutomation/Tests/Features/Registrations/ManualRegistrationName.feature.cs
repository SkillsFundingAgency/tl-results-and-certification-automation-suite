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
    [NUnit.Framework.DescriptionAttribute("ManualRegistrationName")]
    public partial class ManualRegistrationNameFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ManualRegistrationName.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/Features/Registrations", "ManualRegistrationName", "\tAs a Registrations Editor\r\n\tI want to add firstname and lastname\r\n\tSo that I can" +
                    " continue with manual registration", ProgrammingLanguage.CSharp, featureTags);
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
 testRunner.And("I have entered all valid data to navigate to \"add-registration-learners-name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify firstname and lastname field are available")]
        [NUnit.Framework.CategoryAttribute("ManualRegistration")]
        public void VerifyFirstnameAndLastnameFieldAreAvailable()
        {
            string[] tagsOfScenario = new string[] {
                    "ManualRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify firstname and lastname field are available", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table71 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field name"});
                table71.AddRow(new string[] {
                            "First name"});
                table71.AddRow(new string[] {
                            "Last name"});
#line 12
 testRunner.And("I see following fields are available", ((string)(null)), table71, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify mandatory field validation")]
        [NUnit.Framework.CategoryAttribute("ManualRegistration")]
        public void VerifyMandatoryFieldValidation()
        {
            string[] tagsOfScenario = new string[] {
                    "ManualRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify mandatory field validation", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
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
#line 19
 testRunner.When("click on \"Continue\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table72 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Error messages"});
                table72.AddRow(new string[] {
                            "First name",
                            "Enter first name"});
                table72.AddRow(new string[] {
                            "Last name",
                            "Enter last name"});
#line 20
 testRunner.Then("I should see the following error messages", ((string)(null)), table72, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table73 = new TechTalk.SpecFlow.Table(new string[] {
                            "Error messages"});
                table73.AddRow(new string[] {
                            "Enter first name"});
                table73.AddRow(new string[] {
                            "Enter last name"});
#line 24
 testRunner.And("I should see the following error summary messages", ((string)(null)), table73, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify maximum length validation")]
        [NUnit.Framework.CategoryAttribute("ManualRegistration")]
        public void VerifyMaximumLengthValidation()
        {
            string[] tagsOfScenario = new string[] {
                    "ManualRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify maximum length validation", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
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
#line 31
 testRunner.And("I have entered a string with length \"101\" in \"First name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("I have entered a string with length \"101\" in \"Last name\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.When("click on \"Continue\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table74 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field name",
                            "Error messages"});
                table74.AddRow(new string[] {
                            "First name",
                            "First name must be 100 characters or fewer"});
                table74.AddRow(new string[] {
                            "Last name",
                            "Last name must be 100 characters or fewer"});
#line 34
 testRunner.Then("I should see the following error messages", ((string)(null)), table74, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table75 = new TechTalk.SpecFlow.Table(new string[] {
                            "Error messages"});
                table75.AddRow(new string[] {
                            "First name must be 100 characters or fewer"});
                table75.AddRow(new string[] {
                            "Last name must be 100 characters or fewer"});
#line 38
 testRunner.And("I should see the following error summary messages", ((string)(null)), table75, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify navigated to Dateofbirth page on submit")]
        [NUnit.Framework.CategoryAttribute("ManualRegistration")]
        public void VerifyNavigatedToDateofbirthPageOnSubmit()
        {
            string[] tagsOfScenario = new string[] {
                    "ManualRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify navigated to Dateofbirth page on submit", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
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
                TechTalk.SpecFlow.Table table76 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field name",
                            "Value"});
                table76.AddRow(new string[] {
                            "First name",
                            "John"});
                table76.AddRow(new string[] {
                            "Last name",
                            "Smith"});
#line 45
 testRunner.And("I filled form with following information", ((string)(null)), table76, "And ");
#line hidden
#line 49
 testRunner.When("click on \"Continue\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("I should be navigated to the Dateofbirth page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Back link navigated to the Uln page")]
        [NUnit.Framework.CategoryAttribute("ManualRegistration")]
        public void VerifyBackLinkNavigatedToTheUlnPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ManualRegistration"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Back link navigated to the Uln page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
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
#line 54
 testRunner.When("I click on Back link on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("I should be navigated to the Uln page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.And("I see Uln value is populated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
