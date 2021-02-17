Feature: 2355_ChangeCoreResult
	As a Results Editor
	I need to be able to manually change the result for a learner
	So that the results data can be kept up to date

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I am on result details page

@RegressionTest @Results
Scenario: 2355_Change result
And I click on "Change" link in result page
And I change the grade
When I click on "Change" button
Then I should see result change successfull page

@RegressionTest @Results
Scenario: 2355_Click Change without changing result
And I click on "Change" link in result page
When I click on "Change" button
Then I should go back to learner result page

@RegressionTest @Results
Scenario: 2355_Change success deleting result
And I click on "Change" link in result page
And I change the grade to Not Reveved
When I click on "Change" button
Then I should see result change successfull message page
And I should go back to learner result page on clicking back to learner button

