Feature: TLRC: 983-ChangeRegistrationCorePage
	As a Registrations Editor
	I need to be able to change the core of a learner after having searched for them
	So that it can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 983-Change Core page
When I click on Change core link
Then I should see change Core page

@RegressionTest @ChangeRegistration
Scenario: 983-Change Core Back link
When I click on Change core link
And I click on Back link
Then I should be nativigated back to registration details page