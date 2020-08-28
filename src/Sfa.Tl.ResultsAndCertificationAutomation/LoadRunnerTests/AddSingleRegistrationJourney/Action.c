//   *****************************************************************************************************************************************
//   ****   PLEASE NOTE: This is a READ-ONLY representation of the actual script. For editing please press the "Develop Script" button.   ****
//   *****************************************************************************************************************************************

Action()
{
	truclient_step("1", "Navigate to 'https://test.manage-tle...tlevels.gov.uk/'", "snapshot=Action_1.inf");
	truclient_step("2", "Click on Start now button", "snapshot=Action_2.inf");
	truclient_step("3", "Sign in", "snapshot=Action_3.inf");
	{
		truclient_step("3.1", "Click on Email address textbox", "snapshot=Action_3.1.inf");
		truclient_step("3.2", "Double click on Email address textbox", "snapshot=Action_3.2.inf");
		truclient_step("3.3", "Click on Email address textbox", "snapshot=Action_3.3.inf");
		truclient_step("3.4", "Type UserName in Email address textbox", "snapshot=Action_3.4.inf");
		truclient_step("3.5", "Click on Password passwordbox", "snapshot=Action_3.5.inf");
		truclient_step("3.6", "Type ******** in Password passwordbox", "snapshot=Action_3.6.inf");
		truclient_step("3.7", "Click on Sign in button", "snapshot=Action_3.7.inf");
	}
	truclient_step("4", "Click on PEARSON EDUCATION LIMITED...", "snapshot=Action_4.inf");
	truclient_step("5", "Click on Continue button", "snapshot=Action_5.inf");
	truclient_step("6", "Click on Registrations link", "snapshot=Action_6.inf");
	truclient_step("7", "Click on Add a new registration link", "snapshot=Action_7.inf");
	truclient_step("8", "Click on Enter the Unique Learner... textbox", "snapshot=Action_8.inf");
	truclient_step("9", "Type ULN in Enter the Unique Learner... textbox", "snapshot=Action_9.inf");
	truclient_step("10", "Click on Continue button", "snapshot=Action_10.inf");
	truclient_step("11", "Continue", "snapshot=Action_11.inf");
	{
		truclient_step("11.1", "Type FirstName in First name textbox", "snapshot=Action_11.1.inf");
		truclient_step("11.2", "Type LastName in Last name textbox", "snapshot=Action_11.2.inf");
		truclient_step("11.3", "Click on Continue button", "snapshot=Action_11.3.inf");
	}
	truclient_step("12", "Continue", "snapshot=Action_12.inf");
	{
		truclient_step("12.1", "Type Day in Day textbox", "snapshot=Action_12.1.inf");
		truclient_step("12.2", "Type Month in Month textbox", "snapshot=Action_12.2.inf");
		truclient_step("12.3", "Type Year in Year textbox", "snapshot=Action_12.3.inf");
		truclient_step("12.4", "Click on Continue button", "snapshot=Action_12.4.inf");
	}
	truclient_step("13", "Select Barking & Dagenham College (10000528) from Select the provider listbox", "snapshot=Action_13.inf");
	truclient_step("14", "Click on Continue button", "snapshot=Action_14.inf");
	truclient_step("15", "Select Catering and Hospitality (11011011) from Select the core listbox", "snapshot=Action_15.inf");
	truclient_step("16", "Click on Continue button", "snapshot=Action_16.inf");
	truclient_step("17", "Select Yes, add the specialism now from Yes, add the specialism... radiogroup", "snapshot=Action_17.inf");
	truclient_step("18", "Click on Continue button", "snapshot=Action_18.inf");
	truclient_step("19", "Click on Catering", "snapshot=Action_19.inf");
	truclient_step("20", "Click on Continue button", "snapshot=Action_20.inf");
	truclient_step("21", "Click on Continue button", "snapshot=Action_21.inf");
	truclient_step("23", "Click on Submit button", "snapshot=Action_23.inf");
	truclient_step("24", "Click on Back to registrations button", "snapshot=Action_24.inf");
	truclient_step("25", "Click on Search for a registration link", "snapshot=Action_25.inf");
	truclient_step("26", "Click on Enter the Unique Learner... textbox", "snapshot=Action_26.inf");
	truclient_step("27", "Type ULN in Enter the Unique Learner... textbox", "snapshot=Action_27.inf");
	truclient_step("28", "Click on Search button", "snapshot=Action_28.inf");
	truclient_step("29", "Click on Cancel this registration button", "snapshot=Action_29.inf");
	truclient_step("30", "Select Yes, cancel registration from Yes, cancel registration... radiogroup", "snapshot=Action_30.inf");
	truclient_step("32", "Click on Submit button", "snapshot=Action_32.inf");
	truclient_step("33", "Click on Back to registrations button", "snapshot=Action_33.inf");
	truclient_step("34", "Click on Sign out link", "snapshot=Action_34.inf");

	return 0;
}
