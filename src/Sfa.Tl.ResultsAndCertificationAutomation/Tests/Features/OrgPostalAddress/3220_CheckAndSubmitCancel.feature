Feature: 3220_Provider Postal Address - Address - Check and Submit - Cancel
	As a provider
	when I reach the check and submit page 
	there is an option to ‘cancel’ - selecting this will take me to the cancel page 
	where I can select either ‘Yes, cancel’ or ‘No, do not cancel'

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I navigate to the cancel page

@RegressionTest @Provider @PostalAddress
Scenario: 3220 Select Yes Radio button on Cancel page
Given I click the "Yes, cancel" radio button and press Continue on the Cancel page
Then I will be navigated to the T Levels Dashboard page

@RegressionTest @Provider @PostalAddress
Scenario: 3220 Select No Radio button on Cancel page
Given I click the "No, do not cancel" radio button and press Continue on the Cancel page
Then I should see the Add Address Check and Submit page

@RegressionTest @Provider @PostalAddress
Scenario: 3220 Select Back link on Cancel page
Given I click the Back link on the Cancel page
Then I should see the Add Address Check and Submit page



