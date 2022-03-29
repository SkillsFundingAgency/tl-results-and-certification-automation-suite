Feature: 5865_CheckTheRommOutcomeOS

As an AO, I need the ability to check the ROMM outcome prior to submitting the outcome, so that I can be confident I have provided accurate outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add specialism1 ROMM" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5865 Verify specialism check ROMM outcome page
	When I select "Yes, request Romm" radio button on add Romm Page
	And I select "Yes, the grade is the same" option in romm outcome page
	Then check the ROMM outcome page is shown
	And specialism details shown in check the Romm oucome page
	And back link takes me to add ROMM outcome page
