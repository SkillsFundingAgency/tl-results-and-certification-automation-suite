Feature: 4170 Journey Improvements - Bulk upload - Assessment entry success
	Verify the changes to the 

Background:
Given I have logged in as a "AllUser" user

@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4170_Assessment upload Success - Verify Upload another file button
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page
When I click the Upload another file button
Then I am shown the Assessment entries upload page
And I cleared the data in DB

@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4170_Assessment upload Success - Verify Back to home button
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page
When I click the Back to home button
Then I should be navigated back to home page
And I cleared the data in DB

@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4170_Assessment upload Success - Verify manage individual registrations link
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page
When I click the manage individual assessments link
Then the Assessments Search for a learner page is shown
And I cleared the data in DB


@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4170_Assessment upload Success - Verify upload another multiple assessments file link
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page
When I click the upload another multiple assessments file link
Then I am shown the Assessment entries upload page
And I cleared the data in DB

@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4170_Assessment upload Success - Verify add results link
Given I am on Registrations upload page
And I upload "RegistrationsDataForAssessments.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "AssessmentEntrySuccessfulData.csv" file
And I click on "Upload" button
Then I should see Upload success page
When I click the add results link
Then I should be navigated to Results dashboard page
And I cleared the data in DB
