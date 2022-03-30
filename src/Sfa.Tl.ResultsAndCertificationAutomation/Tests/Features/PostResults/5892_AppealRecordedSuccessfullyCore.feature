Feature: 5892_AppealRecordedSuccessfullyCore

As an AO, I want to be informed when the APPEAL has been submitted, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page

@RegressionTest @PostResults
Scenario: 5892 Verify appeal success banner by selecting no known outcome
When I select "No outcome" radio and click continue in do you know outcome appeal page
Then appeal recorded successfully messgage shown on learner details page

