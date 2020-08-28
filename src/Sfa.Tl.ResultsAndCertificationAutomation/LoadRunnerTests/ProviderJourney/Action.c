//   *****************************************************************************************************************************************
//   ****   PLEASE NOTE: This is a READ-ONLY representation of the actual script. For editing please press the "Develop Script" button.   ****
//   *****************************************************************************************************************************************

Action()
{
	truclient_step("1", "Navigate to 'https://test.manage-tle...tlevels.gov.uk/'", "snapshot=Action_1.inf");
	truclient_step("2", "Reload current page", "snapshot=Action_2.inf");
	truclient_step("3", "Click on Start now button", "snapshot=Action_3.inf");
	truclient_step("4", "Sign in", "snapshot=Action_4.inf");
	{
		truclient_step("4.1", "Click on Email address textbox", "snapshot=Action_4.1.inf");
		truclient_step("4.2", "Type UserName in Email address textbox", "snapshot=Action_4.2.inf");
		truclient_step("4.3", "Type ******** in Password passwordbox", "snapshot=Action_4.3.inf");
		truclient_step("4.4", "Press key Enter on Password passwordbox", "snapshot=Action_4.4.inf");
	}
	truclient_step("5", "Click on PEARSON EDUCATION LIMITED... label", "snapshot=Action_5.inf");
	truclient_step("6", "Click on Continue button", "snapshot=Action_6.inf");
	truclient_step("7", "Click on Providers link", "snapshot=Action_7.inf");
	truclient_step("8", "Click on Enter the provider's name combobox", "snapshot=Action_8.inf");
	truclient_step("9", "Type ProviderName in Enter the provider's name combobox", "snapshot=Action_9.inf");
	truclient_step("10", "Click on Continue button", "snapshot=Action_10.inf");
	truclient_step("11", "Click on Continue button", "snapshot=Action_11.inf");
	truclient_step("12", "Click on T Level in Creative and...", "snapshot=Action_12.inf");
	truclient_step("13", "Click on T Level in Creative Catering...", "snapshot=Action_13.inf");
	truclient_step("14", "Click on Submit button", "snapshot=Action_14.inf");
	truclient_step("15", "Click on Find another provider button", "snapshot=Action_15.inf");
	truclient_step("16", "Click on Enter the provider's name combobox", "snapshot=Action_16.inf");
	truclient_step("17", "Type ProviderName in Enter the provider's name combobox", "snapshot=Action_17.inf");
	truclient_step("18", "Click on Continue button", "snapshot=Action_18.inf");
	truclient_step("19", "Click on Continue button", "snapshot=Action_19.inf");
	truclient_step("20", "Click on Remove T Level in Creative... link", "snapshot=Action_20.inf");
	truclient_step("21", "Click on Yes, remove T Level", "snapshot=Action_21.inf");
	truclient_step("22", "Click on Submit button", "snapshot=Action_22.inf");
	truclient_step("23", "Click on Manage provider's T Level... link", "snapshot=Action_23.inf");
	truclient_step("24", "Click on Remove T Level in Creative... link", "snapshot=Action_24.inf");
	truclient_step("25", "Click on Yes, remove T Level", "snapshot=Action_25.inf");
	truclient_step("26", "Click on Submit button", "snapshot=Action_26.inf");
	truclient_step("27", "Click on Sign out link", "snapshot=Action_27.inf");

	return 0;
}
