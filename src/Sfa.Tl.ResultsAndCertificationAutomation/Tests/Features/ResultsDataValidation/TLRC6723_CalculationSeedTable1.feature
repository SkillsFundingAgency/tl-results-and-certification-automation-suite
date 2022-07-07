Feature: TLRC6723_CalculationSeedTable1
As per the user story, validate the T Levels along with a given core and specialism grade have the expected overall 
result for that combination recorded in the record in the [OverallGradeLookup] table


@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Health
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel    | Core Grade | Specialism Grade | Expected Grade | 
| Health	| A			 | Distinction		| Distinction    | 
| Health	| A			 | Merit			| Distinction    | 
| Health	| A			 | Pass				| Merit		     | 
| Health	| B			 | Distinction		| Distinction    | 
| Health	| B			 | Merit			| Merit		     | 
| Health	| B			 | Pass				| Merit          | 
| Health	| C			 | Distinction		| Merit		     | 
| Health	| C			 | Merit			| Merit          | 
| Health	| C			 | Pass				| Pass           | 
| Health	| D			 | Distinction    	| Merit          | 
| Health	| D			 | Merit			| Pass           | 
| Health	| D			 | Pass				| Pass           | 
| Health	| E			 | Distinction		| Pass           | 
| Health	| E			 | Merit			| Pass           | 
| Health	| E			 | Pass				| Pass           | 
| Health	| A*		 | Distinction   	| Distinction*   | 
| Health	| A*		 | Merit			| Distinction    | 
| Health	| A*		 | Pass   			| Distinction    | 

@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Healthcare Science
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel			    | Core Grade | Specialism Grade | Expected Grade | 
| Healthcare Science	| A			 | Distinction		| Distinction    | 
| Healthcare Science	| A			 | Merit			| Distinction    | 
| Healthcare Science    | A			 | Pass				| Merit		     | 
| Healthcare Science	| B			 | Distinction		| Distinction    | 
| Healthcare Science	| B			 | Merit			| Merit		     | 
| Healthcare Science	| B			 | Pass				| Merit          | 
| Healthcare Science	| C			 | Distinction		| Merit		     | 
| Healthcare Science	| C			 | Merit			| Merit          | 
| Healthcare Science	| C			 | Pass				| Pass           | 
| Healthcare Science	| D			 | Distinction    	| Merit          | 
| Healthcare Science	| D			 | Merit			| Pass           | 
| Healthcare Science	| D			 | Pass				| Pass           | 
| Healthcare Science	| E			 | Distinction		| Pass           | 
| Healthcare Science	| E			 | Merit			| Pass           | 
| Healthcare Science	| E			 | Pass				| Pass           | 
| Healthcare Science	| A*		 | Distinction   	| Distinction*   | 
| Healthcare Science	| A*		 | Merit			| Distinction    | 
| Healthcare Science	| A*		 | Pass   			| Distinction    | 


@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Digital Production, Design and Development
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel			                            | Core Grade | Specialism Grade | Expected Grade | 
| Digital Production, Design and Development	| A			 | Distinction		| Distinction    | 
| Digital Production, Design and Development	| A			 | Merit			| Distinction    | 
| Digital Production, Design and Development	| A			 | Pass				| Merit			 | 
| Digital Production, Design and Development	| B			 | Distinction		| Distinction    | 
| Digital Production, Design and Development	| B			 | Merit			| Merit		     | 
| Digital Production, Design and Development	| B			 | Pass				| Merit          | 
| Digital Production, Design and Development	| C			 | Distinction		| Merit		     | 
| Digital Production, Design and Development	| C			 | Merit			| Merit          | 
| Digital Production, Design and Development	| C			 | Pass				| Pass           | 
| Digital Production, Design and Development	| D			 | Distinction    	| Merit          | 
| Digital Production, Design and Development	| D			 | Merit			| Pass           | 
| Digital Production, Design and Development	| D			 | Pass				| Pass           | 
| Digital Production, Design and Development	| E			 | Distinction		| Pass           | 
| Digital Production, Design and Development	| E			 | Merit			| Pass           | 
| Digital Production, Design and Development	| E			 | Pass				| Pass           | 
| Digital Production, Design and Development	| A*		 | Distinction   	| Distinction*   | 
| Digital Production, Design and Development	| A*		 | Merit			| Distinction    | 
| Digital Production, Design and Development	| A*		 | Pass   			| Distinction    | 


