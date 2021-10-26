Feature: 2134_ResultsTransferBulkUpload
	As a R&C Portal user
	I need results data to be updated after a transfer occurs
	So that student data can be kept up to date

Background: 
Given I have logged in as a "SiteAdmin" user
And I cleared the data in DB
And I uploaded following files
| Registration                     | Assessment                     | Result                      |
| RegistrationsValidDataSingle.csv | AssessmentUploadSingleData.csv | ResultsUploadSingleData.csv |

@Ignore @RegressionTest @Results
Scenario: 2134_Transfer result from bulk upload
And I am on Registration upload page
And I upload "RegistrationForTransfer.csv" file
And I am on results dashboard page
When I search the learner result
| Uln        |
| 9900000001 |
Then I should see newly transferred Provider in learner detail page with original Grade
| Provider                    | Grade |
| Automation Test2			  | A*    |
And I cleared the data in DB