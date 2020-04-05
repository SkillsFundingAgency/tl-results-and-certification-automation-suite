Feature: Provider
	In order to Add or Remove Tlevels from Provider page
	As a Provider User
	I want to see all functionality is working

@Sprint11
Scenario: Find Provider
	Given I have logged in as a "Provider" user
	When I click on Provider link in the dashboard
	Then I shou land into Providers Page

@Sprint11
Scenario: Add Single TLevel
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select the TLevel
And click on continue button
Then TLevel should be added to the Provide

@Sprint11
Scenario: Add Multiple Tlevels
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select multiple tlevels
And click on continue button
Then TLevels should be added to the Provide

@Sprint11
Scenario: View Added Tlevels
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select multiple tlevels
And click on continue button
Then TLevels should be added to the Provide
And Added Tlevels should be displayed when i click Manage Tlevels link


