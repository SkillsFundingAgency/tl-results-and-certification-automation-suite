Feature: UserAccessLevels
	As a User
	I need see the access level accross services
	So that I protect the service being misused

@SmokeTest
Scenario: Access level for Site Administrator
Given I have logged in as a "SiteAdmin" user
Then I should get access to all services

@SmokeTest
Scenario: Access level for All Users
Given I have logged in as a "AllUser" user
Then I should get access to all services

@SmokeTest
Scenario: Access level for TLevel Reviewer
Given I have logged in as a "Reviewer" user
Then I should get acces to TLevels and Accounts pages only

@SmokeTest
Scenario: Access level for Provider Editor
Given I have logged in as a "Provider" user
Then I should get access to Provider and Account pages only

@SmokeTest
Scenario: Access level for Registration Editor
Given I have logged in as a "RegistrationEditor" user
Then I should get access to Registrations and Account pages only

@SmokeTest
Scenario: Access level for No Role Service User
Given I have logged in as a "NoRoleNoService" user
Then I should see Access Denied error for all pages

@SmokeTest
Scenario: Access level for No Service User
Given I have logged in as a "NoServiceTole" user
Then I should not get acces to TLevel Services
