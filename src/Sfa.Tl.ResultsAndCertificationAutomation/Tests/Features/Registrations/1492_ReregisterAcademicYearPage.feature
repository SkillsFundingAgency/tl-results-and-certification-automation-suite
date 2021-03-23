Feature: 1492_ReregisterAcademicYearPage
	As a Registrations Editor
	I need to select Academic Year
	So record can be updated

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1492_Verify Reregister Academic year Page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
Then I should see Reregister Academic year page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1492_Verify Reregister Academic year Back link
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
When I click on Back link on page
Then I should be navigated back to reregister select specalism page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1492_Reregister Academic year From Learner Decide Page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select No from has decided specialism and click Continue
Then I should see Reregister Academic year page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1492_Reregister Academic year Back To Learner Decide Page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select No from has decided specialism and click Continue
When I click on Back link on page
Then I should be navigated back to Reregister Has learner decide page
And previous selected radio option retained
And I cleared the data in DB