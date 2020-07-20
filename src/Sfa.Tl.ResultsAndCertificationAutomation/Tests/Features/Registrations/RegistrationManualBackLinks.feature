Feature: RegistrationManualBackLinks
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Back link in Registration Pages
When I am on Select Specialism page
And I click Back link on each page
Then I should navigate to previous page