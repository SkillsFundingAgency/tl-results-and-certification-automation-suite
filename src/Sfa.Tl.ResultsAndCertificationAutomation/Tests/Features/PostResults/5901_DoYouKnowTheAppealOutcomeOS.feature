Feature: 5901_DoYouKnowTheAppealOutcomeOS

As an AO, I need the ability to inform ESFA if there has been an outcome of an initiated APPEAL, so that the service is up-to-date with any APPEAL outcome. 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with Romm outcome recorded
And I am on post results learner details page
And I click "Add specialism1 appeal" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5901 Verify do you know specialism appeal outcome page
	When I select "Yes, request appeal" radio button on add appeal Page
	Then do you know the appeal outcome page is shown
	And specialism details shown on do you know the core appeal page
	And back link takes me to add an appeal page