Feature: 3823_LearnerWithdrawnPage
	As an AO with a results editor user role
	I need to know that a learner has been withdrawn
	So that I cannot add or change their grade from the results journey

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I have moved registration in to withdrawn state

@RegressionTest @Results
Scenario: 3823_Verify learner withdrawn page
And I click on "Results" link
When I search the learner
Then I should see learner withdrawn page
And Back link should take me to searhc learner page with Uln
And Search again shoud take me to searhc learner page without Uln
And the registration for this test is deleted

@RegressionTest @Results
Scenario: 3823_Navigate to dashboard
And I click on "Results" link
When I search the learner
Then I should see learner withdrawn page
And click on back to home should takes me to dashboard page
And the registration for this test is deleted

