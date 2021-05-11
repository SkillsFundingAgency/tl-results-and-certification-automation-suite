Feature: 3169_AddAddressManuallyPage
	As a Provider
	I need a page to add postal address manually
	So that I can add postal address manully

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I click on "Manage your organisation’s postal address" link
And I click on "Add address" button on Org postal address page
And I click on "Add your organisation’s address manually" link

@RegressionTest @Provider @PostalAddress
Scenario: 3169 Verify manul add address page
And I see Add address manually page
And I see following fields in the page
| Field name            |
| Department			|
| AddressLine1			|
| AddressLine2			|
| Town					|
| Postcode              |
And Back link takes me to what is Org postal address page

@RegressionTest @Provider @PostalAddress
Scenario: 3169 Verify manadatory fields
When click on "Continue" button
Then I should see the following error messages
| Field        | Error messages                 |
| AddressLine1 | Enter your building and street |
| Town         | Enter your town or city        |
| Postcode     | Enter your postcode            |
And I should see the following error summary messages
| Error messages                 |
| Enter your building and street |
| Enter your town or city        |
| Enter your postcode            |
And I should see error in page title

@RegressionTest @Provider @PostalAddress
Scenario: 3169 Validate postcode field
And I filled form with following information
| Field name   | Value |
| AddressLine1 | Test  |
| Town         | Test  |
| Postcode     | Test  |
When click on "Continue" button
Then I should see the following error messages
| Field    | Error messages            |
| Postcode | Enter a valid UK postcode |
And I should see the following error summary messages
| Error messages            |
| Enter a valid UK postcode |
And I should see error in page title