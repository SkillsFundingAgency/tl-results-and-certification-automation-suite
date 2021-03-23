Feature: 1479_AreYouSureReactivateRegPage
	As a Registrations Editor
	I need to confirm a rejoin
	So that I know the student will rejoin the course

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1479_Are You Sure Reactivate with Same course page
When I select Reactivate with same course radio button and click continue
Then I should see Are you sure you want to reactivate page
And the registration for this test is deleted

@RegressionTest @ReactivateRegistration
Scenario: 1479_Are You Sure Reactivate with Same course page validations
When I select Reactivate with same course radio button and click continue
And I click Submit button without selecting options
Then I should see validation error in Are you sure reactivate page
And the registration for this test is deleted

@RegressionTest @ReactivateRegistration
Scenario: 1479_Are You Sure Reactivate with Same course page Back link
When I select Reactivate with same course radio button and click continue
And I click on Back link on page
Then I should be navigated back to Reactivte options page
And the Reactivate with same course radoi button should be selected
And the registration for this test is deleted

@RegressionTest @ReactivateRegistration
Scenario: 1479_Are You Sure Reactivate No Option
When I select Reactivate with same course radio button and click continue
And I select No do not reactivate radio button and click submit button
Then I should be navigated back to Reactivte options page
And the registration for this test is deleted