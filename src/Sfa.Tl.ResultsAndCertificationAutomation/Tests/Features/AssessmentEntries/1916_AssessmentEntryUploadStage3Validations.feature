Feature: 1916_AssessmentEntryUploadStage3Validations
	As a Registrations Editor
	I need to be able to see why my file has failed to upload
	So that I can make any relevant changes

@RegressionTest @AssessmentEntriesUpload
Scenario: 1916_Assessment upload stage3 validations
Given I have logged in as a "RegistrationEditor" user
And I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntryStage3Validations.csv" file
And I click on "Submit" button
And I download the error file and verify
Then I should see all stage3 errors in the file

@RegressionTest @AssessmentEntriesUpload
Scenario: 1916_Assessment stage3 Validations for Withdrawn Record
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntryStage3ValidationsWithdrawnReg.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see validation error for withdrawn registration