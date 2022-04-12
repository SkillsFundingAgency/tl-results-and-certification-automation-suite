Feature: 5890_CheckAppealOutcomeCore

As an AO, I need the ability to check the appeal outcome prior to submitting the outcome, so that I can be confident I have provided accurate outcome

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 5890_Check core outcome appeal with new grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "Grade has changed" radio and click continue in do you know outcome appeal page
When I select "Grade D" grade and click continue in change the grade after an appeal page
Then check the appeal outcome page is shown
And Core details shown on check the appeal outcome page
And back link takes me to change the grade after appeal page

@RegressionTest @PostResults
Scenario: 5890_Check core outcome appeal with same grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
When I select "The grade is the same" radio and click continue in do you know outcome appeal page
Then check the appeal outcome page is shown
And Core details shown on check the appeal outcome page
And back link takes me to do you know the appeal outcome page

@RegressionTest @PostResults
Scenario: 5890_Change the core grade With new grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add core outcome" button in post result learner details page
And I select "The grade has changed" in appeal outcome page
When I select "Grade D" grade and click continue in change the grade after an appeal page
Then check the appeal outcome page is shown
And Core details shown on check the appeal outcome page
And back link takes me to change the grade after appeal page

@RegressionTest @PostResults
Scenario: 5890_Change the core grade with same grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add core outcome" button in post result learner details page
And I select "No change to grade" in appeal outcome page
Then check the appeal outcome page is shown
And Core details shown on check the appeal outcome page
And back link takes me to add appeal outcome page
