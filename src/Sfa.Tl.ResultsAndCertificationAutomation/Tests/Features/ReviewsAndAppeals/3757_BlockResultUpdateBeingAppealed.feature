Feature: 3757_BlockResultUpdateBeingAppealed
	As an AO with a results editor role
	I need to be stopped from bulk uploading a results file which contains a ULN that is being appealed
	So that I can be sure the correct grade is recorded in the database for that student

Background: 
Given I have logged in as a "ResultsEditor" user

@RegressionTest @ReviewsAndAppeals
Scenario: 3757 Validate upload result update for a appealed state
And I have a registration in Appealed state for this Uln
| Uln        |
| 9900000301 |
And I am on results upload page
And I upload "3757BlockResultUpdate.csv" result file
And I click on "Submit" button
When I download the Results error file and verify
Then I should see update is blocked validation error in the results downloaded file
And I cleared the data in DB
