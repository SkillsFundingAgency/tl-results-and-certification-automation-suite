Feature: RegistrationsStage1Validations
	As a Registrations Editor
	I need to upload registrations entry data in bulk
	So that entry data can be kept up to date

Background:
Given I have logged in as a "RegistrationEditor" user
And I am on Registrations upload page

@RegressionTest @Registrations
Scenario: Verify registration mandatory field validation
When I click on "Submit" button
Then I should see following error message in upload registration page
| Error message                         |
| Select a file to upload |
And I should see the following error summary message in upload registration page
| Error summary							|
| Select a file to upload |

@RegressionTest @Registrations
Scenario: Upload registration non csv file
When I upload "RegistrationsUploadInvalidFile.xlsx" file
And I click on "Submit" button
Then I should see following error message in upload registration page
| Error message                   |
| The selected file must be a CSV |
And I should see the following error summary message in upload registration page
| Error summary                   |
| The selected file must be a CSV |

@RegressionTest @Registrations
Scenario: Upload registration max file size
When I upload "RegistrationsStage1MaxFileSize.csv" file
And I click on "Submit" button
Then I should see following error message in upload registration page
| Error message                                  |
| File size too large – must be no more than 5MB |
And I should see the following error summary message in upload registration page
| Error summary                                  |
| File size too large – must be no more than 5MB |

@RegressionTest @Registrations
Scenario: Upload registration max rows
When I upload "RegistrationsUploadMaxRows.csv" file
And I click on "Submit" button
Then I should see following error message in upload registration page
| Error message                                          |
| File must contain between one and 10,000 registrations |
And I should see the following error summary message in upload registration page
| Error summary                                          |
| File must contain between one and 10,000 registrations |

@RegressionTest @Registrations
Scenario: Upload registration png file
When I upload "Test.png" file
And I click on "Submit" button
Then I should see following error message in upload registration page
| Error message                   |
| The selected file must be a CSV |
And I should see the following error summary message in upload registration page
| Error summary                   |
| The selected file must be a CSV |