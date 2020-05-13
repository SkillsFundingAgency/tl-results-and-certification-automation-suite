Feature: AccessibilityStatement
	In order to see Accessibility statement
	As a Tlevel
	I want to access Accessibility satement in all Tlevel pages 

@SmokeTest
Scenario: Accessibility statement from start page
	Given Tlevel start page
	When I click on Accessibility statement link
	Then I should see Accessibility stement details in new tab in the browser

@SmokeTest
Scenario: Accesiiblity Statement from Dashboard Page
Given I have logged in as a "SiteAdmin" user
When I click on Accessibility statement link
Then I should see Accessibility stement details in new tab in the browser
