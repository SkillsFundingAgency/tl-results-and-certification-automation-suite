Feature: 2263_ResultsUploadStage2Validations
	As a Results Editor
	I need to understand why my file has failed to process 
	So that I can make any relevant changes

Background: 
Given I have logged in as a "ResultsEditor" user
And I am on results upload page

@RegressionTest @ResultsUpload
Scenario: 2263_Results upload stage2 invalid header
When I upload "ResultsUploadStage2InvalidHeader.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see invalid header error in the results downloaded file

@RegressionTest @ResultsUpload
Scenario: 2263_Results upload stage2 no data
When I upload "ResultsUploadStage2NoData.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see no data error in the results downloaded file

@RegressionTest @ResultsUpload
Scenario: 2263_Results upload stage2 validations
When I upload "ResultsUploadStage2Validations.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see all stage2 validations in the results downloaded file