Feature: 5130_Data Export : Download Data Page - Results (specialisms)
	As an AO
	I need the ability to download the result data to my local drive
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
And I am on Home page
And I am on results upload page


@RegressionTest @DataExport
Scenario: 5130_Download Specialism results data
And I upload results "5130_DataExportSpecialismResults.csv" file
And I am on results dashboard page
And I click on "Download results data" link
When I click on link containg specialism results data
Then the specialism results file should be downloaded
And there will only be a download links for Specialism results
And I have deleted all data for "CityAndGuilds"

@RegressionTest @DataExport
Scenario: 5130_verify both core and specialism download results links available if both results available
And I upload results "5130_DataExportCoreAndSpecialismResults.csv" file
And I am on results dashboard page
And I click on "Download results data" link
Then I will see download links for both Core and Specialism results download links
And I have deleted all data for "CityAndGuilds"