Feature: TLRC_4011 Journey Improvements - Review T Levels - Details confirmed (more to go)
	As an AO with a T Levels reviewer user role 
	I need to know I have successfully reviewed a T Level 
	so that I can take the next relevant step in my journey

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4011_Verify All T Levels Reviewed page and the Back to home button
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the Yes radio button and press Submit on the Review T Level details page
Then the green confirmation box on the All T Levels reviewed success page shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
And the page displays text as per the Copy Deck
When I click the Back to home button on the All T Levels reviewed success page
Then I am taken to the home page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4011_Verify All T Levels Reviewed page and the Back to T Levels button
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the Yes radio button and press Submit on the Review T Level details page
Then the green confirmation box on the All T Levels reviewed success page shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
And the page displays text as per the Copy Deck
When I click the Back to T Levels button on the All T Levels reviewed success page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4011_Verify All T Levels Reviewed page and the page links are linked to the expected pages
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the Yes radio button and press Submit on the Review T Level details page
Then the green confirmation box on the All T Levels reviewed success page shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
And the page displays text as per the Copy Deck
And the links on the All T Levels reviewed success page link to the expected pages
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney @ignore
Scenario: 4011_Verify All T Levels Reviewed page and the Register your learners link
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the Yes radio button and press Submit on the Review T Level details page
Then the green confirmation box on the All T Levels reviewed success page shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
And the page displays text as per the Copy Deck
When I click the Register your learners link on the All T Levels reviewed success page
Then I will be shown the Registrations dashboard page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney @ignore
Scenario: 4011_Verify All T Levels Reviewed page and the Add T Levels link
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the Yes radio button and press Submit on the Review T Level details page
Then the green confirmation box on the All T Levels reviewed success page shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
And the page displays text as per the Copy Deck
When I click the Add T Levels link on the All T Levels reviewed success page
Then I will be shown the Registrations dashboard page
And I set all of the T Levels for NCFE to unconfirmed



