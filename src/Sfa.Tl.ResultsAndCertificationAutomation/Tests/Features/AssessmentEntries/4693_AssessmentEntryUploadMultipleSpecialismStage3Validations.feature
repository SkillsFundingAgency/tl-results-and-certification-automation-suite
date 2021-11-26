Feature: 4693 BULK UPLOAD: multiple specialism stage 3 validations
	BUSINESS NEED: to show users what they inputted in error and to not allow incorrect combination of information to be entered into the database

	SUMMARY/CONTEXT: As users can now add specialisms to a series, 
	we need to ensure all the validation rules are in place to ensure only the correct information is entered into the database

@RegressionTest @AssessmentEntriesUpload
Scenario: 4693_Upload an assessment entries file with errors for multiple specialism
Given I have logged in as a "CityAndGuildsAdmin" user
And I am on Registrations upload page
And I have a Academic Year in "4693RegistrationsData.csv"
And I upload "4693RegistrationsData.csv" file
And I update the registrations to the previous year
And I navigated Home page
And I am on Assessment entries upload page
And I have a active Assessment Series in "4693AssessmentEntryData.csv"
When I upload "4693AssessmentEntryData.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see all errors in the file for attempting to add invalid mulitple specialism entries
And I cleared the data in DB
