Feature: 6030_CancelAppealOutcomeOs

As an AO, I need the ability to cancel the appeal outcome prior to submitting the outcome, so that I can correct any errors I have made.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 6030_Specialism cancel appeal outcome with new grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add specialism1 appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "Grade has changed" radio and click continue in do you know outcome appeal page
When I select "Grade Pass" grade and click continue in change the grade after an appeal page
And I click cancel in check appeal outcome page
Then cancel appeal outcome page is shown
And Back link takes me to check appeal outcome page

@RegressionTest @PostResults
Scenario: 6030_Specialism cancel appeal outcome with same grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add specialism1 outcome" button in post result learner details page
And I select "No change to grade" in appeal outcome page
When I click cancel in check appeal outcome page
Then cancel appeal outcome page is shown
And selecting no radio option takes me to check appeal outcome page