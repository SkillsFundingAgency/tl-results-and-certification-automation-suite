Feature: 5757_CoreRommOutcomeRecorded

As an AO, I want to be informed when a ROMM outcome has been successfully recorded, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page
And I select "Yes, request Romm" radio button on add Romm Page

@RegressionTest @PostResults
Scenario: 5757 Record Romm outcome with new grade
	And I select "Yes, the grade has changed" option in romm outcome page
	And I select "Grade D" grade and click continue in change the grade after Romm page
	When I click submit button in check the Romm outcome page
	Then Romm outcomne recorded success message is shown
	And button is changed to add apeal

@RegressionTest @PostResults
Scenario: 5757 Record Romm outcome with same grade
	And I select "Yes, the grade is the same" option in romm outcome page
	When I click submit button in check the Romm outcome page
	Then Romm outcomne recorded success message is shown
	And button is changed to add apeal