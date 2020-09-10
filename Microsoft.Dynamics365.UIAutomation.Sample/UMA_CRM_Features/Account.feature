@Account
Feature: Creation, updation and deletion of Employer Accounts

@EmployerAccounts @CAD_Account
Scenario: Create Employer CAD Account
	Given CSA user logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And User should log-out of the Application

@EmployerAccounts @PBI_Account
Scenario: Create Employer PBI Account
	Given CSA user logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'PBI' Account and saves
	Then User should be able to validate the created Account
	And User should log-out of the Application