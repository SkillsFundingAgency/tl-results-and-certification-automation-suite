Feature: UserDashboard
	In order to validate user level permissions
	As a Tlevel user
	I want to see Dashboard based on user level

@Sprint8
Scenario: Dashboard page for Site Administrator user
Given I have logged in as a "SiteAdmin" user
Then i should see Account, TLevels and Centre links

@Sprint8
Scenario: Dashboard page for page for All Level Users
Given I have logged in as a "AllUser" user
Then i should see Account, TLevels and Centre links

@Sprint8
Scenario: Dashboard page for Reviewer and Provider user
Given I have logged in as a "ReviewerAndProvider" user
Then i should see Account, TLevels and Centre links

@Sprint8
Scenario: Dashboard page for Reviewer
Given I have logged in as a "Reviewer" user
Then i should see Account, TLevels links

@Sprint8
Scenario: Dashboard page for Provider
Given I have logged in as a "Provider" user
Then I should see Account, Centre links
