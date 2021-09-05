Feature: TLRC_4174 Journey Improvements - Bulk upload - Registrations upload success
	As a Registrations Editor
	I need to be able to select options of what registration tasks I want to carry out
	So that I can select the appropriate task

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @Registrations
Scenario: 4174 Registration upload Success - Verify Upload another file button
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I will be shown the Registrations uploaded successfully page
When I click the Upload another file button on the Registrations uploaded successfully page
Then I am shown the Upload registration file page
And I cleared the data in DB

@RegressionTest @Registrations
Scenario: 4174 upload Success - Verify Back to home button
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I will be shown the Registrations uploaded successfully page
When I click the Back to home button on the Registrations uploaded successfully page
Then I should be navigated back to home page
And I cleared the data in DB

@RegressionTest @Registrations
Scenario: 4174 upload Success - Verify manage individual registrations link
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I will be shown the Registrations uploaded successfully page
When I click the manage individual registrations link on the Registrations uploaded successfully page
Then I am shown the Registrations Search for a registration page
And I cleared the data in DB


@RegressionTest @Registrations
Scenario: 4174 upload Success - Verify upload another multiple registrations file link
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I will be shown the Registrations uploaded successfully page
When I click the Upload another file button on the Registrations uploaded successfully page
Then I am shown the Upload registration file page
And I cleared the data in DB

@RegressionTest @Registrations
Scenario: 4174 upload Success - Verify add assessment periods link
When I click on Registrations link on Home page
And I click on Upload Registration file link
And I upload a file and click on Submit button
Then I will be shown the Registrations uploaded successfully page
When I click the add assessment periods link on the Registrations uploaded successfully page
Then I am shown the Assessments dashboard page
And I cleared the data in DB
