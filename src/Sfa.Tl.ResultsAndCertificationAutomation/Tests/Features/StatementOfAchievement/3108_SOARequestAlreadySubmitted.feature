Feature: Feature: TLRC_3108 Statement of Achievement - ULN2 - Request already submitted
	As a provider, 
	if I search for a ULN where a statement of achievement request has already been submitted within the last 21 calendar days 
	a new page will be displayed
    So that I know I can not submit another request, and I can see the details of when the last request was submitted and the learner’s data

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for LRS registration (Maths achieved Eng not achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for LRS registration (Maths Not achieved Eng achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-A' and 'IP completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for LRS registration (Maths and English achieved)
Given a registration is created for LRS where 'MathEng Achieved Min Standard' and 'IP still to be completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement still to be completed' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for LRS registration (Maths and English both not achieved)
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-NA' and 'IP completed with special consideration'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed with special consideration' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test


@RegressionTest @SOA
Scenario: 3108_Validate breadcrumbs on SOA Request already submitted page
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard' and 'IP completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And I press the 'Search for a learner' breadcrumb on the SOA Request already submitted page
Then I am shown the Request SOA Search for a learner page
When I navigate back to the SOA Request already submitted page from the Request Statement of Achievement -  Search for a learner page
And I press the 'Request statement of achievement' breadcrumb on the SOA Request already submitted page
Then I am shown the Request statement of achievement page
When I navigate back to the SOA Request already submitted page from the request Statement of Achievement page
And I press the 'Home' breadcrumb on the SOA Request already submitted page
Then I will be navigated to the T Levels Dashboard page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for NON LRS registration (Achieved min standard)
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard' and 'IP completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Achieved minimum standard' and IP displays 'Placement completed' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for NON LRS registration (Achieved min standard with SEND)
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard for learners with SEND' and 'IP completed with special consideration'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Achieved minimum standard' and IP displays 'Placement completed with special consideration' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test

@RegressionTest @SOA
Scenario: 3108_Validate SOA Request already submitted page for NON LRS registration (Not achieved min standard)
Given a registration is created for NON LRS where 'MathEng not achieved the minimum standard' and 'IP not completed'
And I requested a statement of achievement
And I attempt to request a statement of achievement again within 21 days 
Then I am shown the Statement of achievement already requested page
And the learners T Level component achievement details display 'Not achieved minimum standard' and IP displays 'Placement still to be completed' on the Request already submitted page
And the learners registration and qualification details are shown on the Request already submitted page
And the registration is deleted for this test
