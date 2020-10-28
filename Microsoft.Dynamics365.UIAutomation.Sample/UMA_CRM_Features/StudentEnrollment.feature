Feature: Student Enrollments

@StudentEnrollment @ValidateAccessToFields @10625
Scenario Outline: Validate access to Student Enrollment form fields by Role
	Given <User> logs-in and navigates to 'Student Enrollment' Page
	Then validate the accessibility of fields on the form
	Then User should log-out of the Application
	Examples:
	| User |
	| CRMTest_Dir@ultimatemedical.edu | 
	| CRMTest_MIS@ultimatemedical.edu |
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
	| CRMTest_CADMGR@ultimatemedical.edu |
	| CRMTest_ASDCAD@ultimatemedical.edu |
	| CRMTest_GSTMGR@ultimatemedical.edu |
	| CRMTest_VERMGR@ultimatemedical.edu |
	| CRMTest_DIRAL@ultimatemedical.edu |
	| CRMTest_DIRCAD@ultimatemedical.edu |
	| CRMTest_DIRCOMPL@ultimatemedical.edu |
	| CRMTest_DIROPS@ultimatemedical.edu |
	| CRMTest_OPS@ultimatemedical.edu |
	| CRMTest_AViPr@ultimatemedical.edu |
	| CRMTest_ViPr@ultimatemedical.edu |
	| CRMTest_SrViPr@ultimatemedical.edu |