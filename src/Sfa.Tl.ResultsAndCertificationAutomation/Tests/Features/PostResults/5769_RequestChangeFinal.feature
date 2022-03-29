Feature: 5769_RequestChangeFinal

As an AO, I need the ability to request a grade to be changed after it has moved into ‘FINAL’ , so that I am able to get the record updated before overall grade calculation.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have registration with results in final state
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5769 Verify request change a final grade page
	When I click "Core request change" button in post result learner details page
	Then requst change a final grade page is shown
	And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5769 Error validations request change a final grade page
When I click "Core request change" button in post result learner details page
And I click on Send button without entering data
Then error message shown on request change a final grade page
| Error message                                  |
| Please tell us what you need to change and why |
And error summary shown on request change a final grade page
| Error summary                                  |
| Please tell us what you need to change and why |
