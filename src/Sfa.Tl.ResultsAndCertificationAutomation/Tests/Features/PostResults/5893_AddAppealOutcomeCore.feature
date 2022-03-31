Feature: 5893_AddAppealOutcomeCore

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated appeal, so that the service is up-to-date with any appeal outcome

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with appeal recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5893_Verify core add appeal outcome page
When I click "Add core outcome" button in post result learner details page
Then add appeal outcome page is shown
And core details shown on add appeal outcome page
And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5893_Error validation on core add appeal outcome page
And I click "Add core outcome" button in post result learner details page
When I click continue without selecting any radio options
Then error message shown on add appeal outcome page
| Error message             |
| Select the appeal outcome |
And error summary shown on change appeal outcome page
| Error summary             |
| Select the appeal outcome |
