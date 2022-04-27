Feature: 2373_UlnHasAlreadyBeenAddedPage
	As a Provider 
	I need to understand that a ULN’s English/Maths and Industry Placement data has already been added
	So that I do not duplicate any data

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registration in Db with Industry Placement
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link
And I clear Uln data

@Ignore @RegressionTest @Provider
Scenario: 2373 Verify Uln already been added page
And I enter the Uln
When I click on "Continue" button
Then I should see Uln already been added page
And I should see "Continue" button
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2373 Verify Back link on Uln already been added page
And I enter the Uln
And I click on "Continue" button
When I click on "Back" link
Then I should be back to Add learner page
And I have deleted LRS records from the database