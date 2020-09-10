Feature: Creation, updation and deletion of Job Orders

@JobOrders_PBI
Scenario: Create Job Order
	Given CSA user logs-in and navigates to 'Employer' Page
	When User creates a New Employer 'PBI' Account and saves
	Then User should be able to validate the created Account
	And  CSA user navigates to 'Job Order' Page
	When User creates a New Job Order with created Account
	Then User should be able to validate the created Job Order

#@JobOrders_CAD
#Scenario: Create Job Order
#	Given CSA user logs-in and navigates to 'Employer' Page 
#	When User creates a New Employer 'CAD' Account and saves
#	Then User should be able to validate the created Account
#	And  CSA user navigates to 'Job Order' Page
#	When User creates a New Job Order with created Account
#	Then User should be able to validate the created Job Order
