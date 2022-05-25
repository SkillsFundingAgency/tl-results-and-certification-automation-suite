Feature: 6527_ProviderGuidancePage

As a Provider, I need understand what data I am entering onto the service so that I ensure I am entering the correct data

@RegressionTest @Provider
Scenario: 6527_Verify provider guidance page
Given I have logged in as a "ProviderBarnsleyPA" user
When I click on "Find out about Manage T Level results" link
Then provider guidance page is shown
And clicking on home breadcrumb takes me to home page