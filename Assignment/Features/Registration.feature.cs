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
namespace Assignment.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Registration")]
    public partial class RegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Registration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Registration", null, ProgrammingLanguage.CSharp, featureTags);
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register a user successfully with enter")]
        [NUnit.Framework.CategoryAttribute("smokeTest")]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr 5", "SKG", "Greece", "23423", "987896", "213123", null)]
        public void RegisterAUserSuccessfullyWithEnter(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string sSN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("ZipCode", zipCode);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("SSN", sSN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register a user successfully with enter", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
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
 testRunner.Given("User navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.When(string.Format("User registers with valid data {0} {1} {2} {3} {4} {5} {6} {7}", firstName, lastName, address, city, state, zipCode, phone, sSN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
 testRunner.And("User presses enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.Then("Account created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register a user successfully with Register button")]
        [NUnit.Framework.CategoryAttribute("smokeTest")]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr 5", "SKG", "Greece", "23423", "987896", "213123", null)]
        public void RegisterAUserSuccessfullyWithRegisterButton(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string sSN, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("ZipCode", zipCode);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("SSN", sSN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register a user successfully with Register button", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given("User navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
 testRunner.When(string.Format("User registers with valid data {0} {1} {2} {3} {4} {5} {6} {7}", firstName, lastName, address, city, state, zipCode, phone, sSN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.And("User clicks on Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("Account created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Registration with null fields fail")]
        [NUnit.Framework.TestCaseAttribute("", "Doe", "adr", "SKG", "Greece", "23423", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "", "adr", "SKG", "Greece", "23423", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "", "SKG", "Greece", "23423", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr", "", "Greece", "23423", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr", "SKG", "", "23423", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr", "SKG", "Greece", "", "987896", "213123", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr", "SKG", "Greece", "23423", "987896", "", null)]
        public void RegistrationWithNullFieldsFail(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string sSN, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("ZipCode", zipCode);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("SSN", sSN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Registration with null fields fail", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("User navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.When(string.Format("User registers with valid data {0} {1} {2} {3} {4} {5} {6} {7}", firstName, lastName, address, city, state, zipCode, phone, sSN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.And("User clicks on Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("Account isn\'t created and an error appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Registration with different password fails")]
        [NUnit.Framework.TestCaseAttribute("John", "Doe", "adr 5", "SKG", "Greece", "23423", "987896", "213123", null)]
        public void RegistrationWithDifferentPasswordFails(string firstName, string lastName, string address, string city, string state, string zipCode, string phone, string sSN, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("ZipCode", zipCode);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("SSN", sSN);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Registration with different password fails", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 42
 testRunner.Given("User navigates to registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 43
 testRunner.When(string.Format("User registers with data {0} {1} {2} {3} {4} {5} {6} {7} and wrong confirm", firstName, lastName, address, city, state, zipCode, phone, sSN), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And("User presses enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("Account isn\'t created and password mismatch error appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
