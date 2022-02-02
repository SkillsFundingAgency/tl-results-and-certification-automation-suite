Feature: 5192_SelectSpecialismResultPage

As an AO, I need the ability to add an Occupational Specialism grade for the desired ULN, so that I can update the ULN record with the determined grade.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments
And I am on result details page

@RegressionTest @Results
Scenario: 5192 Add specialism result page
	When I click 'Specialism1 add result' link
	Then I should see add result page for Assessment
	And back link should take me to learner result page

@RegressionTest @Results
Scenario: 5192 Add specialism result page validation
	When I click 'Specialism1 add result' link
	And I click on "Submit" button
	Then I should see the following error message on specialism result page
	| Error Messages          |
	| Please select the grade |
	And I should see the following error summary messages
	| Error Messages          |
	| Please select the grade |