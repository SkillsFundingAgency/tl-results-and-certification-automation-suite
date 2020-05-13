Feature: ProviderBreadcrumb
	In order to navigate previous pages
	As a provider editor
	I want to click on breadcrums to navigate other pages

Background:
Given I have logged in as a "Provider" user
And click on Provider link in dashboard page

@RegressionTest @ProviderJourney
Scenario: Breadcrumb on Find Provider Page
When I am Find a Provider page
And I click on Home link
Then I should be navated back to dashboard

@RegressionTest @ProviderJourney
Scenario: Breadcrumb on Providers Tlevel Page
When I am on The Provider's TLevel page
And I click on Your Provider link
Then I should be navigated back to Your providers page

@RegressionTest @ProviderJourney
Scenario: Breadcrumb on Your providers page
When I am on your Providers page
And I click on Home link
Then I should be navated back to dashboard
