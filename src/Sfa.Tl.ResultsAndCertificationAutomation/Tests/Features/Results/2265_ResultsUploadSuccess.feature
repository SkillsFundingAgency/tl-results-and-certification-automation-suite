Feature: 2265_ResultsUploadSuccess
	As a Results Editor
	I need to see that my upload file has been successful
	So that I can ensure my data has been uploaded

Background: 
Given I have logged in as a "SiteAdmin" user

@RegressionTest @ResultsUpload
Scenario: 2265_Multiple Results upload success
And I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Upload" button
Then I should see results upload success page
And I should see number of records been uploaded message
##And I should go back to results dashboad on clicking Back to Results button
And I cleared the data in DB

@RegressionTest @ResultsUpload
Scenario: 2265_Single Result upload success
And I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccessSingle.csv" file
And I click on "Upload" button
Then I should see results upload success page
And I should see single record has been uploaded message
##And I should go back to results dashboad on clicking Back to Results button
And I cleared the data in DB