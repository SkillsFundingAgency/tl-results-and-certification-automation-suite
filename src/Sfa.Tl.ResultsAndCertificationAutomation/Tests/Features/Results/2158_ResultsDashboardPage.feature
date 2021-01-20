Feature: 2158_ResultsDashboardPage
As a Results Editor
I need to understand where to navigate on the system
So that I can carry out my duties

Background: 
Given I have logged in as a "ResultsEditor" user

@RegressionTest @Results
Scenario: 2158_Result dashboard page
When I click on results link
Then I should be navigated to Results dashboard page
And I should see Upload results file and Search for learner links

@RegressionTest @Results
Scenario: 2158_Back to home page
When I click on results link
And I click on "Home" in breadcrumbs
Then I should be navigated back to home page