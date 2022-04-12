Feature: 5888_DoYouKnowTheAppealOutcomeCore

 As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated APPEAL, so that the service is up-to-date with any APPEAL outcome. 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5888 Verify do you know core appeal outcome page
	When I select "Yes, request appeal" radio button on add appeal Page
	Then do you know the appeal outcome page is shown
	And core details shown on do you know the core appeal page
	And back link takes me to add an appeal page

@RegressionTest @PostResults
Scenario: 5888 Error validation do you know core appeal outcome page
When I select "Yes, request appeal" radio button on add appeal Page
And I click continue button in Romm outcome page
Then error message shown on appeal outcome page
| Error message                                                      |
| Select whether the appeal raised against this grade has an outcome |
And error summary shown on appeal outcome page
| Error summary                                                      |
| Select whether the appeal raised against this grade has an outcome |