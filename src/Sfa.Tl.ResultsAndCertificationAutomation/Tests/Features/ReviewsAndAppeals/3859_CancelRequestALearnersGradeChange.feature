Feature: 3859_Post Results Services - Cancel request a grade change
		As an AO with a result editor user role 
		I need to be able to cancel my request to change a grade 
		so that I do not get stuck in a journey if I access it by mistake or change my mind

Background: 
Given I have logged in as a "ResultsEditor" user
And I have registration in final state

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Validate Cancel request a grade change page - Access from Review option
When I search for my UlN through the Reviews option on the dashboard
And I click on the Contact us link on the 'Learner’s component grade status' page
And I click Cancel on the the 'Request a change to this learner’s grade' page
Then I am shown the Cancel request a grade change page
And the radio buttons will not be populated
When I press the Back link on the Cancel request a grade change page
Then I am shown the 'Request a change to this learner’s grade' page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Validate Request a change to this learner’s grade page - Access from Results option
When I search for my UlN through the Results option on the dashboard
And I click on the Contact us link on the Results Learners Results page
And I click Cancel on the the 'Request a change to this learner’s grade' page
Then I am shown the Cancel request a grade change page
And the radio buttons will not be populated
When I press the Back link on the Cancel request a grade change page
Then I am shown the 'Request a change to this learner’s grade' page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Select the Yes radio button on the Request a change to this learner’s grade page - Access from Review option
When I search for my UlN through the Reviews option on the dashboard
And I click on the Contact us link on the 'Learner’s component grade status' page
And I click Cancel on the the 'Request a change to this learner’s grade' page
Then I am shown the Cancel request a grade change page
When I press the Yes radio button and click Continue on the Cancel request a grade change page
Then I am shown the component grade status page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Select the Yes radio button on the Request a change to this learner’s grade page - Access from Results option
When I search for my UlN through the Results option on the dashboard
And I click on the Contact us link on the Results Learners Results page
And I click Cancel on the the 'Request a change to this learner’s grade' page
Then I am shown the Cancel request a grade change page
When I press the Yes radio button and click Continue on the Cancel request a grade change page
Then the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table on the Learner’s results page 
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Select the No radio button on the Request a change to this learner’s grade page
When I search for my UlN through the Results option on the dashboard
And I click on the Contact us link on the Results Learners Results page
And I click Cancel on the the 'Request a change to this learner’s grade' page
Then I am shown the Cancel request a grade change page
When I press the No radio button and click Continue on the Cancel request a grade change page
Then I am shown the 'Request a change to this learner’s grade' page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3859 Validate error messages when pressing the Continue button without entering any text 
When I search for my UlN through the Reviews option on the dashboard
And I click on the Contact us link on the 'Learner’s component grade status' page
And I click Cancel on the the 'Request a change to this learner’s grade' page
And I press Continue without selecting a radio button
Then the following error message is shown on the Request a change to this learner’s grade page 'Please select whether you want to cancel the request for a grade change'
And the registration for this test is deleted