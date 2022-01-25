Feature: 3808_LearnerNoAssessmentEntriesPage
	As an AO with a results editor user role
	I need to know that a learner has no assessment entries
	So that I cannot add or change their grade from the results journey

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration without assessment and result
And I click on "Results" link

@Ignore @RegressionTest @Results
Scenario: 3808_Verify learner no assessment page
When I search the learner
Then I should see learner result no assessment page
And Back link should take me to search learner page with Uln
And Search again shoud take me to search learner page without Uln
And the registration for this test is deleted

@Ignore @RegressionTest @Results
Scenario: 3808_Navigate to dashboard
When I search the learner
Then I should see learner result no assessment page
And click on back to home should takes me to dashboard page
And the registration for this test is deleted
