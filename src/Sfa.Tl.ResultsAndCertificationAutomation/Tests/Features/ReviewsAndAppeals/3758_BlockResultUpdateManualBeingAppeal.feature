Feature: 3758_BlockResultUpdateManualBeingAppeal
	As an AO with a results editor role
	I need to be stopped from bulk uploading a results file which contains a ULN that is being appealed
	So that I can be sure the correct grade is recorded in the database for that student

Background: 
Given I have logged in as a "ResultsEditor" user

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3758 Validate manual result update for a appealed state
And I have registration in appeal state
When I search the Uln to update result
Then I should see a being appealed message on the page
And Search again button takes me to search result page
And the registration for this test is deleted