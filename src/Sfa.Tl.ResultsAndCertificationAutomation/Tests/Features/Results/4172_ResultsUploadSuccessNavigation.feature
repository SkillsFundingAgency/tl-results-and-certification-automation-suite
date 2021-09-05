Feature: TLRC_4172 Journey Improvements - Bulk upload - Results upload success
	As a Results Editor
	I need to see that my upload file has been successful
	So that I can ensure my data has been uploaded

Background: 
Given I have logged in as a "SiteAdmin" user

@RegressionTest @Results
Scenario: 4172 Results upload Success - Verify Upload another file button navigation
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Submit" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Submit" button
Then I should see results upload success page
And I should see number of records been uploaded message
When I click the Upload another file button on the results upload success page
Then I am shown the Upload Results file page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 4172 Results upload Success - Verify Back to home button navigation
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Submit" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Submit" button
Then I should see results upload success page
And I should see number of records been uploaded message
When I click the Back to home button on the results upload success page
Then I should be navigated back to home page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 4172 Results upload Success - Verify manage individual registrations link navigation
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Submit" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Submit" button
Then I should see results upload success page
And I should see number of records been uploaded message
And I cleared the data in DB


@RegressionTest @Results
Scenario: 4172 Results upload Success - Verify upload another multiple registrations file link navigation
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Submit" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Submit" button
Then I should see results upload success page
And I should see number of records been uploaded message
When I click the upload another multiple registrations file link on the results upload success page
Then I am shown the Upload Results file page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 4172 Results upload Success - Verify appeal link navigation
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Submit" button
And I navigated Home page
And I am on results upload page
And I upload "ResultsUploadSuccess.csv" file
And I click on "Submit" button
Then I should see results upload success page
And I should see number of records been uploaded message
When I click the appeal link on the results upload success page
Then I should see the Appeals dashboard
And I cleared the data in DB