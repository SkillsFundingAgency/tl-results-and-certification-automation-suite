Feature: 3111_UlnNotWithdrawnPage
	As a Provider
	I want to see an error page when learner is not withdrawn
	So we can prevent issuing SOA for not withdrawn learner 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley
And I am on Search for learner page
And I have a active registration in Bansley provider

@Ignore @RegressionTest @SOA
Scenario: 3111 Verify Uln not withdrawn page
When I enter active Uln and click on Search button
Then I should see Learner not withdrawn page
And Back link should take me back to search learner page
And click on back to home should take me to dashboard page
And the registration for this test is deleted