Feature: Feature: TLRC_3156 Statement of Achievement - Check the learner details before sending your request
	As a provider, 
	if I search for a ULN that has been registered, has component results recorded and has been withdrawn by AO 
	then the ‘Check the learner’s details before sending your request' page should be displayed

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for LRS registration (Maths achieved Eng not achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test


@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for LRS registration (Maths Not achieved Eng achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-A' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for LRS registration (Maths and English achieved)
Given a registration is created for LRS where 'MathEng Achieved Min Standard' and 'IP still to be completed'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement still to be completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for LRS registration (Maths and English both not achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-NA' and 'IP completed with special consideration'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed with special consideration'
And the learners registration and qualification details are shown
And the registration is deleted for this test


@RegressionTest @SOA
Scenario: 3156_Verify breadcrumbs on Request Statement of Achievement Check and Submit page
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I press the 'Search for a learner' breadcrumb on the Request SOA Check and Submit page
Then I am shown the Request SOA Search for a learner page
When I navigate back to the Request SOA Check and Submit page from the request Statement of Achievement -  Search for a learner page
And I press the 'Request statement of achievement' breadcrumb on the Request SOA Check and Submit page
Then I am shown the Request statement of achievement page
When I navigate back to the Request SOA Check and Submit page from the request Statement of Achievement page
And I press the 'Home' breadcrumb on the Request SOA Check and Submit page
Then I will be navigated to the T Levels Dashboard page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for NON LRS registration (Achieved min standard)
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Achieved minimum standard' and IP displays 'Placement completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for NON LRS registration (Achieved min standard with SEND)
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard for learners with SEND' and 'IP completed with special consideration'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Achieved minimum standard' and IP displays 'Placement completed with special consideration'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3156_Validate Check and submit page for NON LRS registration (Not achieved min standard)
Given a registration is created for NON LRS where 'MathEng not achieved the minimum standard' and 'IP not completed'
And I navigate to Request statement of achievment - Check and submit page
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard' and IP displays 'Placement still to be completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test
