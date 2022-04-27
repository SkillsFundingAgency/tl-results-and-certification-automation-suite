Feature: 2867_IntegrateULNHasNotBeenAddedWithEnterULNPage
	As a Provider
	I need to be able to add English & Maths/IP details for learners who haven’t had their details added yet
	So that learner data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@Ignore @RegressionTest @Provider
Scenario: 2867 Verify integrated enter uln page
When I enter uln and click search
And I click on Continue button on Uln not added page
Then I should see add learner record page
And Uln should be retained in the text box
And clicking on Back link should show Uln not added page
And I have deleted LRS records from the database
