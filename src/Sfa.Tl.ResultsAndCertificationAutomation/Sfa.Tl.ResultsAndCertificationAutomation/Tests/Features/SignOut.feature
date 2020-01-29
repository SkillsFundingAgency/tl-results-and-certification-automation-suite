Feature: SignOut
	In order to check log out 
	As a TLevel user
	I want to be redirect to TLevel start page

@Sprint5
Scenario: Veryfy Signout from Tlevel Dashboard page
	Given A Tlevel start page
	And I have clicked in Start Now button
	And i sign in with valid DfE Username and password
	When I click on Sign Out link
	Then I should be redirectted to Tlevel Start page
