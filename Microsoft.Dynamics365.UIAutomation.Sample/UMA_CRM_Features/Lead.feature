@Lead
Feature: Creation, updation and deletion of Leads

@LeadCreation_PreEx
Scenario: Create Lead with Pre-Existing Employer & Contact
	Given CSA user logs-in and navigates to 'Lead' Page
	When User creates a New Lead 'with' Pre-Existing Employer, Contact and saves
	Then User should be able to validate the created Lead
	And User should log-out of the Application

@LeadCreation_NoPreEx
Scenario: Create Lead without Pre-Existing Employer & Contact
	Given CSA user logs-in and navigates to 'Lead' Page
	When User creates a New Lead 'without' Pre-Existing Employer, Contact and saves
	Then User should be able to validate the created Lead
	And User should log-out of the Application