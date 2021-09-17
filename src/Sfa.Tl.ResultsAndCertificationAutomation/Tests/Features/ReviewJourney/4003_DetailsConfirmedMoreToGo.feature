Feature: TLRC_4003 Journey Improvements - Review T Levels - Details confirmed (more to go)
	As an AO with a T Levels reviewer user role 
	I need to know I have successfully reviewed a T Level 
	so that I can take the next relevant step in my journey

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4003_Verify Review T Levels - Details confirmed page when there is more than one T Level left to review
Given I set three of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
And I select the Yes radio button and press Submit on the Review T Level details page
Then the Review T Levels - Details confirmed page is displayed
And the green confirmation box shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
When I press the Review another T Level button
Then I am navigated to the Select T Level to review page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4003_Verify Review T Levels - Details confirmed page when there is only one T Level left to review
Given I set two of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
And I select the Yes radio button and press Submit on the Review T Level details page
Then the Review T Levels - Details confirmed page is displayed
And the green confirmation box shows the T Level "T Level in Agriculture, Environmental and Animal Care" is confirmed
When I press the Review another T Level button
Then I am shown the Review T Level details page
And the radio buttons are not prepopulated on the Review T Level page
And the details for the "T Level in Business and Administration" T level are displayed
And I set all of the T Levels for NCFE to unconfirmed





