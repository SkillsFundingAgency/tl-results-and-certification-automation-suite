Feature: 5870_RommOutcomeRecordedOS

As an AO, I want to be informed when a ROMM outcome has been successfully recorded, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add specialism1 ROMM" button in post result learner details page
And I select "Yes, request Romm" radio button on add Romm Page

@RegressionTest @PostResults
Scenario: 5870 Record specialism Romm outcome with new grade
	And I select "Yes, the grade has changed" option in romm outcome page
	And I select "Grade Pass" grade and click continue in change the grade after Romm page
	When I click submit button in check the Romm outcome page
	Then Romm outcome recorded for specialism success message is shown

@RegressionTest @PostResults
Scenario: 5870 Record specialism Romm outcome with same grade
	And I select "Yes, the grade is the same" option in romm outcome page
	When I click submit button in check the Romm outcome page
	Then Romm outcome recorded for specialism success message is shown
