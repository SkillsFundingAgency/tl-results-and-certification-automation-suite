Feature: 1865_AssessmentEntriesUploadStage1Validations
	As a Registrations Editor
	I need to upload assessment entry data in bulk
	So that entry data can be kept up to date

Background:
Given I have logged in as a "RegistrationEditor" user
And I am on Assessment entries upload page

@RegressionTest @AssessmentEntriesUpload
Scenario: Verify mandatory field validation
When I click on "Upload" button
Then I should see following error message
| Error message                         |
| Select a file to upload |
And I should see the following error summary message
| Error summary							|
| Select a file to upload |

@RegressionTest @AssessmentEntriesUpload
Scenario: Upload non csv file
When I upload "AssessmentEntryStage1InvalidFileType.xlsx" file
And I click on "Upload" button
Then I should see following error message
| Error message                                 |
| File extension not valid - must be a CSV file |
And I should see the following error summary message
| Error summary                                 |
| File extension not valid - must be a CSV file |

@RegressionTest @AssessmentEntriesUpload
Scenario: Upload file with max number of rows
When I upload "AssessmentEntryStage1MaxNoOfRows.csv" file
And I click on "Upload" button
Then I should see following error message
| Error message                                                                 |
| File must contain assessment entries for between one and 10,000 registrations |
And I should see the following error summary message
| Error summary                                                                 |
| File must contain assessment entries for between one and 10,000 registrations |
