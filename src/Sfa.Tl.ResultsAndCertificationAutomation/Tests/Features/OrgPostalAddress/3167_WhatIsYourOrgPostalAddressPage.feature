Feature: 3167_WhatIsYourOrgPostalAddressPage
	As a Provider
	I need a page to serach a post code to add postal address page
	So that I can add postal address

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @Provider @PostalAddress
Scenario: 3167_Verify what is your postal code page 
And I click on "Manage your organisation’s postal address" link
When I click on "Add address" button on Org postal address page
Then I should see What is your Org postal address page
And clicking on Back link should takes be back to Manage org postal address page