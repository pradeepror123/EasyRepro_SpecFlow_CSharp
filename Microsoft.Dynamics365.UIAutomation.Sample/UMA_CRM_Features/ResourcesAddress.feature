@ResourcesAddress
Feature: Resources Addresses

@ResourcesAddress @Pre_ExistingData_AddressType_Address @10343
Scenario Outline: Validate existing Address/Address Type fields on Resources Address
	Given <User> logs-in and navigates to 'New Resource Address' Page
	Then  User should be able to create 'Resource Address' with 'pre-existing' Address and Address Type
	And   User should log-out of the Application
	Examples: 
	| User |
	| CRMTest_BDR@ultimatemedical.edu |
	| CRMTest_GFR@ultimatemedical.edu |
	| CRMTest_FD@ultimatemedical.edu |
	| CRMTest_IMS@ultimatemedical.edu |
	| CRMTest_AR@ultimatemedical.edu |
	| CRMTest_CAR@ultimatemedical.edu |
	| CRMTest_CAAM@ultimatemedical.edu |
	| CRMTest_WAS@ultimatemedical.edu |
	| CRMTest_OBS@ultimatemedical.edu |
	| CRMTest_RS@ultimatemedical.edu |
	| CRMTest_IntPrep@ultimatemedical.edu |
	| CRMTest_EXA@ultimatemedical.edu |
	| CRMTest_PHTCSA@ultimatemedical.edu |
	| CRMTest_EXC@ultimatemedical.edu |
	| CRMTest_CertS@ultimatemedical.edu |
	| CRMTest_VS@ultimatemedical.edu |
	| CRMTest_VP@ultimatemedical.edu |
	| CRMTest_GSC@ultimatemedical.edu |
	| CRMTest_ISP@ultimatemedical.edu |
	| CRMTest_GSTP@ultimatemedical.edu |
	| CRMTest_ALMGR@ultimatemedical.edu |
	| CRMTest_EXTMGR@ultimatemedical.edu |
	| CRMTest_CSMGR@ultimatemedical.edu |
	| CRMTest_DIRAL@ultimatemedical.edu |
	| CRMTest_Dir@ultimatemedical.edu |
	| CRMTest_SrViPr@ultimatemedical.edu |
	| CRMTest_GSTMGR@ultimatemedical.edu |
	| CRMTest_OPS@ultimatemedical.edu |
	| CRMTest_AViPr@ultimatemedical.edu |
	| CRMTest_ASDCAD@ultimatemedical.edu |
	| CRMTest_CADMGR@ultimatemedical.edu |
	| CRMTest_ART@ultimatemedical.edu |
	| CRMTest_DIRCOMPL@ultimatemedical.edu |
	| CRMTest_ViPr@ultimatemedical.edu |
	| CRMTest_VERMGR@ultimatemedical.edu |
	| CRMTest_DIRCAD@ultimatemedical.edu |
	| CRMTest_CRMGR@ultimatemedical.edu |
	| CRMTest_DIROPS@ultimatemedical.edu |
	| CRMTest_GDS@ultimatemedical.edu |
	| CRMTest_MIS@ultimatemedical.edu |
	| CRMTest_RW@ultimatemedical.edu |

@ResourcesAddress @New_AddressType_Address @10343
Scenario Outline: Validate new Address/Address Type fields on Resources Address
	Given <User> logs-in and navigates to 'New Resource Address' Page
	Then  User should be able to create 'Resource Address' with 'new' Address and Address Type
	And   User should log-out of the Application
	Examples:
	| User |
	| CRMTest_BDR@ultimatemedical.edu |
	| CRMTest_GFR@ultimatemedical.edu |
	| CRMTest_FD@ultimatemedical.edu |
	| CRMTest_IMS@ultimatemedical.edu |
	| CRMTest_AR@ultimatemedical.edu |
	| CRMTest_CAR@ultimatemedical.edu |
	| CRMTest_CAAM@ultimatemedical.edu |
	| CRMTest_WAS@ultimatemedical.edu |
	| CRMTest_OBS@ultimatemedical.edu |
	| CRMTest_RS@ultimatemedical.edu |
	| CRMTest_IntPrep@ultimatemedical.edu |
	| CRMTest_EXA@ultimatemedical.edu |
	| CRMTest_PHTCSA@ultimatemedical.edu |
	| CRMTest_EXC@ultimatemedical.edu |
	| CRMTest_CertS@ultimatemedical.edu |
	| CRMTest_VS@ultimatemedical.edu |
	| CRMTest_VP@ultimatemedical.edu |
	| CRMTest_GSC@ultimatemedical.edu |
	| CRMTest_ISP@ultimatemedical.edu |
	| CRMTest_GSTP@ultimatemedical.edu |
	| CRMTest_ALMGR@ultimatemedical.edu |
	| CRMTest_EXTMGR@ultimatemedical.edu |
	| CRMTest_CSMGR@ultimatemedical.edu |
	| CRMTest_DIRAL@ultimatemedical.edu |
	| CRMTest_Dir@ultimatemedical.edu |
	| CRMTest_SrViPr@ultimatemedical.edu |
	| CRMTest_GSTMGR@ultimatemedical.edu |
	| CRMTest_OPS@ultimatemedical.edu |
	| CRMTest_AViPr@ultimatemedical.edu |
	| CRMTest_ASDCAD@ultimatemedical.edu |
	| CRMTest_CADMGR@ultimatemedical.edu |
	| CRMTest_ART@ultimatemedical.edu |
	| CRMTest_DIRCOMPL@ultimatemedical.edu |
	| CRMTest_ViPr@ultimatemedical.edu |
	| CRMTest_VERMGR@ultimatemedical.edu |
	| CRMTest_DIRCAD@ultimatemedical.edu |
	| CRMTest_CRMGR@ultimatemedical.edu |
	| CRMTest_DIROPS@ultimatemedical.edu |
	| CRMTest_GDS@ultimatemedical.edu |
	| CRMTest_MIS@ultimatemedical.edu |
	| CRMTest_RW@ultimatemedical.edu |