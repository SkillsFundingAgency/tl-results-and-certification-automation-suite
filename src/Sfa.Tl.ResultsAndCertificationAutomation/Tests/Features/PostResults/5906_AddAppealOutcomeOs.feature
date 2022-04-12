Feature: 5906_AddAppealOutcomeOs

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated APPEAL, so that the service is up-to-date with any APPEAL outcome. 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with appeal recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5906_Verify specialism add appeal outcome page
When I click "Add specialism1 outcome" button in post result learner details page
Then add appeal outcome page is shown
And specialism details shown on add appeal outcome page
And back link takes me to post result learner details page
