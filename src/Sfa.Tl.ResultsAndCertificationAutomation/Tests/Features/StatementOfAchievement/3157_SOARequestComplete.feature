Feature: 3157_Statement of Achievement - Request Complete
	As a provider, 
	when I click ‘Accept and send request’  on the check the learner’s details page,
	I should be presented with the request complete page which will display the green  box, the learner name and the learner ULN.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@RegressionTest @SOA
Scenario: 3157_Verify Request Statmewnt of achievement confirmation page
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I click the Accept and send request button
Then the Request statement of achievement confirmation page is displayed
And I press the Back to home button on the statement of achievement confirmation page
Then I will be navigated to the T Levels Dashboard page
And the registration is deleted for this test
