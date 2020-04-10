Feature: SignOut
	In order to check log out 
	As a TLevel user
	I want to be redirect to TLevel start page

@Sprint5
Scenario: Veryfy Signout from Tlevel Dashboard page
	Given I have login as a Admin user
	When I click on Sign Out link
	Then I should be redirectted to Tlevel Start page

@Sprint7
Scenario: Verify Signout from Menu
Given I have login as a Admin user
When I click on Signout from Menu
Then I should be redirectted to Tlevel Start page
