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
