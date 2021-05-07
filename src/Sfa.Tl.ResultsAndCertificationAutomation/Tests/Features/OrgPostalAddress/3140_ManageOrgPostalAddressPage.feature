Feature: 3140_ManageOrgPostalAddressPage
	As a Provider
	I need a link on dashboard page to go to add postal address page
	So that I can add postal address

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @Provider @PostalAddress
Scenario: 3140_Verify manage organisation postal address page 
When I click on "Manage your organisation’s postal address" link
Then I should see Manage organisation postal address page
And I should retun to dashboard when i click on Home breadcrumb