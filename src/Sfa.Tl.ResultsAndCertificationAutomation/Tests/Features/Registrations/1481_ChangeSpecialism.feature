Feature: 1481_ChangeSpecialism
	As a Registrations Editor
	I need to be able to change the specialism of a learner after having searched for them
	So that it can be kept up to date


Background: 
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page
And I have created a registration without Specialism
And I am on registration deails page
When I click on change Specialism link
Then I should see change specialism page with all specialisms
And I cleared the data in DB

@Ignore @RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page Error Validations
And I have created a registration without Specialism
And I am on registration deails page
When I click on change Specialism link
And I click on change button without selecting the specialism
Then I should see Select specialism error message
And I cleared the data in DB

@RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page Back Link
And I have created a registration without Specialism
And I am on registration deails page
When I click on change Specialism link
And I click on Back link on page
Then I should be navigated back to registration details page
And I cleared the data in DB

@RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page add Specialism
And I have created a registration without Specialism
And I am on registration deails page
When I click on change Specialism link
And I select the specialism and click continue button
Then I should see selected specialism in the registration details page
And I cleared the data in DB

@RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page change Specialism
And I have created a manul registration
And I am on registration deails page
When I click on change Specialism link
And I click on coninue button in learner decide specialism page
And I select different specialism and click change button
Then I should see Change successfull message
And I should see newly added specialism on the registration details page
And I cleared the data in DB

@RegressionTest @ChangeRegistration
Scenario: 1481_Change Specialism Page remove Specialism
And I have created a manul registration
And I am on registration deails page
When I click on change Specialism link
And i click radio buton No on Has the learner decided spesialism page
And click on change button
Then I should see Change successfull message
And I should not see Specialism in registration details page
And I cleared the data in DB