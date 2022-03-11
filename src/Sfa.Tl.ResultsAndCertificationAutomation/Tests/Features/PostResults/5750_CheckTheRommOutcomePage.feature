Feature: 5750_CheckTheRommOutcomePage

As an AO, I need the ability to check the ROMM outcome prior to submitting the outcome, so that I can be confident I have provided accurate outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5750 Verify check ROMM outcome page
	When I select "Yes, request Romm" radio button on add Romm Page
	And I select "Yes, the grade is the same" option in romm outcome page
	Then check the ROMM outcome page is shown
	And back link takes me to add ROMM outcome page