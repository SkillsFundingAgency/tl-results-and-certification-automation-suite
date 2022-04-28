Feature: 2837_ULNHasNotBeenRegisteredPage
	As a Provider
	I need to be able to understand that I cannot search for a learner who has not been registered by an AO
	So that I can tell the AO to register the learner

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have an Uln not existed in DB
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@Ignore @RegressionTest @Provider
Scenario: 2837 Verify Uln has not registered page
When I enter uln and click search
Then I shoud see Uln has not been registrered page
And clicking on Back link should show search learner page
And clicking on Back to search button should show search learner page
And clicking "Back to manage learner T Level records" should navigate to learner dashboard page