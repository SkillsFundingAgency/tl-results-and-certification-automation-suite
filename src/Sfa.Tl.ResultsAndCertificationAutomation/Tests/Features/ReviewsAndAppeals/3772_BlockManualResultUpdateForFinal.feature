Feature: 3772_BlockResultUpdateFor Final
	As an AO with a results editor role
	I need to be stopped from updating a result one the grade status has changed to final
	So that I can be sure the correct grade is recorded in the database for that student

Background: 
Given I have logged in as a "ResultsEditor" user

@RegressionTest @ReviewsAndAppeals
Scenario: 3772 Validate manual result update for a Final state
And I have registration in final state
When I search the Uln to update result
Then I should see a Final tag on the page
And Search again button takes me to search result page
And the registration for this test is deleted