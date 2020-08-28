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
		truclient_step("3.2", "Type UserName in Email address textbox", "snapshot=Action_3.2.inf");
		truclient_step("3.3", "Click on Password passwordbox", "snapshot=Action_3.3.inf");
		truclient_step("3.4", "Type ******** in Password passwordbox", "snapshot=Action_3.4.inf");
		truclient_step("3.5", "Click on Sign in button", "snapshot=Action_3.5.inf");
	}
	truclient_step("4", "Click on PEARSON EDUCATION LIMITED...", "snapshot=Action_4.inf");
	truclient_step("5", "Click on Continue button", "snapshot=Action_5.inf");
	truclient_step("6", "Click on T Levels link", "snapshot=Action_6.inf");
	truclient_step("7", "Click on View T Level in Creative... link", "snapshot=Action_7.inf");
	truclient_step("8", "Click on Query T Level details link", "snapshot=Action_8.inf");
	truclient_step("9", "Click on Back link", "snapshot=Action_9.inf");
	truclient_step("10", "Click on Return to your T Levels... link", "snapshot=Action_10.inf");
	truclient_step("11", "Click on View T Level in Design,... link", "snapshot=Action_11.inf");
	truclient_step("12", "Click on Query T Level details link", "snapshot=Action_12.inf");
	truclient_step("13", "Click on Back link", "snapshot=Action_13.inf");
	truclient_step("14", "Click on Return to your T Levels... link", "snapshot=Action_14.inf");
	truclient_step("15", "Click on Sign out link", "snapshot=Action_15.inf");

	return 0;
}
