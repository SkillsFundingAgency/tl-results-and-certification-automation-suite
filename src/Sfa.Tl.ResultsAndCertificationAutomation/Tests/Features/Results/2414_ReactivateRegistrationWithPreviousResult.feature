Feature: 2414_Updating Data with Results (Re-activate - Manual)
	As a R&C Portal user
	I need results data to be updated after a record is re-activated
	So that student data can be kept up to date


Background: 
Given I have logged in as a "SiteAdmin" user
And I have a registration with result
And I am on result details page
And I maximise the browser window

@RegressionTest @Results
Scenario: 2414_Reactivate a registration which had an active grade when it was withdrawn
Given I click on "Change" link in result page
And I successfully change the grade to E 
And I withdraw the registration and reactivate it
Then the reactivated registration will display the grade as "Grade: E"
And the registration for this test is deleted

@RegressionTest @Results
Scenario: 2414_Reactivate a registration which didn't have an active grade when it was withdrawn
Given I click on "Change" link in result page
And I successfully remove the grade
And I withdraw the registration and reactivate it
Then the reactivated registration will display the grade as "Grade: Not received"
And the registration for this test is deleted

