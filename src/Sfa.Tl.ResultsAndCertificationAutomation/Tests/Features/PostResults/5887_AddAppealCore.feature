Feature: 5887_AddAppealCore

As an AO, I need the ability to inform ESFA that the learner has requested an APPEAL of a grade, so that overall grade is not calculated until result has been through an appeal.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with Romm outcome recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5887 Verify add an appeal page
	When I click "Add core appeal" button in post result learner details page
	Then Add an appeal page is shown
	And core details shown in learner details
	And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5887 Error validation add an appeal page
When I click "Add core appeal" button in post result learner details page
And I click on Continue button without selecting ROMM option
Then error message shown on add appeal page
| Error message                                                   |
| Select ‘yes’ if the learner has raised an appeal against this grade |
And error summary shown on add appeal page
| Error summary                                                   |
| Select ‘yes’ if the learner has raised an appeal against this grade |

@RegressionTest @PostResults
Scenario: 5887 Select No radio button in add appeal page
When I click "Add core appeal" button in post result learner details page
And I select "No, request appeal" radio button on add appeal Page
Then learner details page is shown