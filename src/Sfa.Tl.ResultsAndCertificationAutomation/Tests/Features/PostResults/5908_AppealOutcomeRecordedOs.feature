Feature: 5908_AppealOutcomeRecordedOs

As an AO, I want to be informed when a ROMM outcome has been successfully recorded, so that I can be confident that I have updated the record.


Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 5908_Specialism appeal outcome recorded with new grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add specialism1 appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "Grade has changed" radio and click continue in do you know outcome appeal page
When I select "Grade Pass" grade and click continue in change the grade after an appeal page
And I click submit in appeal outcome page
Then appeal outcome recorded successfully messgage for OS shown on learner details page

@RegressionTest @PostResults
Scenario: 5908_Specialism appeal outcome recorded with same grade
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add specialism1 appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
And I select "The grade is the same" radio and click continue in do you know outcome appeal page
When I click submit in appeal outcome page
Then appeal outcome recorded successfully messgage for OS shown on learner details page

@RegressionTest @PostResults
Scenario: 5908_Specialism appeal outcome recorded with new grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add specialism1 outcome" button in post result learner details page
And I select "The grade has changed" in appeal outcome page
When I select "Grade Pass" grade and click continue in change the grade after an appeal page
And I click submit in appeal outcome page
Then appeal outcome recorded successfully messgage for OS shown on learner details page

@RegressionTest @PostResults
Scenario: 5908_Specialism appeal outcome recorded with same grade after appeal
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add specialism1 outcome" button in post result learner details page
And I select "No change to grade" in appeal outcome page
When I click submit in appeal outcome page
Then appeal outcome recorded successfully messgage for OS shown on learner details page