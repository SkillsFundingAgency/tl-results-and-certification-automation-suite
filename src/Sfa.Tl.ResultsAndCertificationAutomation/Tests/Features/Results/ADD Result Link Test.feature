Feature: Add result test
	As an AO with a results editor user role
	I need to know that a learner has no assessment entries
	So that I cannot add or change their grade from the results journey

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
##And I have a registration with result


@RegressionTest @Results
Scenario: 1111_AR_Verify learner no assessment page
Given I create a reg with core and assessment
And I click on "Results" link
When I search the learner
And I click the "1st" Add result link
##Then I should see learner result no assessment page
##And Back link should take me to search learner page with Uln
###And Search again shoud take me to search learner page without Uln
##And the registration for this test is deleted

