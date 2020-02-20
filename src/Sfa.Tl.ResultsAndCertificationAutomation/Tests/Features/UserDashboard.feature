Feature: UserDashboard
	In order to validate user level permissions
	As a Tlevel user
	I want to see Dashboard based on user level

@Sprint8
Scenario: Dashboard AO_Approver
Given I have logged in as a "AOApprover" user
Then i should see Account, TLevels and Centre links

@Sprint8
Scenario:  Dashboard AO_Provider
Given I have logged in as a "AOProvider" user
Then I should see Account, Centre links

@Sprint8
Scenario: Dashboard Standard user
Given I have logged in as a "Standard" user
Then I should see Account link
