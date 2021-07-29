Feature: 3742_BlockWithdrawLearner
	As an AO with a registrations editor role
	I need to be stopped from withdrawing a record whilst it is being appealed
	So that I can be sure the correct grade is recorded in the database for that student

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Appealed state
And I am on registration details page
And click on change status link

@RegressionTest @ReviewsAndAppeals
Scenario: 3742 Verify cannot withdraw registration page
When I select withdraw registration and click continue
Then I should see you cannot withdraw registration page
And Back link should takes to withdraw registration option page
And back to registration button takes to registration details page
And back to home button takes to dashboard page
And the registration for this test is deleted
