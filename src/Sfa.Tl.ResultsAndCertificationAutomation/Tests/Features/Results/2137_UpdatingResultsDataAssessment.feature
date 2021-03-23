Feature: 2137_UpdatingResultsDataAssessment
	As a R&C Portal user
	I need to be able to understand that I cannot remove an entry that has a result
	So that student data can be kept up to date

Background: 
Given I have logged in as a "SiteAdmin" user
And I cleared the data in DB

@RegressionTest @Results
Scenario: 2137_ No Remove entry link in assessment if result added from bulk upload 
And I uploaded following files
| Registration                     | Assessment                     | Result                      |
| RegistrationsValidDataSingle.csv | AssessmentUploadSingleData.csv | ResultsUploadSingleData.csv |
When I search Assessment entry for the Uln
| Uln        |
| 9900000001 |
Then Remove Entry link should not exists in the assessment details page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 2137_ No Remove entry link in assessment if result added manually
And I have a registration with result
When I search learner in Assessment entry
Then Remove Entry link should not exists in the assessment details page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 2137_ Display Remove entry link in assessment if result removed from bulk upload 
And I uploaded following files
| Registration                     | Assessment                     | Result                      |
| RegistrationsValidDataSingle.csv | AssessmentUploadSingleData.csv | ResultsUploadSingleData.csv |
And I removed the result by selecting Not received
| Uln        |
| 9900000001 |
When I search Assessment entry for the Uln
| Uln        |
| 9900000001 |
Then Remove Entry link should exists in the assessment details page
And I cleared the data in DB

@RegressionTest @Results
Scenario: 2137_ Display Remove entry link in assessment if result removed manually
And I have a registration with result
And I removed the result for the uln by selecting not received
When I search learner in Assessment entry
Then Remove Entry link should exists in the assessment details page
And the registration for this test is deleted