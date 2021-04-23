Feature: 2802 Has learner achieved English & Maths (SEND)
	As a Provider
	I need to see that I have submitted the learner status for when they have SEND applicable qualifications
	So that I can ensure I have submitted the correct information


Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and no IP
When I update the registration profile record so Send is "null" and IsEMAchieved is "true" and RCFeed is "false"
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link


@RegressionTest @Provider
Scenario:  2802_Click Add another learner T Level record button and Validate page
When I enter the ULN on the Add learner page
And I select the "Achieved the minimum standard for learners with SEND" radio button on the Min standard for EM Page
And I click Submit on the Min standard for EM Page
Then I am navigated to the English and maths data submitted successfully page
When I click the Add another learner T Level record button
Then I am navigated to the Learner Enter the Unique Learner Number page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2802_Click Back to manage learner T Level records button
When I enter the ULN on the Add learner page
And I select the "Achieved the minimum standard for learners with SEND" radio button on the Min standard for EM Page
And I click Submit on the Min standard for EM Page
Then I am navigated to the English and maths data submitted successfully page
When I click the Back to manage learner T Level records button
Then I am navigated to the Manage learner records page
And I have deleted LRS records from the database

