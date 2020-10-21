﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ToBeDeleted.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CreationUpdationAndDeletionOfEmployerAccountsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Account.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Creation, updation and deletion of Employer Accounts", null, ProgrammingLanguage.CSharp, new string[] {
                        "Account"});
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
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Creation, updation and deletion of Employer Accounts")))
            {
                global::ToBeDeleted.Features.CreationUpdationAndDeletionOfEmployerAccountsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Sample Scenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Sample")]
        public virtual void SampleScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sample Scenario", null, new string[] {
                        "Sample"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given("Sample Step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer CAD Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CAD_Account1")]
        public virtual void CreateEmployerCADAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Employer CAD Account", null, new string[] {
                        "EmployerAccounts",
                        "CAD_Account1"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("User logs-in and navigates to \'Employer\' Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When("User creates a New Employer \'CAD\' Account and saves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("User should be able to validate the created Account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("User should log-out of the Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer PBI Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PBI_Account")]
        public virtual void CreateEmployerPBIAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Employer PBI Account", null, new string[] {
                        "EmployerAccounts",
                        "PBI_Account"});
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
 testRunner.Given("User logs-in and navigates to \'Employer\' Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When("User creates a New Employer \'PBI\' Account and saves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("User should be able to validate the created Account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("User should log-out of the Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void CreateEmployerCADAccountWithMultipleUsers(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "EmployerAccounts",
                    "Multiple_CADAccounts",
                    "10104"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Employer CAD Account with multiple Users", null, @__tags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
       testRunner.Given(string.Format("{0} logs-in and navigates to \'Employer\' Page", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
       testRunner.When("User creates a New Employer \'CAD\' Account and saves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
       testRunner.Then("User should be able to validate the created Account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
       testRunner.And("User should log-out of the Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer CAD Account with multiple Users: CRMTest_AR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Multiple_CADAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("10104")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_AR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_AR@ultimatemedical.edu")]
        public virtual void CreateEmployerCADAccountWithMultipleUsers_CRMTest_ARUltimatemedical_Edu()
        {
#line 23
this.CreateEmployerCADAccountWithMultipleUsers("CRMTest_AR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer CAD Account with multiple Users: CRMTest_ART@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Multiple_CADAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("10104")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_ART@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_ART@ultimatemedical.edu")]
        public virtual void CreateEmployerCADAccountWithMultipleUsers_CRMTest_ARTUltimatemedical_Edu()
        {
#line 23
this.CreateEmployerCADAccountWithMultipleUsers("CRMTest_ART@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer CAD Account with multiple Users: CRMTest_BDR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Multiple_CADAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("10104")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_BDR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_BDR@ultimatemedical.edu")]
        public virtual void CreateEmployerCADAccountWithMultipleUsers_CRMTest_BDRUltimatemedical_Edu()
        {
#line 23
this.CreateEmployerCADAccountWithMultipleUsers("CRMTest_BDR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create Employer CAD Account with multiple Users: CRMTest_CertS@ultimatemedical.ed" +
            "u")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Creation, updation and deletion of Employer Accounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("EmployerAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Multiple_CADAccounts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("10104")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CertS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CertS@ultimatemedical.edu")]
        public virtual void CreateEmployerCADAccountWithMultipleUsers_CRMTest_CertSUltimatemedical_Edu()
        {
#line 23
this.CreateEmployerCADAccountWithMultipleUsers("CRMTest_CertS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion

