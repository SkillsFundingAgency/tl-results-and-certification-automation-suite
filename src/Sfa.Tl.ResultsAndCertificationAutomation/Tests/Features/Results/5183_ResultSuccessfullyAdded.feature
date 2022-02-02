Feature: 5183_ResultSuccessfullyAdded

As an AO, I want to be informed when the result has successfully been added, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments
And I am on result details page

@RegressionTest @Results
Scenario: 5183 Core result added successfully
And I click 'Core add result' link
When I select 'Grade A*'
And I click on "Submit" button
Then 'result has been added' message is shown
