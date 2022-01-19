Feature: 4866_DownloadDataRegistrations
	As an AO
	I need the ability to download the registrations data to my local drive
	So that I can open the .csv file.

Background: 
Given I have logged in as a "PearsonSiteAdmin" user
And I have deleted all data for "Pearson"
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "4866_DataExportRegistrations.csv" file
And I have moved registraion to withdrawn state
And I changed academic year to "2020"
And I am on registration home page

@RegressionTest @DataExport
Scenario: 4866_Download registrations data
And I click on "Download registrations data" link
When I click the link containing 'Registrations data'
Then registration file should be downloaded
And I have deleted all data for "Pearson"