Feature: 5986_CancelAppealOutcomeCore

 As an AO, I need the ability to cancel the appeal outcome prior to submitting the outcome, so that I can correct any errors I have made.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 5986_Core cancel appeal outcome with new grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "Grade has changed" radio and click continue in do you know outcome appeal page
When I select "Grade D" grade and click continue in change the grade after an appeal page
And I click cancel in check appeal outcome page
Then cancel appeal outcome page is shown
And Back link takes me to check appeal outcome page

@RegressionTest @PostResults
Scenario: 5986_Core cancel appeal outcome with same grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "The grade is the same" radio and click continue in do you know outcome appeal page
When I click cancel in check appeal outcome page
And I click on Continue button
Then error message shown on cancel appeal outcome page
| Error message                                                      |
| Please select whether you want to cancel the update to this appeal |
And error summary shown on cancel appeal outcome page
| Error summary                                                      |
| Please select whether you want to cancel the update to this appeal |

@RegressionTest @PostResults
Scenario: 5986_Core cancel appeal outcome with new grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add core outcome" button in post result learner details page
And I select "The grade has changed" in appeal outcome page
When I select "Grade D" grade and click continue in change the grade after an appeal page
And I click cancel in check appeal outcome page
Then cancel appeal outcome page is shown
And selecting yes radio option takes me to request to learner details page

@RegressionTest @PostResults
Scenario: 5986_Core cancel appeal outcome with same grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add core outcome" button in post result learner details page
And I select "No change to grade" in appeal outcome page
When I click cancel in check appeal outcome page
Then cancel appeal outcome page is shown
And selecting no radio option takes me to check appeal outcome page