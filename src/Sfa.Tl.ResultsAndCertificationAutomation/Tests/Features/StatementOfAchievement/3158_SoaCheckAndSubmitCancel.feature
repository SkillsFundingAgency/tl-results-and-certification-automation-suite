Feature: 3158_SoaCheckAndSubmitCancel
	As a provider, 
	I want to cancel Statement of Achievement
	So I can cancel before submit

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley
And a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page

@RegressionTest @SOA
Scenario: 3158 Verify cancel SOA request page
When I click on "Cancel" link
Then I should see SOA cancel request page
And Back link should takes me to SOA check and submit page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3158 Cancel SOA request error validations 
When I click on "Cancel" link
And I click on "Continue" button
Then I should see the following error summary messages
| Error messages                                |
| Select yes if you want to cancel this request |
And I should see the following error message
| Error messages                                |
| Select yes if you want to cancel this request |
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3158 Do not cancel button
When I click on "Cancel" link
And I select No, do not cancel radio option
And I click on "Continue" button
Then It should takes me to SOA check and submit page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3158 Yes cancel button
When I click on "Cancel" link
And I select Yes cancel radio option
And I click on "Continue" button
Then It should takes me to home page
And the registration is deleted for this test