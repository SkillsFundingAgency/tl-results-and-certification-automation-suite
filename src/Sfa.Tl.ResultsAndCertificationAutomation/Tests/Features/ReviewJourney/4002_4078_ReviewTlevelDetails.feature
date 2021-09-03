Feature: TLRC_4002 Journey Improvements - Review T Levels - T Level details
	As an AO with a T Levels reviewer user role 
	I need to know the details of the T Level I am reviewing 
	so that I can let you know if it is correct or not

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4002_4078_Verify Review T Level to review page and breadcrumbs
Given I set all of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
Then I am shown the Review T Level details page
And the radio buttons are not prepopulated on the Review T Level page
And the details for the "T Level in Agriculture, Environmental and Animal Care" T level are displayed
When I press the back link on the Review T Level details page
Then I am navigated to the Select T Level to review page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4002_4078_Verify Review T Level to review page when only one TLevel is unconfirmed
Given I set only one T Level (T Level in Agriculture, Environmental and Animal Care) for NCFE to unconfirmed
And I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
Then I am shown the Review T Level details page
And the radio buttons are not prepopulated on the Review T Level page
And the details for the "T Level in Agriculture, Environmental and Animal Care" T level are displayed
When I press the back link on the Review T Level details page
##Then I am navigated to the Select T Level to review page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4002_Verify Error message on Select T Level to review page when pressing continue without selecting a T Level
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I select "T Level in Agriculture, Environmental and Animal Care" and click continue
Then I am shown the Review T Level page
When I click the Continue button without selecting any radio buttons on the Review T Level details page
Then I am shown the following error message on the Review T Level details page "Select yes if this T Level’s details are correct"
And I set all of the T Levels for NCFE to unconfirmed



