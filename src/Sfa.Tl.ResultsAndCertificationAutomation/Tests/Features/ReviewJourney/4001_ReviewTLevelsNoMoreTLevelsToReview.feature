Feature: TLRC_4001 Journey Improvements - Review T Levels - No T Levels to review
	As an AO with a T Levels reviewer user role 
	I need to know that I do not have any outstanding T Levels to review 
	so that I can decide where to go next 

Background: Log in as Reviewer
Given I have logged in as a "AllUser" user


@Ignore @RegressionTest @ReviewJourney
Scenario: 4001_Verify Review T Levels - All T Levels confirmed page and page links
Given I set all of the T Levels for NCFE to confirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
Then the Review T Levels - All T Levels reviewed page is displayed
When I press the confirmed T Levels link on the All T Levels reviewed page
Then I am navigated to the Confirmed T Levels page
When I navigate back to the Review T Levels - All T Levels reviewed page
And I click the Register link on the All T Levels reviewed page
Then I will be shown the Registrations dashboard page
When I navigate back to the Review T Levels - All T Levels reviewed page
And I click the Add T Levels link on the All T Levels reviewed page
Then I will be shown the Find a provider page
When I navigate back to the Review T Levels - All T Levels reviewed page
And I click the Back to TLevels button on the All T Levels reviewed page
Then I should see the TLevels dashboard page
When I navigate back to the Review T Levels - All T Levels reviewed page
And I click the Back to home button on the All T Levels reviewed page
Then I am taken to the home page
And I set all of the T Levels for NCFE to unconfirmed



