@Account
Feature: Accounts

@Sample
Scenario: Sample Scenario
    Given Sample Step

@EmployerAccounts @CAD_Account1
Scenario: Create Employer CAD Account
	Given User logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And User should log-out of the Application

@EmployerAccounts @PBI_Account
Scenario: Create Employer PBI Account
	Given User logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'PBI' Account and saves
	Then User should be able to validate the created Account
	And User should log-out of the Application

@EmployerAccounts @Multiple_CADAccounts @10104 
Scenario Outline: Create Employer CAD Account with multiple Users
       Given <User> logs-in and navigates to 'Employer' Page
       When User creates a New Employer 'CAD' Account and saves
       Then User should be able to validate the created Account
       And User should log-out of the Application
       Examples:
       | User |
    #   | CRMTest_CAR@ultimatemedical.edu |
    #   | CRMTest_CAAM@ultimatemedical.edu |
    #   | CRMTest_CADMGR@ultimatemedical.edu |
    #   | CRMTest_ASDCAD@ultimatemedical.edu |
    #   | CRMTest_DIRCAD@ultimatemedical.edu |
        #| CRMTest_ART@ultimatemedical.edu |
        #| CRMTest_DIRCAD@ultimatemedical.edu |
        #| CRMTest_DIRCOMPL@ultimatemedical.edu |
        #| CRMTest_GDS@ultimatemedical.edu |
        #| CRMTest_GSC@ultimatemedical.edu |
        #| CRMTest_GSTMGR@ultimatemedical.edu |
        #| CRMTest_GSTP@ultimatemedical.edu |
        #| CRMTest_ISP@ultimatemedical.edu |
        #| CRMTest_IntPrep@ultimatemedical.edu |
        #| CRMTest_MIS@ultimatemedical.edu |
        #| CRMTest_OBS@ultimatemedical.edu |
        #| CRMTest_RS@ultimatemedical.edu |
        #| CRMTest_RW@ultimatemedical.edu |
        #| CRMTest_VERMGR@ultimatemedical.edu |
        #| CRMTest_VP@ultimatemedical.edu |
        #| CRMTest_VS@ultimatemedical.edu |
        #| CRMTest_WAS@ultimatemedical.edu |
        | CRMTest_CRMGR@ultimatemedical.edu |
        | CRMTest_CRDIR@ultimatemedical.edu |
