Feature: ProviderBackFunctionality
	In order to navigate to previous pages
	As a Provider Editor
	I want to see Back link on journey pages

@RegressionTest @ProviderJourney
Scenario: BackLink-Select Provider Tlevel Page
	Given I have logged in as a "Provider" user
	And click on Provider link in dashboard page
	And I serch the Provider
	When I click on Back link
	Then I should be navigated back to Find a Provider page

@RegressionTest @ProviderJourney
Scenario: BackLink-Add Tlevel Page
Given I have logged in as a "Provider" user
And I am on the Add Tlevel Page
When I click on Back link
Then I should be navigated back to Providers Tlevel Page

@RegressionTest @ProviderJourney
Scenario: BackLink-Remove Tlevel Page
Given I have logged in as a "Provider" user
And I am on Remove Tlevel page
When I click on Back link
Then I should be navigated back to Providers Tlevel Page