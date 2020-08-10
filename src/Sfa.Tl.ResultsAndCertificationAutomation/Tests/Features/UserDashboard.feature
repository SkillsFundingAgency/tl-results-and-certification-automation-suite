Feature: UserDashboard
	In order to validate user level permissions
	As a Tlevel user
	I want to see Dashboard based on user level

@SmokeTest
Scenario: Dashboard page for Site Administrator user
Given I have logged in as a "SiteAdmin" user
Then i should see Account, TLevels and Centre links

@SmokeTest
Scenario: Dashboard page for page for All Level Users
Given I have logged in as a "AllUser" user
Then i should see Account, TLevels and Centre links

@SmokeTest
Scenario: Dashboard page for Reviewer and Provider user
Given I have logged in as a "ReviewerAndProvider" user
Then i should see Account, TLevels and Centre links

@SmokeTest
Scenario: Dashboard page for Reviewer
Given I have logged in as a "Reviewer" user
Then i should see Account, TLevels links

@SmokeTest
Scenario: Dashboard page for Provider
Given I have logged in as a "Provider" user
Then I should see Account, Centre links

@RegressionTest
Scenario: Check Tech spec download page
Given I have naviageted to tech spec page
Then I should see Tech spec page with download file link

@RegressionTest
Scenario: Check User Guide page
Given I have navigated to Tlevel Start page
When I click on User Guide link
Then I should see user guide page
