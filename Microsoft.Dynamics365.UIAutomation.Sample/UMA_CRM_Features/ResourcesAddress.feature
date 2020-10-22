@ResourcesAddress
Feature: Creation, updation and deletion of Resources Address

@ResourcesAddress
Scenario: Validate access and creation of Address/Address Type fields on Resources Address
	Given User logs-in and navigates to 'New Resource Address' Page
	Then  User should be able to create 'Resource Address' with pre-existing data
	And   User should log-out of the Application