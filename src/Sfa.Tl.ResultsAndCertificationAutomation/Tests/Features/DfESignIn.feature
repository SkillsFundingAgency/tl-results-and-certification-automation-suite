Feature: DfESignIn
	In order to access Tlevel home page
	As a Tlevel user
	I want to validate user in DfE system first

@SmokeTest
Scenario: DfE Sign in with Invalid User
Given TLevel start page
And I have entered invalid Username or Password
When I clicked on sign in button
Then User should not logged to see Tlevel Dashboard page
And an Error Message should be displayed for Invalid username
