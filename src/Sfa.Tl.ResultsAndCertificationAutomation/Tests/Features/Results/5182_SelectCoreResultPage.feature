Feature: 5182_SelectCoreResultPage

As an AO, I need the ability to add a core component grade for the desired ULN, so that I can update the ULN record with the determined grade.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @Results
Scenario: 5182 route to learner assessment page when no core assessment
Given I have a registration with no Core and Specialism assessments
And I am on result details page
When I click 'Add core assessment' link
Then learner assessment entries page is open

@RegressionTest @Results
Scenario: 5182 route to learner assessment page when no specialism assessment
Given I have a registration with no Core and Specialism assessments
And I am on result details page
When I click 'Add specialism assessment' link
Then learner assessment entries page is open

@RegressionTest @Results
Scenario: 5182 Add Core results page
Given I have a registration with core and specialism assessments
And I am on result details page
When I click 'Core add result' link
Then I should see add result page for Core
And back link should take me to learner result page

@RegressionTest @Results
Scenario: 5182 Add Core results page validation
Given I have a registration with core and specialism assessments
And I am on result details page
When I click 'Core add result' link
And I click on "Submit" button
Then I should see the following error message on Core result page
| Error Messages |
| Please select the grade    |
And I should see the following error summary messages
| Error Messages |
| Please select the grade    |
