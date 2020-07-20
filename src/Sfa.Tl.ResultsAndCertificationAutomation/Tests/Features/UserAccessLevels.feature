Feature: UserAccessLevels
	As a User
	I need see the access level accross services
	So that I protect the service being misused

@SmokeTest
Scenario: Access level for Site Administrator
Given I have logged in as a "SiteAdmin" user
Then I should get access to all services