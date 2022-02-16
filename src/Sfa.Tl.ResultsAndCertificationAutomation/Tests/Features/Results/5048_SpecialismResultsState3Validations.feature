Feature: 5048_SpecialismResultsState3Validations

As a result editor, I need summary of stage3 validation errors, So i can correct the uploading file

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have deleted all data for "CityAndGuilds"
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "5048_RegistrationsWithAssessmentsValid.csv" file
And I changed academic year to "2020"
And I am on Home page
And I am on Assessment entries upload page
And I upload assessment "5048_AssessmentsValid.csv" file
And I am on assessment entries home page
And I have moved following registration in to withdrawn state
| Uln        |
| 9500000005 |
And I am on Home page
And I am on results upload page

@RegressionTest @Results
Scenario: 5048_Assessment results stage3 validations
	When I upload results "5048_AssessmentResultsStage3Validations.csv" file
	Then I should see results upload unsuccess page
	And all assessment results stage3 erros listed in the downloaed report
