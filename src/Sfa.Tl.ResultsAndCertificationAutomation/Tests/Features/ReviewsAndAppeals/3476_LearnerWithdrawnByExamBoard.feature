Feature: 3476_Post Results Services - ULN2 - Learner withdrawn by exam board
	As an AO with a results editor user role, 
	if I search for a ULN that has a status of ‘withdrawn’ by the exam board 
	then the reviews-and-appeals-learner-withdrawn page should be displayed
	So that I know an appeal cannot be requested for this record. 
	I also need to see details of the learner so I know I am searching for the right record. 

Background: 
Given I have logged in as a "ResultsEditor" user
And I have created a registration which is withdrawn, where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed' with a grade attached
And I click on "Appeals" link

@RegressionTest @ReviewsAndAppeals
Scenario: 3476 Verify search for learner page and click Back link
When I click on "Continue" button in start page
And I search for the ULN created for this test
Then I am shown the Reviews and appeals Learner Withdrawn page
And when I click the Back link on the Reviews and appeals Learner Withdrawn page 
Then I should see reviews and appeals search for learner page
And I have deleted LRS records from the database

@RegressionTest @ReviewsAndAppeals
Scenario: 3476 Press Back to home button
When I click on "Continue" button in start page
And I search for the ULN created for this test
Then I am shown the Reviews and appeals Learner Withdrawn page
And when I click the Back to home button on the Reviews and appeals Learner Withdrawn page 
Then I should be navigated back to home page
And I have deleted LRS records from the database

