Feature: 1915_AssessmentEntryUploadStage2Validations
	As a Registration Editor
	I need to understand why my file has failed to process 
	So that I can make any relevant changes

Background:
Given I have logged in as a "RegistrationEditor" user
And I am on Assessment entries upload page

@RegressionTest @AssessmentEntriesUpload
Scenario: 1915_Assessment upload stage2 validations
When I upload "AssessmentEntryStage2Validations.csv" file
And I click on "Submit" button
And I download the error file and verify
Then I should see all stage2 validation errors related to Assessments
And I cleared the data in DB

@RegressionTest @AssessmentEntriesUpload
Scenario: 1915_Assessment upload stage2 invalid header
When I upload "AssessmentEntryStage2InvalidHeader.csv" file
And I click on "Submit" button
And I download the error file and verify
Then I should see error related to invalid header
And I cleared the data in DB

@RegressionTest @AssessmentEntriesUpload
Scenario: 1915_Assessment upload stage2 No Data
When I upload "AssessmentEntryStage2NoData.csv" file
And I click on "Submit" button
And I download the error file and verify
Then I should see no data error
And I cleared the data in DB