Feature: 1783_ReregisterChangeSpecialismPage
	As a Registrations Editor
	I need to be able to change the provider
	So that when I submit student data when registering a student on a new course I can be sure the details are correct

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
And I click Continue in Academic Year page

@RegressionTest @ReactivateRegistration
Scenario: 1783_Verify reregister change specialism Page
When I click on reregister change specialism link
Then I should see has learner decide page and Yes option is prechecked
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1783_Reregister change another specialism
And I click on reregister change specialism link
And I click continue in reregister has learner decide page
And I unchecked the original value and select another specialism and click change
Then I should see new specialism in check and submit page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1783_Reregister Back to check and submit from Learner decide page
And I click on reregister change specialism link
And I click on Back link
Then I should see reregister check and submit page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1783_Reregister Remove specialism
And I click on reregister change specialism link
When I select No from has decided specialism and click Continue
Then I should not see specialism on check and submit page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1783_Reregister Back to check and submit from specialism page
And I click on reregister change specialism link
And I select No from has decided specialism and click Continue
And I click on reregister change specialism link
When I click on Back link on page
Then I should see reregister check and submit page without specialism
And I cleared the data in DB