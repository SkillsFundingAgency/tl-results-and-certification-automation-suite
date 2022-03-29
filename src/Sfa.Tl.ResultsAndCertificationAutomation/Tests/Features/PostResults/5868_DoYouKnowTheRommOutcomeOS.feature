Feature: 5868_DoYouKnowTheRommOutcomeOS

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated ROMM, so that the service is up-to-date with any ROMM outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with ROMM recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5868 Verify do you know romm outcome specialism page
	When I click "Add specialism1 outcome" button in post result learner details page
	Then do you know the romm outcome for specialism page is shown
	And back link takes me to post result learner details page