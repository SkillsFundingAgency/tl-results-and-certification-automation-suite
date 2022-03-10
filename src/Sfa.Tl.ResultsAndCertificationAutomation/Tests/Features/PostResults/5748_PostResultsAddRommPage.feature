Feature: 5748_PostResultsAddRommPage

As an AO, I need the ability to inform ESFA that the learner has requested a ROMM of a grade, so that overall grade is not calculated until result has been through a ROMM.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5748 Verify add ROMM page
	When I click "Add core ROMM" button in post result learner details page
	Then Add a ROMM page is shown
	And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5748 Error validation add ROMM page
When I click "Add core ROMM" button in post result learner details page
And I click on Continue button without selecting ROMM option
Then error message shown on add romm page
| Error message                                                   |
| Select ‘yes’ if the learner has requested a ROMM for this grade |
And error summary shown on add romm page
| Error summary                                                   |
| Select ‘yes’ if the learner has requested a ROMM for this grade |