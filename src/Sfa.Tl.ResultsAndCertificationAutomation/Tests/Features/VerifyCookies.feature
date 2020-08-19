Feature: Verify Cookies
	In order to comply with process
	As a Tlevel user
	I want to see Cookies information in all Tlevel pages

Background: I have navigated to Tlevel start page

@SmokeTest
Scenario: Veryfy Cookie link in Tlevel start page
	Given Cookies link in start page
	When I click on Cookies link
	Then Cookies page should open

@SmokeTest
Scenario: Verify Cookie link in Tlevel Dashboard page
Given I have login as a Admin user
When i click on Cooke link in Dahsboard page
Then Cookeis page should open

@SmokeTest
Scenario: Verify Cookie banner in Tlevel start page
Given Tlevel Start page
When i click on View Cookie Policy button in the banner
Then Cookie policy page should open

@SmokeTest
Scenario: Verify Cookie banner in TLevel Dashboard page
Given I have logged in as a "AllUser" user
When i click on View Cookie Policy button in the banner
Then Cookie policy page should open

@SmokeTest
Scenario: Verify Cookie details in Cookie in Start page
Given Tlevel Start page
When I click on Cookies link
And I click on Find out more about cookies link in Cookies page
Then i should see Cookie details page

@SmokeTest
Scenario: Verify Cookie details in Cookie in Dashboard page
Given I have logged in as a "AllUser" user
When I click on Cookies link
And I click on Find out more about cookies link in Cookies page
Then i should see Cookie details page