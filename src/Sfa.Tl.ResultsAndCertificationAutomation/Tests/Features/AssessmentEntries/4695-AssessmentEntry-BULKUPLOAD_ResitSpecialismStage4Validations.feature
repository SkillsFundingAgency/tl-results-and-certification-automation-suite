Feature: 4695 - BULK UPLOAD: ASSESSMENT - resit specialism stage 4 validations
		 prevent adding MS to next assessment series as previous entry has no result 
		 (only applies if resit) error wording: This occupational specialism assessment cannot be entered 
		 as there is a previous assessment that does not have a result. 
		 Remove the previous assessment or add a result to proceed.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @AssessmentEntries
Scenario: 4695 Attempt to add a couplet specialism assessment entry for current series when previous specialism assessment series does not have a result added
And I have a registration with couplet specialism assessment series added for previous assessment year with no grade with <ULN>
And I am on Assessment entries upload page
And I have a active Specialism Assessment Series in "4695AssessmentEntryData.csv"
When I upload "4695AssessmentEntryData.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see all of the stage 4 validation errors related to Assessments in file "4695ExpectedErrorReport.csv"

Examples: 
| ULN         |
| 9900000005  |
