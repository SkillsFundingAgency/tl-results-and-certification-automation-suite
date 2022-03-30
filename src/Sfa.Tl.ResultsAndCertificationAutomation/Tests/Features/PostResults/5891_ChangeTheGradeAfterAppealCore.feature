Feature: 5891_ChangeTheGradeAfterAppealCore

As an AO, I need the ability to change the grade after a APPEAL outcome, so that the learners record is updated with any change to the grade

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @PostResults
Scenario: 5891 Change the core grade after appeal
	Given I have a registration with appeal recorded
	And I am on post results learner details page
	And I click "Add core outcome" button in post result learner details page
	When I select "The grade has changed" in appeal outcome page
	Then change the grade after appeal page is shown
	And core deails shown on change the grade after appeal page
	And back link takes me to add an appeal outcome page

@RegressionTest @PostResults
Scenario: 5891 Validate errors on change the grade after appeal page
	And I have a registration with appeal recorded
	And I am on post results learner details page
	And I click "Add core outcome" button in post result learner details page
	When I select "The grade has changed" in appeal outcome page
	And I click continue without selecting grade on change grade after romm page
	Then error message shown on change grade after appeal page
	| Error message        |
	| Select the new grade |
	And error summary shown on change grade after appeal page
	| Error summary        |
	| Select the new grade |

@RegressionTest @PostResults
Scenario: 5891 Change the core grade after appeal from add appeal
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add core appeal" button in post result learner details page
And I select "Yes, request appeal" radio button on add appeal Page
When I select "Grade has changed" radio and click continue in do you know outcome appeal page
Then change the grade after appeal page is shown
And core deails shown on change the grade after appeal page
And back link takes me to do you know the appeal outcome page