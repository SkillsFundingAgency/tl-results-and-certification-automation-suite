Feature: 2694_Has learner achieved minimum standard for English & Maths page
	As a Provider
    I need to confirm learner English & Maths details which cannot be obtained from LRS
	So that learner data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page

@RegressionTest @Provider
Scenario:  2694_Check and Submit page - Non LRS - Selected "Achieved the minimum standard" 
Given I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I select "Yes, completed with special consideration" radio button and press Continue
Then I am shown the Check and submit page for the Add a new learner journey
And the English and maths minimum standard status shows "Achieved minimum standard"
And the Industry placement status shows "Placement completed with special consideration"
And I have deleted LRS records from the database