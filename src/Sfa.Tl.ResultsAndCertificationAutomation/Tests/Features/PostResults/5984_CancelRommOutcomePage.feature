Feature: 5984_CancelRommOutcomePage

As an AO, I need the ability to check the ROMM outcome prior to submitting the outcome, so that I can be confident I have provided accurate outcome.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5984 Verify Cancel Romm outcome page
When I select "Yes, request Romm" radio button on add Romm Page
And I select "Yes, the grade is the same" option in romm outcome page
And I click the Cancel link
Then cancel Romm outcome page is shown
And No, cancel radio option will takes me to check romm outcome page

@RegressionTest @PostResults
Scenario: 5984 Error validation on Cancel Romm outcome page
When I select "Yes, request Romm" radio button on add Romm Page
And I select "Yes, the grade is the same" option in romm outcome page
And I click the Cancel link
And I click the Continue button
Then error message shown on cancel romm outcome page
| Error message                                                    |
| Please select whether you want to cancel the update to this ROMM |
And error summary shown on cancel romm outcome page
| Error summary                                                    |
| Please select whether you want to cancel the update to this ROMM |
And yes, cancel radio will takes me to learner details page