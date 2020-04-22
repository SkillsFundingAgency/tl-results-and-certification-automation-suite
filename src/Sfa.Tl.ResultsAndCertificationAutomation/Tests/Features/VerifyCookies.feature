Feature: Verify Cookies
	In order to comply with process
	As a Tlevel user
	I want to see Cookies information in all Tlevel pages

Background: I have navigated to Tlevel start page

@Sprint5
Scenario: Veryfy Cookie link in Tlevel start page
	Given Cookies link in start page
	When I click on Cookies link
	Then Cookies page should open

@Sprint5
Scenario: Verify Cookie link in Tlevel Dashboard page
Given I have login as a Admin user
When i click on Cooke link in Dahsboard page
Then Cookeis page should open

@Sprint11
Scenario: Verify Cookie banner in Tlevel start page
Given Tlevel Start page
When i click on View Cookie Policy button in the banner
Then Cookie policy page should open

@Sprint11
Scenario: Verify Cookie banner in TLevel Dashboard page
Given I have logged in as a "AllUser" user
When i click on View Cookie Policy button in the banner
Then Cookie policy page should open