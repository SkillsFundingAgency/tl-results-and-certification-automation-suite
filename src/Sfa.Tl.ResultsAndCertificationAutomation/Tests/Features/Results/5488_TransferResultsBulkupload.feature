Feature: 5488_TransferResultsBulkupload

As an AO, I need all the active specialism results entries for a learner transferred via the bulk upload functionality to be updated to the new provider, so that the learner record is updated accordingly. 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have below registration with core and specialism assessments results
| Uln        |
| 9000000001 |
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "5488_RegistrationsTransfer.csv" file
And I am on Home page
And I click on "Results" link

@RegressionTest @Results
Scenario: 5488 Transfer results from bulkupload
When I search the learner result
| Uln        |
| 9000000001 |
Then I should see newly transferred Provider in learner detail page with all original Grades
| Provider         | Core_Grade | Assessment1_Grade | Assessment2_Grade |
| Barnsley College | A*         | Distinction       | Merit              |
