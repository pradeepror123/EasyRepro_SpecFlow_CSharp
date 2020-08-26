Feature: Creation, updation and deletion of  Employer Accounts

@EmployerAccounts @CAD_Account
Scenario: Create Employer CAD Account
	Given CSA user logs-in and navigates to Employer Account Page
	When User creates a New Employer CAD Account Form and saves
	Then  User should be able to validate the created CAD Account
	And User should log-out of the Application
