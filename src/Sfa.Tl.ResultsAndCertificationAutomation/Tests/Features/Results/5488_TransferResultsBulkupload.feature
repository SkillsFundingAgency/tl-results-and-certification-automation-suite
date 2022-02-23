Feature: 5488_TransferResultsBulkupload

As an AO, I need all the active specialism results entries for a learner transferred via the bulk upload functionality to be updated to the new provider, so that the learner record is updated accordingly. 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have below registration with core and specialism assessments results
| Uln        |
| 9000000001 |
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "5330_RegistrationsValid.csv" file

@RegressionTest @Results
Scenario: 5488 Transfer results from bulkupload
When I search the learner result
| Uln        |
| 9900000001 |
Then I should see newly transferred Provider in learner detail page with original Grade
| Provider                    | Grade |
| Automation Test2			  | A*    |
