Feature: Provider
	In order to Add or Remove Tlevels from Provider page
	As a Provider User
	I want to see all functionality is working

@SmokeTest
Scenario: Find Provider
	Given I have logged in as a "Provider" user
	When I click on Provider link in the dashboard
	Then I shou land into Providers Page

@RegressionTest
Scenario: Add Single TLevel
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select the TLevel
And click on continue button
Then TLevel should be added to the Provide

@RegressionTest
Scenario: Add Multiple Tlevels
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select multiple tlevels
And click on continue button
Then TLevels should be added to the Provide

@RegressionTest
Scenario: View Added Tlevels
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
When I select multiple tlevels
And click on continue button
Then TLevels should be added to the Provide
And Added Tlevels should be displayed when i click Manage Tlevels link

@RegressionTest
Scenario: Remove Tlevel
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
And Click on View Provider already been setup link
And Click on View
And Click on Remove
When I select Yes, Remove Tlevel and click on Submit
Then I should see Tlevel Removed Successfully message

@RegressionTest
Scenario: Cancel Remove Tlevel
Given I have logged in as a "Provider" user
And I serch the Provider from Find Provider Page
And Click on View Provider already been setup link
And Click on View
And Click on Remove
When I select No, do not remoce radio option and click on submit
Then I should navigate back to Provider's details page and Tlevel should be seen on the list
