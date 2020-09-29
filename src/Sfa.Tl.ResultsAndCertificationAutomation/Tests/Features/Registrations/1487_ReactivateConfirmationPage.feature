Feature: 1487_ReactivateConfirmationPage
	As a Registrations Editor
	I need to be able to see confirmation that I have rejoined a learner onto their course
	So that I can ensure this has been done

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1487_Reactivate Confirmation Page
When I select Reactivate with same course radio button and click continue
And I select Yes I want to reactivate option and click submit
Then I should see reactivation success page

@RegressionTest @ReactivateRegistration
Scenario: 1487_Reactivate Confirmation Details
When I select Reactivate with same course radio button and click continue
And I select Yes I want to reactivate option and click submit
And I click on view this registration details button
Then I should see active registration details page

@RegressionTest @ReactivateRegistration
Scenario: 1487_ Reactivate Confirmation Details Home button
When I select Reactivate with same course radio button and click continue
And I select Yes I want to reactivate option and click submit
And I click on Home button in confirmation page
Then I should be navated back to dashboard
