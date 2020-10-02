Feature: 1620_RegistrationDelete
	As a Registrations Editor
	I need to understand how to delete a registration
	So that registration data can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration
And I search for my registration

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration Page
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
Then I should see Are you sure delete registration page

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration Page validations
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I click submit without selecting any options
Then I should see error on delete registration page

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration Page Back link
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I click on Back link on page
Then I should be navigated back to Amend registration options page

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration Cancel
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I click do not delete option and click submit button
Then I should be navigated back to registration details page

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration Confirmation
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I select Yes delete registration option and click submit
Then I should see delete congirmation page

@RegressionTest @RegistrationDelete
Scenario: 1620_Search for detleted registration
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I select Yes delete registration option and click submit
And I click on search for registration button
And I search for deleted registration
Then I should see ULN not found page

@RegressionTest @RegistrationDelete
Scenario: 1620_Delete Registration to Back to registration
And I click on Change status link in registraion details page
When I select Delete this registration radio button and click continue
And I select Yes delete registration option and click submit
And I click on Back To Registrations button
Then I should see registrations page