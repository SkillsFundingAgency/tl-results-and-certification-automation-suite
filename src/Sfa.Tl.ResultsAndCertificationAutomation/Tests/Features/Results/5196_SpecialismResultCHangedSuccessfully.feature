Feature: 5196_SpecialismResultCHangedSuccessfully

As an AO, I want to be informed when the OS result has successfully been updated, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on result details page

@RegressionTest @Results
Scenario: 5196 Core result changed successfully
	And I click 'Specialism2 change result' link
	When I select 'Grade Pass'
	And I click on "Change" button
	Then 'result has been changed' message is shown
