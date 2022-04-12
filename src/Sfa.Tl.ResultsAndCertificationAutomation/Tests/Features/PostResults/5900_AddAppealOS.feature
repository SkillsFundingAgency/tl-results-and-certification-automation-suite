Feature: 5900_AddAppealOS

As an AO, I need the ability to inform ESFA that the learner has requested an APPEAL of a grade, so that overall grade is not calculated until result has been through an appeal.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with Romm outcome recorded
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5900 Verify add an appeal for specialism page
	When I click "Add specialism1 appeal" button in post result learner details page
	Then Add an appeal page is shown
	And specialism details shown in learner details
	And back link takes me to post result learner details page
