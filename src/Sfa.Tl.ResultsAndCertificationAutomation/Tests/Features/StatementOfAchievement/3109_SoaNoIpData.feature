Feature: 3109_SoaNoIpData
	As a Provider
	I want to see an error page when learner has no IP data
	So we can prevent issuing SOA

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley
And I am on Search for learner page
And I have a withdrawn registration for Barsley with no IP data

@Ignore @RegressionTest @SOA
Scenario: 3109 Verify Soa not available without IP page
When I enter withdrawn Uln without IP data and click on Search button
Then I should see SOA not available without Ip page
And the registration for this test is deleted

@Ignore @RegressionTest @SOA
Scenario: 3109 Navigate to add learner page
When I enter withdrawn Uln without IP data and click on Search button
And I click on Add learner T Level record button on Soa not available page
Then I should see Add a new learner T Level record page
And the registration for this test is deleted

@Ignore @RegressionTest @SOA
Scenario: 3109 Click Breadcrumbs
When I enter withdrawn Uln without IP data and click on Search button
And I click on "Search for a learner" breadcrumb
Then I should see Soa search for learner page
And I should see request Soa page when i click "Request statement of achievement" breadcrub
And the registration for this test is deleted

