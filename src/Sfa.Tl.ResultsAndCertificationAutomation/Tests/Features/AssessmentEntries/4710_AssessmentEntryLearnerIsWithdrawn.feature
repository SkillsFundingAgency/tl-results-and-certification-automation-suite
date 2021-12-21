Feature: 4710_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - learner is withdrawn
	Give users a clear option to go back to the home page quickly to perform other actions, 
	provides more learner details, 
	learner details structured with accessibility in mind, 
	provides further information to users to know what they have to do to progress through this journey further.

Background: 
Given I have logged in as a "SiteAdmin" user
And I have a registration with result
And I have moved registration in to withdrawn state

@RegressionTest @AssessmentEntries
Scenario: 4710_Verify learner withdrawn page and the page buttons and links
Given I navigate to the Search for a learner page
And I search for my withdrawn registration
Then I should see the Learner has been withdrawn page
When I click on the back link on the learner withdrawn page
Then I am taken to the Assessment search page with Uln prepopulated
When I press the Search again button on the learner withdrawn page
Then I am taken to the Assessment search page with the Search field empty
When I press the Back to home button on the learner withdrawn page
Then I should be navigated back to home page
And the registration for this test is deleted



