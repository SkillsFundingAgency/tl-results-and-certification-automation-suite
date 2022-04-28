Feature: Feature: TLRC_3160 Statement of Achievement - Change POstal Address
	As a provider, 
	if I select Change next to Your organisation’s postal address on the check learner details page 
	then the request-statement-of-achievement-change-postal-address should be displayed

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@Ignore @RegressionTest @SOA
Scenario: 3160_Validate Statement of Achievement - Change Learner's T-Level Component Achievements page and Back link
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I click on the Change link next to the organisation’s postal address
Then I am shown the Change your organisation’s postal address page
And I click the Back link on the Statement of Achievement - Change your organisation’s postal address page
Then the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@Ignore @RegressionTest @SOA
Scenario: 3160_Validate the Manage Learner T Level Record button
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I click on the Change link next to the organisation’s postal address
And I click the Change address button on the Statement of Achievement - Change Learner's T-Level Component Achievements page
Then the Manage Postal Address page is displayed 
And the registration is deleted for this test