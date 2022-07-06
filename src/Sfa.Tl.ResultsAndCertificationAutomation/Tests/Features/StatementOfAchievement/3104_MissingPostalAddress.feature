Feature: 3104_Statement of Achievement - 'Missing postal address'
	As a provider, 
	if there is no postal address recorded against our provider record, 
	when I click on ‘Request statement of achievement’ on my dashboard the missing-address page should be displayed
	so that I know I need to add a postal address before starting the request.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database


@Ignore @RegressionTest @SOA
Scenario: 3104_Verify Missing Postal Address page and Back link
Given I click on "Request statement of achievement" link
Then I am navigated to the Missing Postal Address page
When I click the back link on the Missing Postal Address page
Then I will be navigated to the T Levels Dashboard page

@Ignore @RegressionTest @SOA
Scenario: 3104_Click Add Address button on the Missing Postal Address page
Given I click on "Request statement of achievement" link
Then I am navigated to the Missing Postal Address page
When I click the Add address button on the Missing Postal Address page
Then I should see the 'What is your organisation's postal address?' page
When I click the back link on the Add 'What is your organisation's postal address?' page
Then I am navigated to the Missing Postal Address page

@Ignore @RegressionTest @SOA
Scenario: 3104_Click Back to Home link on the Missing Postal Address page
Given I click on "Request statement of achievement" link
Then I am navigated to the Missing Postal Address page
When I click the Back to Home link on the Missing Postal Address page
Then I will be navigated to the T Levels Dashboard page