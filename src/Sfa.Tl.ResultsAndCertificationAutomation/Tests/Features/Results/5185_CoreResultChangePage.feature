Feature: 5185_CoreResultChangePage

As an AO, I need the ability to change a core component grade for a desired ULN, so that I can update the ULN record with the latest grade achieved.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on result details page

@RegressionTest @Results
Scenario: 5185 Change core result page
And I click 'Core change result' link
Then change core result page is open
And I click on "Change" button
Then I should see the following error message on change core result page
| Error Messages |
| Please select the grade    |
And I should see the following error summary messages
| Error Messages |
| Please select the grade    |