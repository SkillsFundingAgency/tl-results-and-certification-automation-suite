Feature: 4708_AssessmentEntryUpload-NoAssessSeriesFirstOne
	As a Registrations Editor
	I need to see an error message on the error file stating: Available to add after the current assessment series has passed
	When I attempt to upload an assessment file with an assessment entry for the open assessment series for a registration with the current academic year
	So that I know the assessment series has not been added

@RegressionTest @AssessmentEntriesUpload
Scenario: 4708_Attempt to add the current assessment series to a new registration
Given I have logged in as a "RegistrationEditor" user
And I am on Registrations upload page
And I have a Academic Year in "RegistrationsDataForAssessments.csv"
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
And I have a active Assessment Series in "AssessmentEntrySuccessfulData.csv"
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
And I download the error file and verify
##Then I should see all stage3 errors in the file
Then I should see all errors in the file for attempting to add a first assessment series
And I cleared the data in DB
