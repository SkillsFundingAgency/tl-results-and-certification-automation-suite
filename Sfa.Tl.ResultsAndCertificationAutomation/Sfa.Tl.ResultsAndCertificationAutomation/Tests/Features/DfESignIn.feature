Feature: DfESignIn
	In order to access Tlevel home page
	As a Tlevel user
	I want to validate user in DfE system first

Background: 
Given I have navigated to DfE sign in page

@Sprint5
Scenario: DfE Sign in with valid user
	Given I have entered valid username and password
	When I have clicked on sign in button
	Then user logged in to seen Tlevel Dashboard page

@Sprint5
Scenario: DfE Sign in with Invalid User
Given I have entered invalid Username or Password
When I have clicked on sign in button
Then User should not logged to see Tlevel Dashboard page
And an Error Message should be displayed for Invalid username
