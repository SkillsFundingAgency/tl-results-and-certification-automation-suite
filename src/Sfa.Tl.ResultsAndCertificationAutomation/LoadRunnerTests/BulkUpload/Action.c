//   *****************************************************************************************************************************************
//   ****   PLEASE NOTE: This is a READ-ONLY representation of the actual script. For editing please press the "Develop Script" button.   ****
//   *****************************************************************************************************************************************

Action()
{
	lr_start_transaction("Start Page");
	truclient_step("1", "Navigate to https://test.manage-tlev....tlevels.gov.uk/", "snapshot=Action_1.inf");
	lr_end_transaction("Start Page");
	lr_start_transaction("SignIn");
	truclient_step("2", "Click on Start now button", "snapshot=Action_2.inf");
	truclient_step("3", "Sign in", "snapshot=Action_3.inf");
	{
		truclient_step("3.1", "Click on Email address textbox", "snapshot=Action_3.1.inf");
		truclient_step("3.2", "Type UserName in Email address textbox", "snapshot=Action_3.2.inf");
		truclient_step("3.3", "Type ******** in Password passwordbox", "snapshot=Action_3.3.inf");
		truclient_step("3.4", "Click on Sign in button", "snapshot=Action_3.4.inf");
	}
	lr_end_transaction("SignIn");
	lr_start_transaction("Registration Page");
	truclient_step("4", "Click on Registrations link", "snapshot=Action_4.inf");
	lr_end_transaction("Registration Page");
	lr_start_transaction("Registration upload Page");
	truclient_step("5", "Click on Upload registrations file link", "snapshot=Action_5.inf");
	lr_end_transaction("Registration upload Page");
	lr_start_transaction("Upload File");
	truclient_step("6", "Set File on Upload a file filebox", "snapshot=Action_6.inf");
	lr_end_transaction("Upload File");
	lr_start_transaction("Submit Registration");
	truclient_step("7", "Click on Submit button", "snapshot=Action_7.inf");
	lr_end_transaction("Submit Registration");
	lr_start_transaction("Back to Registration Page");
	truclient_step("8", "Click on Back to registrations button", "snapshot=Action_8.inf");
	lr_end_transaction("Back to Registration Page");

	return 0;
}
