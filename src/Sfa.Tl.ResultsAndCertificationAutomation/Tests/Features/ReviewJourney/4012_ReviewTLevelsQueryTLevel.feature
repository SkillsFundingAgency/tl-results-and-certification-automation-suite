Feature: TLRC_4012 Journey Improvements - Review T Levels - Query T Level
	As an AO with a T Levels reviewer user role 
	I need to know I have successfully reviewed a T Level 
	so that I can take the next relevant step in my journey

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4012_Verify Query T Level details page and the Back link
Given I set all of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
And I select the No radio button and press Submit on the Review T Level details page
Then I am shown the Query T Level Details page
And the Query T Level Details page will display details for the T Level "T Level in Agriculture, Environmental and Animal Care" 
And when I press the Back link on the Query T Level Details page
Then I am shown the Review T Level details page
And the details for the "T Level in Agriculture, Environmental and Animal Care" T level are displayed
And I set all of the T Levels for NCFE to unconfirmed


@RegressionTest @ReviewJourney
Scenario: 4012_Verify error message when pressing Submit without entering any text on the Query T Level Details page
Given I set one of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select the No radio button and press Submit on the Review T Level details page
And I select Submit on the Query T Level Details page
Then I am shown an error stating "Enter what is wrong with this T Level’s details" on the Query T Level Details page
And I set all of the T Levels for NCFE to unconfirmed

