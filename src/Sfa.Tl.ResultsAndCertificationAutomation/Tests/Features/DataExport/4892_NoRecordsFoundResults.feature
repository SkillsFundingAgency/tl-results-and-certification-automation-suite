Feature: 4892_NoRecordsFoundResults
	As a Result Editor
	I need to see a page to show export results when no data
	So that I can change search criteria

Background: 
Given I have logged in as a "PearsonSiteAdmin" user
And I have deleted all data for "Pearson"
And I click on "Results" link


@RegressionTest @DataExport
Scenario: 4892_No result records found page
When I click on "Download results data" link
Then No result records found page is displayed
And click on Add Result will take to Results page