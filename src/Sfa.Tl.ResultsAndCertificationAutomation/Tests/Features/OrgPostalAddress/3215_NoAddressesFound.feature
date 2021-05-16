Feature: 3215_Provider Postal Address - Select Address - 0 addresses found
	As a provider, when searching for the postcode 
	and the OS API returns 0 addresses, the Provider Postal Address - Select Address - 0 addresses found page should be displayed
	so that I know I need to go back to change the postcode 
	or add the address manually to continue the process. 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database

@RegressionTest @Provider @PostalAddress
Scenario: 3125 Press back link on No addresses found page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I search for <Postcode>
Then I will see the No addresses found page for <Postcode>
And I click the back link
Then I should see the 'What is your organisation's postal address?' page
Examples: 
| Postcode  |
| BBB 6JN   |

@RegressionTest @Provider @PostalAddress
Scenario: 3125 Press Add address manually link on No addresses found page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I search for <Postcode>
Then I will see the No addresses found page for <Postcode>
And I click the Add address manually link
Then I should see the Add your address manually page

Examples: 
| Postcode  |
| BBB 6JN   |

@RegressionTest @Provider @PostalAddress
Scenario: 3125 Press Try another postcode button on No addresses found page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I search for <Postcode>
Then I will see the No addresses found page for <Postcode>
And I click the Try another postcode button
Then I should see the 'What is your organisation's postal address?' page
And the postcode field will be empty
Examples: 
| Postcode  |
| BBB 6JN   |





