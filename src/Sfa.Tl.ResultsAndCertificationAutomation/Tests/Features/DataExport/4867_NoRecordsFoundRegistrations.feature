Feature: 4867_NoRecordsFoundRegistrations
	As a Registrations Editor
	I need to see a page to show export results when no data
	So that I can change search criteria

Background: 
Given I have logged in as a "PearsonSiteAdmin" user
And I have deleted all data for "Pearson"
And I click on "Registrations" link


@RegressionTest @DataExport
Scenario: 4867_No registration records found page
When I click on "Download registrations data" link
Then No records found page is displayed
And click on Add Registration will take to Registrations page