Feature: 4896_DownloadDataResults
	As an AO
	I need the ability to download the result data to my local drive
	So that I can open the .csv file.
Background: 
Given I have logged in as a "PearsonSiteAdmin" user
And I have deleted all data for "Pearson"
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "4866_DataExportRegistrations.csv" file
And I changed academic year to "2020"
And I am on Home page
And I am on Assessment entries upload page
And I upload assessment "4895_DataExportAssessments.csv" file
And I am on assessment entries home page
And I am on Home page
And I am on results upload page
And I upload results "4896_DataExportResults.csv" file
And I am on results dashboard page

@RegressionTest @DataExport
Scenario: 4896_Download core results data
And I click on "Download results data" link
When I click on link containg core results data
Then core results file should be downloaded
And I have deleted all data for "Pearson"