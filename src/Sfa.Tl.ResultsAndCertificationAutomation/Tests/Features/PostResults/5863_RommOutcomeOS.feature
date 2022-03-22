Feature: 5863_RommOutcomeOS

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated ROMM, so that the service is up-to-date with any ROMM outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add specialism1 ROMM" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5863 Verify specialism Romm outcome page
	When I select "Yes, request Romm" radio button on add Romm Page
	Then ROMM outcome page is shown
	And specialism details shown in Os Romm outcome page
	And back link takes me to add ROMM page
