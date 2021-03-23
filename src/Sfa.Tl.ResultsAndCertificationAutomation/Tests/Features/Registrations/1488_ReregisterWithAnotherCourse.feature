Feature: 1488_ReregisterWithAnotherCourse
	As a Registrations Editor
	I need to select the Provider for a student who is re-registering
	So that I can register their new details

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1488_Reregister new course provider page
When I select register learner on different course and click continue button
Then I should register learner on a new course provider page
And the registration for this test is deleted

@RegressionTest @ReactivateRegistration
Scenario: 1488_Reregister new course provider page Back link
When I select register learner on different course and click continue button
And I click on Back link on page
Then I should be navigated back to Reactivte options page
And the register learner on different course radio button should be selected
And the registration for this test is deleted