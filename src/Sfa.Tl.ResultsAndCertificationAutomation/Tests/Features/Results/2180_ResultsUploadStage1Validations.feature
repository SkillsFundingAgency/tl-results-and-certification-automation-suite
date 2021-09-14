Feature: 2180_ResultsUploadStage1Validations
	As a Results Editor
	I need to upload results data in bulk
	So that results data can be kept up to date

Background: 
Given I have logged in as a "ResultsEditor" user
And I am on results upload page

@RegressionTest @ResultsUpload
Scenario: Verify mandatory field validation
When I click on "Upload" button
Then I should see following error message in Results page
| Error message              |
| Select a file to upload |
And I should see the following error summary message in Results page
| Error summary				 |
| Select a file to upload |

@RegressionTest @ResultsUpload
Scenario: Upload non csv file
When I upload "AssessmentEntryStage1InvalidFileType.xlsx" file
And I click on "Upload" button
Then I should see following error message in Results page
| Error message                                 |
| File extension not valid - must be a CSV file |
And I should see the following error summary message in Results page
| Error summary                                 |
| File extension not valid - must be a CSV file |

@RegressionTest @ResultsUpload
Scenario: Upload file with max number of rows
When I upload "AssessmentEntryStage1MaxNoOfRows.csv" file
And I click on "Upload" button
Then I should see following error message in Results page
| Error message                                                      |
| File must contain results for between one and 10,000 registrations |
And I should see the following error summary message in Results page
| Error summary                                                      |
| File must contain results for between one and 10,000 registrations |

@RegressionTest @ResultsUpload
Scenario: Upload file more than 5MB
When I upload "RegistrationsStage1MaxFileSize.csv" file
And I click on "Upload" button
Then I should see following error message in Results page
| Error message                                  |
| File size too large – must be no more than 5MB |
And I should see the following error summary message in Results page
| Error summary                                  |
| File size too large – must be no more than 5MB |
