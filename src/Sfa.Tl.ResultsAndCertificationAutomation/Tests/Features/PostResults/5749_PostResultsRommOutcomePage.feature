Feature: 5749_PostResultsRommOutcomePage

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated ROMM, so that the service is up-to-date with any ROMM outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5749 Verify ROMM outcome page
	When I select "Yes, request Romm" radio button on add Romm Page
	Then ROMM outcome page is shown
	And back link takes me to add ROMM page

@RegressionTest @PostResults
Scenario: 5749 Error validation ROMM outcome page
When I select "Yes, request Romm" radio button on add Romm Page
And I click continue button in Romm outcome page
Then error message shown on Romm outcome page
| Error message                                                    |
| Select whether the ROMM logged against this grade has an outcome |
And error summary shown on romm outcome page
| Error summary                                                    |
| Select whether the ROMM logged against this grade has an outcome |

@RegressionTest @PostResults
Scenario: 5749 Select No radio option in ROMM outcome page
When I select "Yes, request Romm" radio button on add Romm Page
And I select "No, grade outcome" option in romm outcome page
Then learner details page is shown