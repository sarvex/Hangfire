﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests.States
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SucceededStateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SucceededState.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Succeeded state", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Succeeded state")))
            {
                HangFire.Tests.States.SucceededStateFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
    testRunner.Given("a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.Given("the Succeeded state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("State name is \'Succeeded\'")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void StateNameIsSucceeded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("State name is \'Succeeded\'", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 9
  testRunner.Then("the state name is equal to \'Succeeded\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After applying it should expire the job data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterApplyingItShouldExpireTheJobData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After applying it should expire the job data", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 12
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
  testRunner.Then("it should expire the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After applying it should change the stats")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterApplyingItShouldChangeTheStats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After applying it should change the stats", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 16
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
  testRunner.Then("it should increase the succeeded counter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After applying it should add the job to the succeeded list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterApplyingItShouldAddTheJobToTheSucceededList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After applying it should add the job to the succeeded list", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 20
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
  testRunner.Then("the job should be added to the succeeded list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After unapplying it should persist the job data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterUnapplyingItShouldPersistTheJobData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After unapplying it should persist the job data", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 24
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
   testRunner.And("after I unapply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.Then("it should persist the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After unapplying it should change the stats")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterUnapplyingItShouldChangeTheStats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After unapplying it should change the stats", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 29
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
   testRunner.And("after I unapply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.Then("it should decrease the succeeded counter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After unapplying it should remove the job from the succeeded list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterUnapplyingItShouldRemoveTheJobFromTheSucceededList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After unapplying it should remove the job from the succeeded list", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 34
     testRunner.When("I apply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
   testRunner.And("after I unapply it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.Then("the job should be removed from the succeeded list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
