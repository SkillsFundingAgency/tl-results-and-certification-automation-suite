Feature: Journey Improvements - User guide replacement (Manage providers page)
	For this story we will be making changes to the content on the manage providers page for AO providers editor users

Background:
Given I have logged in as a "AllUser" user


@RegressionTest @ProviderJourney
Scenario: TLRC_3988_Verify the "Which provider do you want to manage?" page and the Contact us link
Given I click on the Provider link in dashboard page
Then I will be navigated to the Find a Provider page
When I click the I cannot find a provider link on the Which provider do you want to manage? page
And I click the Contact us link on the Which provider do you want to manage? page
Then I am shown the Contact Us page


@RegressionTest @ProviderJourney
Scenario: TLRC_3988_Verify the Confirm your T Levels link on the "Which provider do you want to manage?" page
Given I click on the Provider link in dashboard page
And I click the Confirm your T Levels link on the Which provider do you want to manage? page
Then I should see the TLevels dashboard page


@RegressionTest @ProviderJourney
Scenario: TLRC_3988_Verify the View existing providers button on the "Which provider do you want to manage?" page
Given I click on the Provider link in dashboard page
And I click the "View existing providers" button on the Which provider do you want to manage? page
Then I should be navigated back to Your providers page


