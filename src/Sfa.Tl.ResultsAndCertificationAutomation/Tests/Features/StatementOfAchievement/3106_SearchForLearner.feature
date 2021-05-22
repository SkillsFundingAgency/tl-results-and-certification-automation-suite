Feature: 3106_Statement of Achievement - Search for a learner
	As a provider, 
	when I press ‘Continue’ on the ‘Requesting a statement of achievement’ page 
	I am presented with a ‘Search for a learner’ page, 
	where I can enter the 10 digit ULN to search for the  student I am requesting an SOA for. 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley
And I click on "Request statement of achievement" link
And I click on Continue on the Request SOA page
Then I will be navigated to the Request Statement of Achievement - Search for a learner page

@RegressionTest @SOA
Scenario: 3106_Verify Request SOA - Search for a learner page and the ULN entry error messages
Given I click Search without entering a ULN on the Request SOA - Search for a learner page
Then the error message "Enter a ULN with 10 digits" is shown on the Request SOA - Search for a learner page
When I enter "123456789" in the Search ULN box on the Request SOA - Search for a learner page and click Search
Then the error message "Enter a valid 10-digit ULN" is shown on the Request SOA - Search for a learner page
When I enter "ABCDEFGHIJ" in the Search ULN box on the Request SOA - Search for a learner page and click Search
Then the error message "Enter a valid 10-digit ULN" is shown on the Request SOA - Search for a learner page


@RegressionTest @SOA
Scenario: 3106_Validate breadcrumbs on Request SOA - Search for a learner page
Given I click the Request Statement of Achievement breadcrumb
Then I am navigated to the Request SOA page if the date is greater than 10th August 2021
When I click on Continue on the Request SOA page
And I click on the Home Breadcrumb on the Request SOA - Search for a learner page
Then I will be navigated to the T Levels Dashboard page



