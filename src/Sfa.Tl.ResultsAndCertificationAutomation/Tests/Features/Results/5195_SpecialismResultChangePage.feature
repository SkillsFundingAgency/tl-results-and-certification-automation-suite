Feature: 5195_SpecialismResultChangePage

As an AO, I need the ability to change an Occupational Specialism grade for a desired ULN, so that I can update the ULN record with the latest grade achieved.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on result details page

@RegressionTest @Results
Scenario: 5195 Change specialism result page
When I click 'Specialism1 change result' link
Then change specialism result page is open

@RegressionTest @Results
Scenario: 5195 Change specialism result page validations
And I click 'Specialism2 change result' link
When I click on "Change" button
Then I should see the following error message on change specialism result page
| Error Messages          |
| Please select the grade |
And I should see the following error summary messages
| Error Messages          |
| Please select the grade |