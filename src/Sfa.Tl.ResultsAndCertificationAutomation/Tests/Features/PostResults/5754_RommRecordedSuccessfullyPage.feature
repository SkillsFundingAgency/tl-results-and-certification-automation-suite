Feature: 5754_RommRecordedSuccessfullyPage

As an AO, I want to be informed when the ROMM has been submitted and successfully been updated, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page
And I click "Add core ROMM" button in post result learner details page
And I select "Yes, request Romm" radio button on add Romm Page

@RegressionTest @PostResults
Scenario: 5754 Romm recorded successfully
	When I select "No, grade outcome" option in romm outcome page
	Then Romm recorded success message is shown
	And button is changed to add outcome