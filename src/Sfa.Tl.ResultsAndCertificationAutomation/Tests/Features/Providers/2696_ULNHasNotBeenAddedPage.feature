Feature: 2696_ULNHasNotBeenAddedPage
	As a Provider 
	I need to be able to understand when learners have not had any English&Maths/IP data added
	So that I can ensure the data is added

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@Ignore @RegressionTest @Provider
Scenario: 2696 Verify Uln has not been added page
When I enter uln and click search
Then I should see Uln has not been added page
And click on Back link should navigate to search for learner page
And I have deleted LRS records from the database