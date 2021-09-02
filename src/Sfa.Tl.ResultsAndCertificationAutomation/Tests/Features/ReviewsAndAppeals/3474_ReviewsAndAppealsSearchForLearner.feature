Feature: 3474_ReviewsAndAppealsSearchForLearner
	As an AO with a result editor
	I need to see a search page for the learner
	So that I can search a learner for reviews and appeals

Background: 
Given I have logged in as a "ResultsEditor" user
And I click on "Appeals" link

@RegressionTest @ReviewsAndAppeals
Scenario: 3474 Verify search for learner page
When I click on "Continue" button in start page
Then I should see reviews and appeals search for learner page
And clicking on Reviews and appeals breadcrumb takes me reviews start page
And clicking on home breadcrumb takes me to home page

@RegressionTest @ReviewsAndAppeals
Scenario: 3474 Verify mandatory field validation
When I click on "Continue" button in start page
And I click on Search button
Then I should see following error message in Reviews and Appeals page
| Error message              |
| Enter a ULN with 10 digits |
And I should see the following error summary message in Reviews and Appeals page
| Error summary              |
| Enter a ULN with 10 digits |

@RegressionTest @ReviewsAndAppeals
Scenario: 3474 Validate data
When I click on "Continue" button in start page
And I enter "ABC12345"
And I click on Search button
Then I should see following error message in Reviews and Appeals page
| Error message              |
| Enter a valid 10-digit ULN |
And I should see the following error summary message in Reviews and Appeals page
| Error summary              |
| Enter a valid 10-digit ULN |
