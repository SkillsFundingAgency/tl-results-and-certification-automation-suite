Feature: 3105_Statement of Achievement - Requesting a statement of achievement
	As a provider, 
	as long as ‘requesting a statement of achievement’ printing functionality is available (from 10 August 2021) 
	AND there is a postal address recorded against the provider record, 
	when I click on ‘Request a statement of achievement’ on my dashboard, 
	I am presented with the request-statement-of-achievement page
	so I can understand any actions I need to take before stepping through the process.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@RegressionTest @SOA
Scenario: 3105_Verify Request Statement of Achievement page and Back link
Given I click on "Request statement of achievement" link
Then I am navigated to the Request SOA page if the date is greater than 10th August 2021
When I click the back link on the Request SOA page
Then I will be navigated to the T Levels Dashboard page