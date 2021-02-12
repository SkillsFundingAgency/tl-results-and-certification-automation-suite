Feature: 2266_Create Problem with Results upload page
	As a Results Editor
	I need to be able to understand that my assessment entries file has not uploaded
	So that I can take action

		
Background: 
Given I have logged in as a "ResultsEditor" user

@RegressionTest @Results
Scenario: 2266 Press the Back to Upload File button on the Results Upload Problem page
Given I navigate to the Results Upload Problem page
Then I will be shown the Results Problem with Upload Page
When I press the Back to upload file button
Then I am on results upload page



@RegressionTest @Results
Scenario: 2266 Press the Back to Results button on the Results Upload Problem page
Given I navigate to the Results Upload Problem page
Then I will be shown the Results Problem with Upload Page
When I press the Back to Results button
Then I should be navigated to Results dashboard page

