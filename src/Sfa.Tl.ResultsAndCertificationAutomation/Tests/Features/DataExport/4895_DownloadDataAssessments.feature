Feature: 4895_DownloadDataAssessments
	As an AO
	I need the ability to download the assessment data to my local drive
	So that I can open the .csv file.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have deleted all data for "CityAndGuilds"
And I click on "Registrations" link
And I click on "Upload multiple registrations" link
And I upload "4866_DataExportRegistrations.csv" file
And I changed academic year to "2020"
And I am on Home page
And I am on Assessment entries upload page
And I upload assessment "4895_DataExportAssessments.csv" file
And I am on assessment entries home page

@RegressionTest @DataExport
Scenario: 4895_Download core assessment data
And I click on "Download assessments data" link
When I click on link containg "Core assessments data"
Then core assessment file should be downloaded
And I have deleted all data for "CityAndGuilds"

@RegressionTest @DataExport
Scenario: 4895_Download specialism assessment data
And I click on "Download assessments data" link
When I click on link containg Specialism assessments data
Then specialism assessment file should be downloaded
And I have deleted all data for "CityAndGuilds"