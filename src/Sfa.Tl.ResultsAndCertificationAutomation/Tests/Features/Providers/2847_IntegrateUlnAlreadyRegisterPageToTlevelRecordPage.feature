Feature: 2847_IntegrateUlnAlreadyRegisterPageToTlevelRecordPage
	As a Provider
	I need to be able to see the Learner T Level record of a learner who’s details have already been added
	So that I can ensure learner data is up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registration in Db with Industry Placement
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link
And I clear Uln data

@RegressionTest @Provider
Scenario: 2847 Verify integrated Uln already been added page
And I enter the Uln
When I click on "Continue" button
And I click on Continue button on Uln already been added page
Then I should see Learner T Level record page
And I have deleted LRS records from the database