@JobOrder
Feature: Job Orders

@JobOrders_PBI
Scenario: Create Job Order on PBI Account
	Given User logs-in and navigates to 'New Employer' Page
	When  User creates a New Employer 'PBI' Account and saves
	Then  User should be able to validate the created Account
	And   User navigates to 'Job Order' Page
	When  User creates a New Job Order 'with' created Account
	Then  User should be able to validate the created Job Order
	And   User should log-out of the Application

@JobOrders_CAD
Scenario: Create Job Order on CAD Account
	Given User logs-in and navigates to 'New Employer' Page 
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And  User navigates to 'Job Order' Page
	When User creates a New Job Order 'with' created Account
	Then User should be able to validate the created Job Order