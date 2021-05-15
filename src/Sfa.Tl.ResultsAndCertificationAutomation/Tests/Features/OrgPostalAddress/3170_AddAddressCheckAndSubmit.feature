Feature: 3170_Provider Postal Address - Add address - Check and Submit
	As a provider 
	Once I have completed the add an address manually process 
	OR used the postcode search journey to enter the org address and hit continue 
	the check and submit page should be displayed

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @Provider @PostalAddress
Scenario: 3170 Press Back Link on Check And Submit Page - Journey from Add Address Select
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 6JN"
And I select the first option from the dropdown and select Continue 
Then I should see the Add Address Check and Submit page
When I click the Back link on the Add Address Check and Submit page
Then I should see the Add Postal Address Select page

@RegressionTest @Provider @PostalAddress
Scenario: 3170 Press Back Link on Check And Submit Page - Journey from Add Address Manually
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I click on "Add your organisation’s address manually" link
And I filled form with following information
| Field name   | Value    |
| AddressLine1 | Test     |
| Town         | Test     |
| Postcode     | B43 6JN  |
When click on "Continue" button
Then I should see the Add Address Check and Submit page
When I click the Back link on the Add Address Check and Submit page
Then I should see the Add your address manually page

@RegressionTest @Provider @PostalAddress
Scenario: 3170 Press Change Address Link on Check And Submit Page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 6JN"
And I select the first option from the dropdown and select Continue 
Then I should see the Add Address Check and Submit page
When I click the Change address link on the Add Address Check and Submit page
Then I should see the Add Postal Address Select page

@RegressionTest @Provider @PostalAddress
Scenario: 3170 Press Cancel Link on Check And Submit Page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 6JN"
And I select the first option from the dropdown and select Continue 
Then I should see the Add Address Check and Submit page
When I click the Cancel link on the Add Address Check and Submit page
Then I should see the Cancel Address page





