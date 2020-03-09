Feature: ErrorPages
	In order to validate how the errors are being handled
	As a user
	I want to see all error pages on any failures

@Sprint6
Scenario: Error 404 Page Not Found
	Given I have opend browser
	When I enter invalid Url
	Then I should see Page not found error

@Sprint6
Scenario: Error 401 Access Denied
	Given I have entered Access Denied Url in the browser
	When I enter valid DfE signin username and password and click on Sign in button
	Then I should see Access Denied error

@Sprint6
Scenario: Error 500 Internal Server
	Given I have Internal Server Error Url in the browser
	When I loocked at page content
	Then I should see an error

@Sprint6
Scenario: Error 403 Forbidden
	Given Tlevel Start page
	And I have clicked in Start Now button
	When I enter Ao_No_Roles username and password and click on signin button
	And I have selected Organisation and click on Continue button
	Then I should see access denied error

@Sprint9
Scenario: Access Denied Service
	Given Tlevel Start page
	And I have clicked in Start Now button
	When I enter Ao_No_Roles username and password and click on signin button
	And I have selected Organisation and click on Continue button
	Then I should see access denied error
	And I should be on same page if i click on Service Banner