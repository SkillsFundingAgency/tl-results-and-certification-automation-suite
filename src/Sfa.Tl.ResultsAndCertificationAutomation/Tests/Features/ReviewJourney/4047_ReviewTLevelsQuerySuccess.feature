Feature: TLRC_4047 Journey Improvements - Review T Levels - Query success
	As an AO with a T Levels reviewer user role 
	I need to be sure that my query has been successfully sent 
	so that I know when to expect a response

Background: Log in as user with Reviewer role that has email attached to allow full end to end journey
Given I have logged in as a "TLevelUser" user
And I set all of the T Levels for NCFE to unconfirmed

@Ignore @RegressionTest @ReviewJourney
Scenario: 4047_Verify the Query T Level success page and Back to TLevels button
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
And I select the No radio button and press Submit on the Review T Level details page
And I enter a value for what is wrong with the T Level and press Submit
Then I am shown the T Levels details Queried Success page
And the T Levels details Queried Success page will list the T Level "T Level in Agriculture, Environmental and Animal Care"
When I press the Back to T Levels button on the T Levels details Queried Success page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed


@Ignore @RegressionTest @ReviewJourney
Scenario: 4047_Verify the Query T Level success page and Back to home button
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
And I select the No radio button and press Submit on the Review T Level details page
And I enter a value for what is wrong with the T Level and press Submit
Then I am shown the T Levels details Queried Success page
And the T Levels details Queried Success page will list the T Level "T Level in Agriculture, Environmental and Animal Care"
When I press the Back to home button on the T Levels details Queried Success page
Then I should be navigated back to home page
And I set all of the T Levels for NCFE to unconfirmed


