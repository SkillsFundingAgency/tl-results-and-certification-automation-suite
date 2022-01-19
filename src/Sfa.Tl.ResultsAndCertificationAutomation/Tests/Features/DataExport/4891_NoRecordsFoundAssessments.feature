Feature: 4891_NoRecordsFoundAssessments
	As a Assessment Editor
	I need to see a page to show export results when no data
	So that I can change search criteria

Background: 
Given I have logged in as a "PearsonSiteAdmin" user
And I have deleted all data for "Pearson"
And I click on "Assessments" link


@RegressionTest @DataExport
Scenario: 4891_No Assessment records found page
When I click on "Download assessments data" link
Then No assessment records found page is displayed
And click on Add assessments will take to assessment page