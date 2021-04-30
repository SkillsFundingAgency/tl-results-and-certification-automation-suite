Feature: 2536_UlnNotRegistered
	As a Provider 
	I need to understand why I am unable to add learner data for learners who have not been registered by AO’s
	So that I can tell AO’s to register the learners

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have an Uln not existed in DB
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link

@RegressionTest @Provider
Scenario: 2536 Search for Uln not existed
When I enter non existed Uln
And I click on "Continue" button
Then I should see Uln is not registered page

@RegressionTest @Provider
Scenario: 2536 Check back link
And I enter non existed Uln
And I click on "Continue" button
When I click on "Back" link
Then I should be back to Add learner page
And I should be back to Add learner page when i click Back to search button
