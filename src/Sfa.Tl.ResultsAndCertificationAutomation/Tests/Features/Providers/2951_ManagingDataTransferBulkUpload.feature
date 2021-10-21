Feature: 2951_ManagingDataTransferBulkUpload
	As a Provider
	I need IP data to be maintained when learners change Providers
	So that learner data can be kept up to date

Background:
Given I have logged in as a "RegistrationEditor" user
And I cleared the data in DB
And I have a registration in Db with IP against Dudley provider
| Uln        |
| 9900000011 |
And I am on Registration upload page
And I have a Academic Year in "2951RegistrationsValidDataBarnsley.csv"
And I upload "2951RegistrationsValidDataBarnsley.csv" file
And I click on the Sign Out link
And I have logged in as a "ProviderBarnsleyPA" user
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@RegressionTest @Provider
Scenario: 2951_Learner record shows active IP with new provider 
When I search the learner record with Uln
| Uln        |
| 9900000011 |
Then I should see IP record for Uln is active for new provider
| Uln        |
| 9900000011 |
And I have deleted LRS data from the database for the Uln
| Uln        |
| 9900000011 |