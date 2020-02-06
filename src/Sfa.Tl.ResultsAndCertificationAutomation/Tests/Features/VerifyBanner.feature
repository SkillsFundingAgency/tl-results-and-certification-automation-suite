Feature: VerifyBanner
	In order to comply with process
	As a Tlevel user
	I want to see Banner information in all Tlevel pages

@Sprint5
Scenario: Veryfy Banner in Tlevel start page
	Given A Tlevel start page
	And I have clicked in Start Now button
	When i sign in with valid DfE Username and password
	Then I should page Banner information on top of the page
