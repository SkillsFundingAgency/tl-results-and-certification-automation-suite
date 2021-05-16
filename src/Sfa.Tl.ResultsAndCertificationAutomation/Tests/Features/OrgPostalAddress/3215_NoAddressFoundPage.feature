Feature: 3215_NoAddressFoundPage
	As a Provider
	I need a page returns no address found
	So that i can recheck the correct postcode

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I click on "Manage your organisation’s postal address" link
And I click on "Add address" button on Org postal address page

@RegressionTest @Provider @PostalAddress
Scenario: 3215 Verify no address found page
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WR |
When I click on "Find address" button
Then I shoud see no address found page for "CV12WR"
And clicking on Back link should takes be back to search postal address page

@RegressionTest @Provider @PostalAddress
Scenario: 3215 Navigate to add address manually page
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WR |
When I click on "Find address" button
And I click on "add your address manually" link
Then I should see Add address manually page

@RegressionTest @Provider @PostalAddress
Scenario: 3215 Try another postcode
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WR |
When I click on "Find address" button
And I click on "Try another postcode" button
Then I should see search postal address page