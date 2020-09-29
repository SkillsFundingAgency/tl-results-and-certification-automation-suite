Feature: 1476_WithdrawnOptionsPage
	As a Registrations Editor
	I need to options to allow me to rejoin the course or re-register the learner
	So that I can make an informed choice

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state

@RegressionTest @ReactivateRegistration
Scenario: 1476_Withdrawn options page
When I click on Change status link in registraion details page
Then I should see withdrawn option page

@RegressionTest @ReactivateRegistration
Scenario: 1476_Withdrawn options page back link
When I click on Change status link in registraion details page
And I click on Back link on page
Then I should be navigated back to registration details page

@RegressionTest @ReactivateRegistration
Scenario: 1476_Withdrawn options page validations
When I click on Change status link in registraion details page
And I click continue without selecting withdrawn options
Then I should see errors in withdrawn options page