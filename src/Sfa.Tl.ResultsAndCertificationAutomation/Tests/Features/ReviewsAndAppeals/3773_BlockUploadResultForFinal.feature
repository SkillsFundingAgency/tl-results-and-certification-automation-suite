Feature: 3773_BlockUploadResultForFinal
	As an AO with a results editor role
	I need to be stopped from bulk uploading a results file which contains a ULN that is final
	So that I can be sure the correct grade is recorded in the database for that student

Background: 
Given I have logged in as a "ResultsEditor" user

@RegressionTest @ReviewsAndAppeals
Scenario: 3773 Validate upload result update for a final state
And I have a registration in Final state for this Uln
| Uln        |
| 9900000302 |
And I am on results upload page
And I upload "3773BlockResultForFinal.csv" result file
And I click on "Upload" button
When I download the Results error file and verify
Then I should see update is blocked for final in the results downloaded file
And I cleared the data in DB