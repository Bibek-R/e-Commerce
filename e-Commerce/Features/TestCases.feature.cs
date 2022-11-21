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
namespace Project.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("e-Commerce website Test")]
    [NUnit.Framework.CategoryAttribute("Scenarios")]
    public partial class E_CommerceWebsiteTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Scenarios"};
        
#line 1 "TestCases.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "e-Commerce website Test", "To be able to login and use the coupon for shopping, also to be able to check if " +
                    "\r\nthe order number is carried to the account page.", ProgrammingLanguage.CSharp, featureTags);
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
#line 7
#line hidden
#line 8
 testRunner.Given("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Applying Coupon")]
        [NUnit.Framework.CategoryAttribute("TC1")]
        [NUnit.Framework.TestCaseAttribute("Correct_discount", "edgewords", "15", null)]
        public void ApplyingCoupon(string exampleDescription, string discountcode, string discountpercent, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ExampleDescription", exampleDescription);
            argumentsOfScenario.Add("discountcode", discountcode);
            argumentsOfScenario.Add("discountpercent", discountpercent);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Applying Coupon", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 7
this.FeatureBackground();
#line hidden
#line 13
 testRunner.When("I have a product in the cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And("I click on the cart menu item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And(string.Format("I enter the coupon \'{0}\'", discountcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then(string.Format("I can check coupon is \'{0}\'% off", discountpercent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("After placing an order, I want to check if the order is in the Orders List")]
        [NUnit.Framework.CategoryAttribute("TC2")]
        [NUnit.Framework.TestCaseAttribute("User_1", "Matt", "Rikcetts", "22 Jump Street", "Oxford", "SE21 2AB", "0124573976", "ryetike3@gmail.com", null)]
        [NUnit.Framework.TestCaseAttribute("User_2", "Kai", "Havertz", "29 Jump Street", "Cambridge", "CD25 2SF", "0176452392", "acw_data_traveler@gmail.com", null)]
        public void AfterPlacingAnOrderIWantToCheckIfTheOrderIsInTheOrdersList(string exampleDescription, string first_Name, string last_Name, string street_Address, string town, string postcode, string phone, string email, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ExampleDescription", exampleDescription);
            argumentsOfScenario.Add("First_Name", first_Name);
            argumentsOfScenario.Add("Last_Name", last_Name);
            argumentsOfScenario.Add("Street_Address", street_Address);
            argumentsOfScenario.Add("Town", town);
            argumentsOfScenario.Add("Postcode", postcode);
            argumentsOfScenario.Add("Phone", phone);
            argumentsOfScenario.Add("Email", email);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After placing an order, I want to check if the order is in the Orders List", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 23
 testRunner.When("I view the cart to see the added item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Street Address",
                            "Town",
                            "Postcode",
                            "Phone",
                            "Email"});
                table1.AddRow(new string[] {
                            string.Format("{0}", first_Name),
                            string.Format("{0}", last_Name),
                            string.Format("{0}", street_Address),
                            string.Format("{0}", town),
                            string.Format("{0}", postcode),
                            string.Format("{0}", phone),
                            string.Format("{0}", email)});
#line 24
 testRunner.And("I proceed to checkout to fill in the following information", ((string)(null)), table1, "And ");
#line hidden
#line 27
 testRunner.And("I complete the order to get the order number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("I click on MyOrders to check the order number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion