Feature: 3168_Provider Postal Address - Add address - enter postcode - postcode search
	As a provider, if I enter a valid UK postcode in the postcode box 
	a call should be made to the ordenance survey API with the postcode I have entered.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @Provider @PostalAddress
Scenario: 3168 No postcode entered validation
When I click on "Manage your organisation’s postal address" link
And I click on "Add address" link
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button without entering a postcode
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
Examples: 
| Error Message                |
| Enter your postcode          |

@RegressionTest @Provider @PostalAddress
Scenario: 3168 Invalid postcode entered validation
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 J66"
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 J6J"
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "BBBB 6JN"
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "BB! 6JN"
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B! 6JN"
Then I will be shown the following <Error Message> on the 'What is your organisation's postal address?' page
Examples: 
| Error Message                |
| Enter a valid UK postcode    |