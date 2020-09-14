Feature: TLRC: 984-ChangeRegistrationSpecialismPage
	As a Registrations Editor
	I need to be able to change the specialism of a learner after having searched for them
	So that it can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 984-Change Specialism page
When I click on change Specialism link
Then I should be navigated to Has learner decided on specialism page
And the redio button is selected to yes
And button name should be continue

@RegressionTest @ChangeRegistration
Scenario: 984-Change Specialism Back link
When I click on change Specialism link
And I click on Back link on page
Then I should be navigated back to registration details page

@RegressionTest @ChangeRegistration
Scenario: 984-Change Specialism Continue
When I click on change Specialism link
And I click on Continue button
Then I should see placeholder page

@RegressionTest @ChangeRegistration
Scenario: 984-Change Specialism remove specialism
When I click on change Specialism link
And i click radio buton No on Has the learner decided spesialism page
And I click on Change button
Then I should see Change successfull message
And Specialism code should not be listed in registration details page