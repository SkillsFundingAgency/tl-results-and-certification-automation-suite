using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class UserDashboardSteps : Hooks
    {
        [Given(@"I have logged in as a ""(.*)"" user")]
        public void GivenIHaveLoggedInAsAUser(string p0)
        {
            switch (p0)
                {
                    case "SiteAdmin":
                        DfESignInPage.SigninAsSiteAdmin();
                        break;
                    case "AllUser":
                        DfESignInPage.SigninAsAllUser();
                        break;
                    case "ReviewerAndProvider":
                        DfESignInPage.SigninAsRevProvUser();
                        break;
                    case "Reviewer":
                        DfESignInPage.SigninAsReviewer();
                        break;
                    case "Provider":
                        DfESignInPage.SigninAsProvider();
                        break;
                    case "RegistrationEditor":
                        DfESignInPage.SigninAsRegistrationEditor();
                        break;
                    case "ResultsEditor":
                        DfESignInPage.SigninAsResultsEditor();
                        break;
                    case "PearsonSiteAdmin":
                        DfESignInPage.SigninAsPearsonSiteAdmin();
                        break;
                    case "NoRoleNoService":
                        DfESignInPage.SigninAsNoRoleNoServiceUser();
                        break;
                    case "NoServiceTole":
                        DfESignInPage.SigninAsNoServiceUser();
                        break;
                    case "ProviderBarnsleyPA":
                        DfESignInPage.SigninAsProviderBarnsleyPAUser();
                        break;
                    case "ProviderBarnsleyLRE":
                        DfESignInPage.SigninAsProviderBarnsleyLREUser();
                        break;
                    case "ProviderBarnsleyAll":
                        DfESignInPage.SigninAsProviderBarnsleyAllUser();
                        break;
                    case "ProviderCardinalPA":
                        DfESignInPage.SigninAsProviderCardinalPAUser();
                        break;
                    case "ProviderCardinalLRE":
                        DfESignInPage.SigninAsProviderCardinalLREUser();
                        break;
                    case "ProviderCardinalAll":
                        DfESignInPage.SigninAsProviderCardinalAllUser();
                        break;
                    case "ProviderDudleyPA":
                        DfESignInPage.SigninAsProviderDudleyPAUser();
                        break;
                    case "ProviderDudleyLRE":
                        DfESignInPage.SigninAsProviderDudleyLREUser();
                        break;
                    case "ProviderDudleyAll":
                        DfESignInPage.SigninAsProviderDudleyAllUser();
                        break;
                }
        }
        [When(@"I enter any AO user account to login")]
        public void WhenIEnterAnyAOUserAccountToLogin()
        {
            string AOAdminUser = WebDriverFactory.Config["AOAdminUser"];
            string AOAppPassword = WebDriverFactory.Config["AOPassword"];
            PageHelper.WaitForPageElementBy(10, DfESignInPage.UserIdTxtBox);
            WebDriver.FindElement(DfESignInPage.UserIdTxtBox).SendKeys(AOAdminUser);
            WebDriver.FindElement(DfESignInPage.PasswordTxtBox).SendKeys(AOAppPassword);
            PageHelper.WaitForPageElementBy(10, DfESignInPage.SignInButton);
            WebDriver.FindElement(DfESignInPage.SignInButton).Click();
        }

        [When(@"I enter any provider user account to login")]
        public void WhenIEnterAnyProviderUserAccountToLogin()
        {
            string ProUser = WebDriverFactory.Config["ProBarnsleyAll"];
            string ProPassword = WebDriverFactory.Config["ProUserPassword"];
            PageHelper.WaitForPageElementBy(10, DfESignInPage.UserIdTxtBox);
            WebDriver.FindElement(DfESignInPage.UserIdTxtBox).SendKeys(ProUser);
            WebDriver.FindElement(DfESignInPage.PasswordTxtBox).SendKeys(ProPassword);
            PageHelper.WaitForPageElementBy(10, DfESignInPage.SignInButton);
            WebDriver.FindElement(DfESignInPage.SignInButton).Click();
        }

        [Then(@"i should see Account, TLevels and Centre links")]
        public void ThenIShouldSeeAccountTLevelsAndCentreLinks()
        {
            UserDashboardPage.AdminDashboardPage();
        }
        
        [Then(@"I should see Account, Centre links")]
        public void ThenIShouldSeeAccountCentreLinks()
        {
            UserDashboardPage.ProviderDashboardPage();
        }

        [Then(@"i should see Account, TLevels links")]
        public void ThenIShouldSeeAccountTLevelslinks()
        {
            UserDashboardPage.ReviewerDashboardPage();
        }
    }
}
