Feature: 2749_ChangeIPStatusPage
	As a Provider
	I need to be able to change the Industry Placement details I entered for a learner
	So that I can make sure the correct details are entered

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link
And I enter the ULN
And I click on "Continue" button
And I select "Yes, completed" radio button and press Continue

@Ignore @RegressionTest @Provider
Scenario: 2749 Verify change IP status page
When I click on IP change link
Then I expect to see the learner completed Industry Placement change page
And previously selected "Yes, completed" radio option is selected
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2749 Verify back link on change IP status page
When I click on IP change link
And I click on "Back" link
Then I am shown the Check and submit page for the Add a new learner journey
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2749 change IP status option
When I click on IP change link
And I select "Yes, completed with special consideration" radio button and press change
Then I should see new IP status in check and submit page
And I have deleted LRS records from the database