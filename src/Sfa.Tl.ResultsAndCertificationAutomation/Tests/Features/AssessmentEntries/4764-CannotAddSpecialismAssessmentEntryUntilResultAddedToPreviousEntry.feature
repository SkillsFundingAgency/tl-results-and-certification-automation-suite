Feature: 4764_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - Details page -Specialism resits - cannot add assessment entry as no result added for previous entry
		ACTION can add specialism to current open summer series if previous is closed (STATIC LINK)
		ACTION need to add result to previous entry before being able to add new entry to specialism (LINK TO RESULTS DASHBOARD)



Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @Results
Scenario: 4764 Attempt to add a specialism assessment entry for current series when previous specialism assessment series does not have a grade added
And I have a registration with Specialism assessment series added for previous assessment year with no grade
And I navigate to the Learner's Assessment Entries page
Then the user will be notified that they must add a result to this learner's previous assessment before entering new assessment details
When the user adds a result to the previous specialism assessment entry
Then the user will be able to add the current specialism assessment entry 

@RegressionTest @Results
Scenario: 4764 COUPLET SPECIALISM - Attempt to add a specialism assessment entry for current series when previous specialism assessment series does not have a grade added
And I have a registration with couplet specialism assessment series added for previous assessment year with no grade
And I navigate to the Learner's Assessment Entries page
Then the user will be notified that they must add a result to both of this learner's previous specialism assessment before entering new assessment details
When the user adds a result to both the previous specialism assessment entry
Then the user will be able to add the current specialism assessment entry 
