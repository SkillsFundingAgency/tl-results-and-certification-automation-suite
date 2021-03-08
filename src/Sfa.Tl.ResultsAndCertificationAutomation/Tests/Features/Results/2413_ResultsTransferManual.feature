Feature: 2413_ResultsTransferManual
	As a R&C Portal user
	I need results data to be updated after a transfer occurs
	So that student data can be kept up to date

Background:
Given I have logged in as a "SiteAdmin" user
And I have a registration with result

@RegressionTest @Results
Scenario: 2413_Transfer result manual
And I search the registration
And I changed the provider
| Provider                    |
| Automation Test2 (99999902) |
And I am on results dashboard page
When I search the learner
Then I should see newly transferred Provider in learner detail page with original Grade
| Provider                    | Grade |
| Automation Test2 (99999902) | A     |
And the registration for this test is deleted