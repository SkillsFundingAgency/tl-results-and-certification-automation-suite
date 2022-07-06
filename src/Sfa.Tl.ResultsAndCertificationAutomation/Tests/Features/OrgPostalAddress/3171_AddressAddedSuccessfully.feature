Feature: 3171_Provider Postal Address - Org postal address added successfully
	As a provider, 
	when I have reviewed the details on the check and submit page and press submit, 
	the address manually entered or selected should be saved in the database against the provider record - suggested fields:
	Department, Building, Street, Town or City, Postcode
	so that we have the correct information for printing statement of achievements.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database

@RegressionTest @Provider @PostalAddress
Scenario: 3171 Add Address from select address dropdown - No Dept and Org Name
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "B43 6JN"
And I select the first option from the dropdown and select Continue 
##Then I should see the Add Address Check and Submit page
When I click Submit
Then I am shown the Address address confirmation page
And the record will be written to the database with '' '' '1, BEECHWOOD ROAD' '' 'BIRMINGHAM' 'B43 6JN'

@RegressionTest @Provider @PostalAddress
Scenario: 3171 Add Address from select address dropdown - Dept and Org Name included
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "CV1 2WT"
And I enter a department name as "Test"
And I select the first option from the dropdown and select Continue 
##Then I should see the Add Address Check and Submit page
When I click Submit
Then I am shown the Address address confirmation page
And the record will be written to the database with 'Test' 'SKILLS FUNDING AGENCY' 'CHEYLESMORE HOUSE' '5, QUINTON ROAD' 'COVENTRY' 'CV1 2WT'

@RegressionTest @Provider @PostalAddress
Scenario: 3171 Add Address from Add Manual Address - Dept and Org Name included
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I click on "Add your organisation’s address manually" link
And I filled form with following information
| Field name         | Value              |
| departmentname     | TestDept           |
| organisationname   | Test  Org          |
| AddressLine1       | 99 Test Street     |
| AddressLine2       | Line 2             |
| Town               | Liverpool          |
| Postcode           | L4 5NN             |
When click on "Continue" button
##Then I should see the Add Address Check and Submit page
When I click Submit
Then I am shown the Address address confirmation page
And the record will be written to the database with 'TestDept' 'Test  Org' '99 Test Street' 'Line 2' 'Liverpool' 'L4 5NN'

@RegressionTest @Provider @PostalAddress
Scenario: 3171 Add Address from Add Manual Address - Optional address fields not included
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
And I click on "Add your organisation’s address manually" link
And I filled form with following information
| Field name         | Value              |
| AddressLine1       | 99 Test Street     |
| Town               | Liverpool          |
| Postcode           | L4 5NN             |
When click on "Continue" button
##Then I should see the Add Address Check and Submit page
When I click Submit
Then I am shown the Address address confirmation page
And the record will be written to the database with '' '' '99 Test Street' '' 'Liverpool' 'L4 5NN'
And when I press the Back to home link
Then I am taken to the home page

@Ignore @RegressionTest @Provider @PostalAddress
Scenario: 3315 Navigate to SOA from Add Address confirmation page
When I click on "Manage your organisation’s postal address" link
And I click on "Add address"
Then I should see the 'What is your organisation's postal address?' page
And when I click the Find Address button after entering postcode as "CV1 2WT"
And I enter a department name as "Test"
And I select the first option from the dropdown and select Continue 
When I click Submit
And I click on Request SOA button
Then I am taken to request SOA page
