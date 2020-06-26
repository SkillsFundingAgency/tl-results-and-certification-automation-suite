Feature: RegistrationsPage
	As a Registrations Editor
	I need to be able to select options of what registration tasks I want to carry out
	So that I can select the appropriate task

Background:
Given I have logged in as a "RegistrationEditor" user

@SmokeTest
Scenario: Registration Dashboard Page
When I click on Registrations link on Home page
Then Registration page should open

@Ignore @RegressionTest @Registrations
Scenario: Upload Registration file
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I should see upload successful message
And I should be navigated back to Registrations Page when i click on Back to registration button

@RegressionTest @Registrations
Scenario: Stage2 Validations
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload Stage2 invalid datafile and click on submit
And i click on Download Error flie
Then I should see all validation errors in the file

@RegressionTest @Registrations
Scenario: Stage3 Validations
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload Stage3 invald datafile and click on submit
And i click on Download Error flie
Then I should see validation errors in the file
