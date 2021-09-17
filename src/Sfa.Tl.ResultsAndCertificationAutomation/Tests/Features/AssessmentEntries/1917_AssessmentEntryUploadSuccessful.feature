Feature: 1917_AssessmentEntryUploadSuccessful
	As a Registrations Editor
	I need to see that my upload file has been successful
	So that I can ensure my data has been uploaded

@RegressionTest @AssessmentEntriesUpload
Scenario: 1917_Assessment upload Success
Given I have logged in as a "RegistrationEditor" user
And I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page