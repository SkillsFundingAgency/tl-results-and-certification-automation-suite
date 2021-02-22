Feature: 2136_CannotDeleteRegistrationWithResult
	As a R&C Portal user
	I need to understand that I cannot delete a record that has a result against it
	So that a statement of achievement can be requested

Background:
Given I have logged in as a "RegistrationEditor" user
And I have a registration with result

@RegressionTest @Results
Scenario: 2136 Cannot delete registration with active result
And I search the registration
And I click on Change status link in registraion details page
And I select Delete this registration permanently
When I click on "Continue" button
Then I should see "You cannot delete this registration" page
And Back link should take me to active registration options page
And clicking on "Back to registration details" button should take me to registration details page

