Feature: 5866_ChangeTheGradeAfterRommOS

AAs an AO, I need the ability to change the grade after a ROMM outcome, so that the learners record is updated with any change to the grade.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add specialism1 ROMM" button in post result learner details page
And I select "Yes, request Romm" radio button on add Romm Page

@RegressionTest @PostResults
Scenario: 5866 Verify Specialism change the grade after romm page
	When I select "Yes, the grade has changed" option in romm outcome page
	Then change the grade after a Romm page is shown
	And specialism details shown in change the grade romm page
	And back link takes me to add ROMM outcome page
