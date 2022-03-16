Feature: 5742_PostResultsStartPage

As a AO, I need additional information on post-service actions, so that I am better informed of what is required from me.

@RegressionTest @PostResults
Scenario: 5742 Verify Post-results start page
Given I have logged in as a "ResultsEditor" user
When I click on "Post-results" link
Then I should see Post results start page
And clicking Home breadcrumb takes me to home page
