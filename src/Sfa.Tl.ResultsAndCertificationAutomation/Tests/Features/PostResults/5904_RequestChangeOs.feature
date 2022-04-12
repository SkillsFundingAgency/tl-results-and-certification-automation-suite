Feature: 5904_RequestChangeOs


As an AO, I need the ability to request a grade to be changed after it has moved into ‘FINAL’ , so that I am able to get the record updated before overall grade calculation.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have registration with results in final state
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5904 Specialism request change a final grade page
	When I click "Specialism1 request change" button in post result learner details page
	Then requst change a final grade page is shown
	And back link takes me to post result learner details page

