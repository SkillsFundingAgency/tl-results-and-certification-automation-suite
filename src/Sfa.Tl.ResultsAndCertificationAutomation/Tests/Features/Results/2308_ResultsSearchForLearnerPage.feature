Feature: 2308 Create Search for a learner page (results)
As a Results Editor
I need to be able to search for a learner
So that I can manually add results data to the learner


@RegressionTest @Results
Scenario: 2308_Verify Results Search for a Learner page when logged in as Results Editor
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page

@RegressionTest @Results
Scenario: 2308_validate the error messages on the Results Search for a Learner page 
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page
When I enter an invalid ULN as "123456789"
Then I will see an error message stating Invalid ULN
When I enter an invalid ULN as "ABC 123"
Then I will see an error message stating Invalid ULN
When I enter an invalid ULN as " "
Then I will see an error message stating Enter a ULN

@RegressionTest @Results
Scenario: 2308_validate breadcrumbs on the Results Search for a Learner page 
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page
When I click on the Results breadcrumb link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
And I click on the Home breadcrumb link
Then I am taken to the home page

