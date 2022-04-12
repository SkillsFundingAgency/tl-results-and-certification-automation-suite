Feature: 5902_ChangeTheGradeAfterAppealOs

As an AO, I need the ability to change the grade after a APPEAL outcome, so that the learners record is updated with any change to the grade

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 5902 Change the specialism grade after appeal
	Given I have a registration with appeal recorded
	And I am on post results learner details page
	And I click "Add specialism1 outcome" button in post result learner details page
	When I select "The grade has changed" in appeal outcome page
	Then change the grade after appeal page is shown
	And specialism deails shown on change the grade after appeal page
	And back link takes me to add an appeal outcome page

@RegressionTest @PostResults
Scenario: 5902 Change the specialism grade after appeal from add appeal
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add specialism1 appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
When I select "Grade has changed" radio and click continue in do you know outcome appeal page
Then change the grade after appeal page is shown
And specialism deails shown on change the grade after appeal page
And back link takes me to do you know the appeal outcome page