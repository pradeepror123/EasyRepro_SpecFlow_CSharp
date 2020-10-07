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
namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CreateAddressTypeAndAddressFromQuickCreateWindowFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "QuickCreate.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create Address Type and Address from Quick Create Window", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Create Address Type and Address from Quick Create Window")))
            {
                global::Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Features.CreateAddressTypeAndAddressFromQuickCreateWindowFeature.FeatureSetup(null);
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
        
        public virtual void QuickCreateAddressType(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddressQuickCreate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Quick Create Address Type", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("{0} logs-in and navigates to Quick Create \'Resource Address\' Window", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("User should be able to create and save a new \'Address Type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_BDR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_BDR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_BDR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_BDRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_BDR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_GFR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_GFR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_GFR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_GFRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_GFR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_FD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_FD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_FD@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_FDUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_FD@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_IMS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_IMS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_IMS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_IMSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_IMS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_AR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_AR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_AR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_ARUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_AR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_CAR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CAR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CAR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_CARUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_CAR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_CAAM@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CAAM@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CAAM@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_CAAMUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_CAAM@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_WAS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_WAS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_WAS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_WASUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_WAS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_OBS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_OBS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_OBS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_OBSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_OBS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_RS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_RS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_RS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_RSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_RS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_IntPrep@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_IntPrep@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_IntPrep@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_IntPrepUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_IntPrep@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_EXA@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_EXA@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_EXA@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_EXAUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_EXA@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_PHTCSA@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_PHTCSA@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_PHTCSA@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_PHTCSAUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_PHTCSA@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_EXC@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_EXC@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_EXC@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_EXCUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_EXC@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_CertS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CertS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CertS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_CertSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_CertS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_VS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_VS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_VS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_VSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_VS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_VP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_VP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_VP@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_VPUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_VP@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_GSC@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_GSC@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_GSC@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_GSCUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_GSC@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_ISP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_ISP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_ISP@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_ISPUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_ISP@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_GSTP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_GSTP@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_GSTP@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_GSTPUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_GSTP@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_ALMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_ALMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_ALMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_ALMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_ALMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_EXTMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_EXTMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_EXTMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_EXTMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_EXTMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_CSMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CSMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CSMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_CSMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_CSMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_CADMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_CADMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_CADMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_CADMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_CADMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_ASDCAD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_ASDCAD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_ASDCAD@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_ASDCADUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_ASDCAD@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_GSTMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_GSTMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_GSTMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_GSTMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_GSTMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_VERMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_VERMGR@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_VERMGR@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_VERMGRUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_VERMGR@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_Dir@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_Dir@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_Dir@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_DirUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_Dir@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_DIRAL@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_DIRAL@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_DIRAL@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_DIRALUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_DIRAL@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_DIRCAD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_DIRCAD@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_DIRCAD@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_DIRCADUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_DIRCAD@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_DIRCOMPL@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_DIRCOMPL@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_DIRCOMPL@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_DIRCOMPLUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_DIRCOMPL@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_DIROPS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_DIROPS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_DIROPS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_DIROPSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_DIROPS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_OPS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_OPS@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_OPS@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_OPSUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_OPS@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_AViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_AViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_AViPr@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_AViPrUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_AViPr@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_ViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_ViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_ViPr@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_ViPrUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_ViPr@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Quick Create Address Type: CRMTest_SrViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Create Address Type and Address from Quick Create Window")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddressQuickCreate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CRMTest_SrViPr@ultimatemedical.edu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:User", "CRMTest_SrViPr@ultimatemedical.edu")]
        public virtual void QuickCreateAddressType_CRMTest_SrViPrUltimatemedical_Edu()
        {
#line 4
this.QuickCreateAddressType("CRMTest_SrViPr@ultimatemedical.edu", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion

