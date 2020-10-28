@Lead
Feature: Leads

@LeadCreation_PreEx
Scenario: Create Lead with Pre-Existing Employer & Contact
	Given User logs-in and navigates to 'Lead' Page
	When  User creates a New Lead 'with Pre-Existing' Employer, Contact and saves
	Then  User should be able to validate the created Lead
	And   User should log-out of the Application

@LeadCreation_NoPreEx
Scenario: Create Lead without Pre-Existing Employer & Contact
	Given User logs-in and navigates to 'Lead' Page
	When  User creates a New Lead 'without Pre-Existing' Employer, Contact and saves
	Then  User should be able to validate the created Lead
	And   User should log-out of the Application

@LeadCreation_PBI
Scenario: Create Lead with Generated PBI Employer & Contact
	Given User logs-in and navigates to 'Employer' Page
	When  User creates a New Employer 'PBI' Account and saves
	Then  User should be able to validate the created Account 
	And   User navigates to 'Lead' Page
	When  User creates a New Lead 'with  Generated' Employer, Contact and saves
	Then  User should be able to validate the created Lead
	And   User should log-out of the Application

@LeadCreation_CAD
Scenario: Create Lead with Generated CAD Employer & Contact
	Given User logs-in and navigates to 'Employer' Page                  
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And User navigates to 'Lead' Page
	When User creates a New Lead 'with Generated' Employer, Contact and saves
	Then User should be able to validate the created Lead
	And  User should log-out of the Application

@LeadToJobOrder_PBI
Scenario: Create and Qualify a Lead to convert to Job Order with Pre-Existing PBI Employer & Contact
	Given User logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And User navigates to 'Lead' Page
	When User creates a New Lead 'with Generated' Employer, Contact and saves
	And  User fills 'Qualifying Questions' and Qualifies the Lead to Job Order
	Then User should be able to validate the created Job Order
	And  User should log-out of the Application

@LeadToJobOrder_CAD
Scenario: Create and Qualify a Lead to convert to Job Order with Pre-Existing CAD Employer & Contact
	Given User logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'CAD' Account and saves
	Then User should be able to validate the created Account
	And User navigates to 'Lead' Page
	When User creates a New Lead 'with Generated' Employer, Contact and saves
	And  User fills 'Qualifying Questions' and Qualifies the Lead to Job Order
	Then User should be able to validate the created Job Order
	And  User should log-out of the Application