@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Digital Business Services
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel			        | Core Grade | Specialism Grade | Expected Grade | 
| Digital Business Services	| A			 | Distinction		| Distinction    | 
| Digital Business Services	| A			 | Merit			| Distinction    | 
| Digital Business Services	| A			 | Pass				| Merit          | 
| Digital Business Services	| B			 | Distinction		| Distinction    | 
| Digital Business Services	| B			 | Merit			| Merit		     | 
| Digital Business Services	| B			 | Pass				| Merit          | 
| Digital Business Services	| C			 | Distinction		| Merit		     | 
| Digital Business Services	| C			 | Merit			| Merit          | 
| Digital Business Services	| C			 | Pass				| Pass           | 
| Digital Business Services	| D			 | Distinction    	| Merit          | 
| Digital Business Services	| D			 | Merit			| Pass           | 
| Digital Business Services	| D			 | Pass				| Pass           | 
| Digital Business Services	| E			 | Distinction		| Pass           | 
| Digital Business Services | E			 | Merit			| Pass           | 
| Digital Business Services	| E			 | Pass				| Pass           | 
| Digital Business Services	| A*		 | Distinction   	| Distinction*   | 
| Digital Business Services	| A*		 | Merit			| Distinction    | 
| Digital Business Services	| A*		 | Pass   			| Distinction    | 

@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Digital Support Services
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel			        | Core Grade | Specialism Grade | Expected Grade | 
| Digital Support Services	| A			 | Distinction		| Distinction    | 
| Digital Support Services	| A			 | Merit			| Distinction    | 
| Digital Support Services	| A			 | Pass				| Merit		     | 
| Digital Support Services	| B			 | Distinction		| Distinction    | 
| Digital Support Services	| B			 | Merit			| Merit		     | 
| Digital Support Services	| B			 | Pass				| Merit          | 
| Digital Support Services	| C			 | Distinction		| Merit		     | 
| Digital Support Services	| C			 | Merit			| Merit          | 
| Digital Support Services	| C			 | Pass				| Pass           | 
| Digital Support Services	| D			 | Distinction    	| Merit          | 
| Digital Support Services	| D			 | Merit			| Pass           | 
| Digital Support Services	| D			 | Pass				| Pass           | 
| Digital Support Services	| E			 | Distinction		| Pass           | 
| Digital Support Services  | E			 | Merit			| Pass           | 
| Digital Support Services	| E			 | Pass				| Pass           | 
| Digital Support Services	| A*		 | Distinction   	| Distinction*   | 
| Digital Support Services	| A*		 | Merit			| Distinction    | 
| Digital Support Services	| A*		 | Pass   			| Distinction    | 


@RegressionTest @DataValidation
Scenario: TLRC_6723 Data Validation for Design, Surveying and Planning
Given I have run the query to return all results from Overall Grade Lookup table using "<TLevel>" "<Core Grade>" "<Specialism Grade>"
Then I should see the Overall Result match the "<Expected Grade>"

Examples: 
| TLevel                            | Core Grade | Specialism Grade | Expected Grade | 
| Design, Surveying and Planning	| A			 | Distinction		| Distinction    | 
| Design, Surveying and Planning	| A			 | Merit			| Distinction    | 
| Design, Surveying and Planning	| A			 | Pass				| Merit		     | 
| Design, Surveying and Planning	| B			 | Distinction		| Distinction    | 
| Design, Surveying and Planning	| B			 | Merit			| Merit		     | 
| Design, Surveying and Planning	| B			 | Pass				| Merit          | 
| Design, Surveying and Planning	| C			 | Distinction		| Merit		     | 
| Design, Surveying and Planning	| C			 | Merit			| Merit          | 
| Design, Surveying and Planning	| C			 | Pass				| Pass           | 
| Design, Surveying and Planning	| D			 | Distinction    	| Merit          | 
| Design, Surveying and Planning	| D			 | Merit			| Pass           | 
| Design, Surveying and Planning	| D			 | Pass				| Pass           | 
| Design, Surveying and Planning	| E			 | Distinction		| Pass           | 
| Design, Surveying and Planning	| E			 | Merit			| Pass           | 
| Design, Surveying and Planning	| E			 | Pass				| Pass           | 
| Design, Surveying and Planning	| A*		 | Distinction   	| Distinction*   | 
| Design, Surveying and Planning	| A*		 | Merit			| Distinction    | 
| Design, Surveying and Planning	| A*		 | Pass   			| Distinction    |
 
