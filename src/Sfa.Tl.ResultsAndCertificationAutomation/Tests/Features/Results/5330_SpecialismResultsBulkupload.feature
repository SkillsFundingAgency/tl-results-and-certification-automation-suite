Feature: 5330_SpecialismResultsBulkupload

As a Result editor, I want to upload specialism result, so i can upload multiple data

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "5330_RegistrationsValid.csv" file
And I changed academic year to "2020"
And I am on Home page
And I am on Assessment entries upload page
And I upload assessment "5330_AssessmentsValid.csv" file
And I am on assessment entries home page
And I am on Home page
And I am on results upload page

@RegressionTest @Results
Scenario: 5330_Upload valid specialism results
When I upload results "5330_ResultsValid.csv" file
Then results upload successfully message shown