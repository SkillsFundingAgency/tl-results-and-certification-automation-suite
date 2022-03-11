Feature: 5752_ChangeTheGradeAfterRomm

As an AO, I need the ability to change the grade after a ROMM outcome, so that the learners record is updated with any change to the grade.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page
And I select "Yes, request Romm" radio button on add Romm Page

@RegressionTest @PostResults
Scenario: 5752 Verify change the grade after romm page
	When I select "Yes, the grade has changed" option in romm outcome page
	Then change the grade after a Romm page is shown
	And back link takes me to add ROMM outcome page

@RegressionTest @PostResults
Scenario: 5752 Validate errors on change the grade after romm page
When I select "Yes, the grade has changed" option in romm outcome page
And I click continue without selecting grade on change grade after romm page
Then error message shown on change grade after romm page
| Error message        |
| Select the new grade |
And error summary shown on change grade after romm page
| Error summary        |
| Select the new grade |