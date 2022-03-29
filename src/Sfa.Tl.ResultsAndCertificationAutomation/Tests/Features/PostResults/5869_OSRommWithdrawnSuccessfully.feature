Feature: 5869_OSRommWithdrawnSuccessfully

As an AO, I want to be informed when an existing ROMM has been successfully withdrawn, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with ROMM recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5869 Verify specialism Romm withdrawn successfully
	When I click "Add specialism1 outcome" button in post result learner details page
	And I select "ROMM withdrawn" on do you know romm outcome page
	Then Romm withdrawn successfully for specialism message is shown
	