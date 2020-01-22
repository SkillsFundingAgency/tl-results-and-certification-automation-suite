Feature: VerifyPrivacy
	In order to comply with process
	As a Tlevel user
	I want to see Privacy information in all Tlevel pages

Background: I have navigated to Tlevel start page

@Sprint5
Scenario: Veryfy Privacy link in Tlevel start page
	Given Privacy link in start page
	When I click on Privacy link
	Then Privacy page should open

@Sprint5
Scenario: Verify Privacy link in Tlevel Dashboard page
Given Tlevel Start page
When user logged in with valid user name and password
And click on Privacy link in Dahsboard page
Then Privacy page should open
