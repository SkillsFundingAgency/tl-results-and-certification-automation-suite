Feature: 2264_ResultsUploadStage3Validations
	As a Results Editor
	I need to be able to see why my file has failed to upload
	So that I can make any relevant changes

Background: 
Given I have logged in as a "SiteAdmin" user

@RegressionTest @ResultsUpload
Scenario: 2264_Results stage3 Validations for Withdrawn Record
And I have a registration in Withdrawn state
And I navigated Home page
And I am on results upload page
When I upload "ResultsUploadStage3WithdrawnReg.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see stage3 withdrawn validation error in the results downloaded file