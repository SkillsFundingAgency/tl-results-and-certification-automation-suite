Feature: 2137_UpdatingResultsDataAssessment
	As a R&C Portal user
	I need to be able to understand that I cannot remove an entry that has a result
	So that student data can be kept up to date

Background: 
Given I have logged in as a "SiteAdmin" user

@RegressionTest @AssessmentEntries
Scenario: 2137_ No Remove entry link in assessment if result added from bulk upload 
And I uploaded following files
| Registration                     | Assessment                     | Result                      |
| RegistrationsValidDataSingle.csv | AssessmentUploadSingleData.csv | ResultsUploadSingleData.csv |
When I search search Assessment entry for the Uln
| Uln        |
| 9900000001 |
Then I should not see Remove Entry link in the assessment details page

@RegressionTest @AssessmentEntries
Scenario: 2137_ No Remove entry link in assessment if result added manually
And I have a registration with result
When I search the assessment entry
Then I should not see Remove Entry link in the assessment details page

@RegressionTest @AssessmentEntries
Scenario: 2137_ Remove entry link in assessment if result removed from bulk upload 
And I uploaded following files
| Registration                     | Assessment                     | Result                      |
| RegistrationsValidDataSingle.csv | AssessmentUploadSingleData.csv | ResultsUploadSingleData.csv |
And I updated the result with Not received for the Uln
| Uln        |
| 9900000001 |
When I search search Assessment entry for the Uln
| Uln        |
| 9900000001 |
Then I should see Remove Entry link for the learner in assessment details page

@RegressionTest @AssessmentEntries
Scenario: 2137_ Display Remove entry link in assessment if result removed manually
And I have a registration with result
And I changed the result to Not received for that learner
When I search the assessment entry
Then I should see Remove Entry link for the learner in assessment details page


