Feature: 7217_Check and Submit page (Add a new learner record)
	As a Provider
	I need to be able to check learner data before submitting
	So that I can ensure the data is correct

@RegressionTest @Provider
Scenario:  2721_Check and submit page - Yes, completed radio button selected and user not acheived Maths and English
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications (Maths achieved and English not Achieved)
And I navigate to the Has the learner completed the IP page
And I select "Yes, completed" radio button and press Continue
Then I am shown the Check and submit page for the Add a new learner journey
And the English and maths minimum standard status shows "Not achieved minimum standard (Data from the Learning Records Service - LRS)"
And the Industry placement status shows "Placement completed"
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2721_Check and submit page - Yes, completed with special consideration radio button selected and user not acheived Maths and English
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications (Maths not achieved and English achieved)
And I navigate to the Has the learner completed the IP page
And I select "Yes, completed with special consideration" radio button and press Continue
Then I am shown the Check and submit page for the Add a new learner journey
And the English and maths minimum standard status shows "Not achieved minimum standard (Data from the Learning Records Service - LRS)"
And the Industry placement status shows "Placement completed with special consideration"
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2721_Check and submit page - No, still to be completed radio button selected and user has acheived Maths and English
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications (Maths and English achieved)
And I navigate to the Has the learner completed the IP page
And I select "No, still to be completed" radio button and press Continue
Then I am shown the Check and submit page for the Add a new learner journey
And the English and maths minimum standard status shows "Achieved minimum standard (Data from the Learning Records Service - LRS)"
And the Industry placement status shows "Placement still to be completed"
Given I click the back link on the Learner Check and Submit page
Then I expect to see the learner completed Industry Placement page
And I have deleted LRS records from the database