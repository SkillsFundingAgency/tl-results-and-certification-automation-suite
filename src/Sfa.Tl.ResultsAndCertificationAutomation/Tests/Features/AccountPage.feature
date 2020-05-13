Feature: AccountPage
	In order to update user details
	As a TLevel user
	I want to access Profile page to update details

@SmokeTest
Scenario: Account Page for Admin user
	Given I have logged in as a "SiteAdmin" user
	When I click on Account link
	Then DfE Profile page should open

@SmokeTest
Scenario: Account Page for all users
	Given I have logged in as a "AllUser" user
	When I click on Account link
	Then DfE Profile page should open
@SmokeTest
Scenario: Account Page for Reviewer and Provider user
	Given I have logged in as a "ReviewerAndProvider" user
	When I click on Account link
	Then DfE Profile page should open
@SmokeTest
Scenario: Account Page for Reviewer user
	Given I have logged in as a "Reviewer" user
	When I click on Account link
	Then DfE Profile page should open
@SmokeTest
Scenario: Account page for Provider user
	Given I have logged in as a "Provider" user
	When I click on Account link
	Then DfE Profile page should open
