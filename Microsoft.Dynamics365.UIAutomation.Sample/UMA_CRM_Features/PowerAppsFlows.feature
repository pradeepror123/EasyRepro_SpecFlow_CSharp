Feature: Power Apps Runs

@PowerApps
Scenario: Run UMA Power Automate Flows
	Given User logs-in and navigates to UMA Power Automate Flows page
	Then  loop through all the Flows and run them