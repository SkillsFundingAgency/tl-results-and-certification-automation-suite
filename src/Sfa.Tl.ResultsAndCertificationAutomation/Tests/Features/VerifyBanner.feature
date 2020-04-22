Feature: VerifyBanner
	In order to comply with process
	As a Tlevel user
	I want to see Banner information in all Tlevel pages

@Sprint5
Scenario: Veryfy Banner in Tlevel start page
	Given I have login as a Admin user
	When I looked at page banner
	Then I should page Banner information on top of the page
