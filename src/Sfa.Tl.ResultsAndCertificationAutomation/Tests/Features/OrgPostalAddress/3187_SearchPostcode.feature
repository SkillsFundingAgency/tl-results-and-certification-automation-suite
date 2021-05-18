Feature: 3187_SearchPostcode
	As a Provider
	I enter the postcode in the search page
	So that I can select the correct postal address for the organisation.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I click on "Manage your organisation’s postal address" link
And I click on "Add address" button on Org postal address page

@RegressionTest @Provider @PostalAddress
Scenario: 3187 Verify Search postcode result page
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WT |
When I click on "Find address" button
Then I should see address result page
And back link takes me to find postal address page
And I see postcode is retained
| Postcode |
| CV12WT   |

@RegressionTest @Provider @PostalAddress
Scenario: 3187 Verify change link
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WT |
And I click on "Find address" button
When I click on "Change" link
Then it should takes me to find postal address page

@RegressionTest @Provider @PostalAddress
Scenario: 3187 Verify manadatory filed validation
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WT |
And I click on "Find address" button
When I click on "Continue" button
Then I should see the following error messages
| Field | Error messages |
|SelectedAddressUprn| Select your address from the list |
And I should see the following error summary messages
| Error messages                    |
| Select your address from the list |

@RegressionTest @Provider @PostalAddress
Scenario: 3187 Navigate to add address manually page
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WT |
And I click on "Find address" button
And I click Can't find address link
When I click on "add it manually" link
Then I should be navigated to add address manually page

@RegressionTest @Provider @PostalAddress
Scenario: 3187 Verify address count
And I filled form with following information
| Field name | Value  |
| Postcode   | CV12WT |
When I click on "Find address" button
Then it should return addresses