Feature: 2848_Linking English & Maths achievement and IP page
	As a Provider
	I need to continue my journey after having declared the status of English & Maths
	So that learner data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page

@RegressionTest @Provider
Scenario:  2848_Validate retention of radio buttons selection after pressing back link on IP page

Given I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
Then I expect to see the learner completed Industry Placement page
And when I press the back link on the 'Has the learner achieved the required minimum standard for English and maths' page
Then the 'Has learner achieved the minimum standard for English and maths' page is displayed with "Achieved the minimum standard" still selected
When I select "Achieved the minimum standard for learners with SEND" radio button on 'Min standard for English Maths' page and press Continue
Then I expect to see the learner completed Industry Placement page
And when I press the back link on the 'Has the learner achieved the required minimum standard for English and maths' page
Then the 'Has learner achieved the minimum standard for English and maths' page is displayed with "Achieved the minimum standard for learners with SEND" still selected
When I select "Not achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
Then I expect to see the learner completed Industry Placement page
And when I press the back link on the 'Has the learner achieved the required minimum standard for English and maths' page
Then the 'Has learner achieved the minimum standard for English and maths' page is displayed with "Not achieved the minimum standard" still selected
And I have deleted LRS records from the database
