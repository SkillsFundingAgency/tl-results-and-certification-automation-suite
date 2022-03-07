Feature: 3858_Post Results Services - Request a grade change
	As an AO with a results editor role 
	I need to be able to request a grade change after the appeal outcome has been recorded 
	to ensure records are accurate and up to date

Background: 
Given I have logged in as a "ResultsEditor" user
And I have registration in final state

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3858 Validate Request a change to this learner’s grade page - Access from Review option
When I search for my UlN through the Reviews option on the dashboard
And I click on the Contact us link on the 'Learner’s component grade status' page
Then I am shown the 'Request a change to this learner’s grade' page
And when I press the Back Link on the 'Request a change to this learner’s grade' page
Then the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table 
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3858 Validate Request a change to this learner’s grade page - Access from Results option
When I search for my UlN through the Results option on the dashboard
And I click on the Contact us link on the Results Learners Results page
Then I am shown the 'Request a change to this learner’s grade' page
And when I press the Back Link on the 'Request a change to this learner’s grade' page
Then the Results Learners Result page is displayed
And the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table on the Learner’s results page 
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3858 Validate error messages when pressing Send button without entering any text 
When I search for my UlN through the Reviews option on the dashboard
And I click on the Contact us link on the 'Learner’s component grade status' page
Then I am shown the 'Request a change to this learner’s grade' page
And when I press the Send button without entering any text
Then the following error message is shown on the Request a change to this learner’s grade page 'Please tell us what you need to change and why'
And the registration for this test is deleted