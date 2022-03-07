Feature: 3475_UlnNotFound
	As an AO with a results editor user role
	I need an error page when searching for non existed Uln
	So I understand that I need to search again or contact the registrations editor

Background: 
Given I have logged in as a "ResultsEditor" user
And I am on reviews and appeals search for learner page

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3475 Verify Uln not found page
When I enter non existed Uln and click Search button
Then ULN not found page is shown
And click on backlink takes me to search uln page with Uln prepopulated
And search again takes me to search uln page with no Uln prepopulated

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3475 Back to home navigation
When I enter non existed Uln and click Search button
Then ULN not found page is shown
And click on back to home takes me back to home page
