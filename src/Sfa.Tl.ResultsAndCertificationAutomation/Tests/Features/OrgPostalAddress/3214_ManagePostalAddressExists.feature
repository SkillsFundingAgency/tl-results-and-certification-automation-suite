Feature: 3214_ManagePostalAddressExists
	As a Provider
	I need a page see if postal address is already added
	So that I do not have to add it again

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the exisintg address and created a new address in database

@RegressionTest @Provider @PostalAddress
Scenario: 3214_Verify manage organisation postal address exists page 
When I click on "Manage your organisation’s postal address" link
Then I should see Manage organisation postal address page
And I should retun to dashboard when i click on Home breadcrumb