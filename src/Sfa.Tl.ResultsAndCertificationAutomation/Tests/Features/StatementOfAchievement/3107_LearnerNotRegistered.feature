Feature: 3107_LearnerNotRegistered
	As a Provider
	I want to see an error page when learner is not registered
	So we can prevent issuing SOA for not registered learner 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley
And I am on Search for learner page

@RegressionTest @SOA
Scenario: 3107 Verify learner not registered page
When I enter non existed Uln and click on Search button
Then I should see Learner not registered page
And Back link should take me back to search learner page
And back to home should take me to dashboard page