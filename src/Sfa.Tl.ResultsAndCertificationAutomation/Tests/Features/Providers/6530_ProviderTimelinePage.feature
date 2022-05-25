Feature: 6530_ProviderTimelinePage

As a Provider, I need understand what data I am entering onto the service so that I ensure I am entering the correct data

@RegressionTest @Provider
Scenario: 6530_Verify provider timelines page
Given I have logged in as a "ProviderBarnsleyPA" user
When I click on "Check what data you need to provide and when you need to provide it" link
Then provider timeline page is shown
And clicking on home breadcrumb takes me to home page
