Feature: 5755_DoYouKnowTheRommOutcomePage

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated ROMM, so that the service is up-to-date with any ROMM outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with ROMM recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5755 Verify do you know romm outcome page
	When I click "Add core outcome" button in post result learner details page
	Then do you know thge romm outcome page is shown
	And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5755 Validate error on do you know romm outcome page
When I click "Add core outcome" button in post result learner details page
And I click continue without selecting any outcome option
Then error message shown on do you know romm outcome page
| Error message           |
| Select the ROMM outcome |
And error summary shown on do you know romm outcome page
| Error summary           |
| Select the ROMM outcome |
