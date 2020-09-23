Feature: TLRC: 981-ChangeRegistrationProviderPage
	As a Registrations Editor
	I need to be able to change the provider of a learner after having searched for them
	So that it can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario:981-Change Provider page
When I click on change Provider link on Regisration details page
Then I should see Change provider page

@RegressionTest @ChangeRegistration
Scenario: 981-Change Provider without change
When I click on change Provider link on Regisration details page
And I click on Change button without changing provider
Then I should be navigated back to registration details page
And I should see same provider in the details

@RegressionTest @ChangeRegistration
Scenario: 981-Change Provider change another provider
When I click on change Provider link on Regisration details page
And I change another provider has same core from the list
And I click on Change button
Then I should see Change successfull message
And I should see new provider details in registration details page

@RegressionTest @ChangeRegistration
Scenario: 981-Change Provider back link
When I click on change Provider link on Regisration details page
And I click on Back link on page
Then I should be navigated back to registration details page
