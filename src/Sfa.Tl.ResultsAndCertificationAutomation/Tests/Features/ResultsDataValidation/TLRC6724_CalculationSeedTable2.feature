Feature: TLRC6724 Calculation Seed Table 2
As per the user story, validate the T Levels along with a given core and specialism grade have the expected overall 
result for that combination recorded in the record in the [OverallGradeLookup] table


@RegressionTest @DataValidation
Scenario: TLRC_6724 Data Validation for Education and childcare
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel				    | Core Grade | Specialism Grade | Expected Grade | 
| Education and childcare	| A*		 | Distinction   	| Distinction*   | 
| Education and childcare	| A*		 | Merit			| Distinction    | 
| Education and childcare	| A*		 | Pass   			| Merit          | 
| Education and childcare	| A			 | Distinction		| Distinction    | 
| Education and childcare	| A			 | Merit			| Distinction    | 
| Education and childcare	| A			 | Pass				| Merit		     | 
| Education and childcare	| B			 | Distinction		| Distinction    | 
| Education and childcare	| B			 | Merit			| Merit		     | 
| Education and childcare	| B			 | Pass				| Merit          | 
| Education and childcare	| C			 | Distinction		| Distinction    | 
| Education and childcare	| C			 | Merit			| Merit          | 
| Education and childcare	| C			 | Pass				| Pass           | 
| Education and childcare	| D			 | Distinction    	| Merit          | 
| Education and childcare	| D			 | Merit			| Pass           | 
| Education and childcare	| D			 | Pass				| Pass           | 
| Education and childcare	| E			 | Distinction		| Pass           | 
| Education and childcare	| E			 | Merit			| Pass           | 
| Education and childcare	| E			 | Pass				| Pass           | 


@RegressionTest @DataValidation
Scenario: TLRC_6724 Data Validation for Science
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel	| Core Grade | Specialism Grade | Expected Grade | 
| Science	| A*		 | Distinction   	| Distinction*   | 
| Science	| A*		 | Merit			| Distinction    | 
| Science	| A*		 | Pass   			| Merit          | 
| Science	| A			 | Distinction		| Distinction    | 
| Science	| A			 | Merit			| Distinction    | 
| Science	| A			 | Pass				| Merit		     | 
| Science	| B			 | Distinction		| Distinction    | 
| Science	| B			 | Merit			| Merit		     | 
| Science	| B			 | Pass				| Merit          | 
| Science	| C			 | Distinction		| Distinction    | 
| Science	| C			 | Merit			| Merit          | 
| Science	| C			 | Pass				| Pass           | 
| Science	| D			 | Distinction    	| Merit          | 
| Science	| D			 | Merit			| Pass           | 
| Science	| D			 | Pass				| Pass           | 
| Science	| E			 | Distinction		| Pass           | 
| Science	| E			 | Merit			| Pass           | 
| Science	| E			 | Pass				| Pass           | 


@RegressionTest @DataValidation
Scenario: TLRC_6724 Data Validation for Onsite Construction
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel				    | Core Grade | Specialism Grade | Expected Grade | 
| Onsite Construction	| A*		 | Distinction   	| Distinction*   | 
| Onsite Construction	| A*		 | Merit			| Distinction    | 
| Onsite Construction	| A*		 | Pass   			| Merit          | 
| Onsite Construction	| A			 | Distinction		| Distinction    | 
| Onsite Construction	| A			 | Merit			| Distinction    | 
| Onsite Construction	| A			 | Pass				| Merit		     | 
| Onsite Construction	| B			 | Distinction		| Distinction    | 
| Onsite Construction	| B			 | Merit			| Merit		     | 
| Onsite Construction	| B			 | Pass				| Merit          | 
| Onsite Construction	| C			 | Distinction		| Distinction    | 
| Onsite Construction	| C			 | Merit			| Merit          | 
| Onsite Construction	| C			 | Pass				| Pass           | 
| Onsite Construction	| D			 | Distinction    	| Merit          | 
| Onsite Construction	| D			 | Merit			| Pass           | 
| Onsite Construction	| D			 | Pass				| Pass           | 
| Onsite Construction	| E			 | Distinction		| Pass           | 
| Onsite Construction	| E			 | Merit			| Pass           | 
| Onsite Construction	| E			 | Pass				| Pass           |
 
