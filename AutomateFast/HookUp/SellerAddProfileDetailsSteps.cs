using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using AutomateFast.Helpers;
using AutomateFast.Pages;
namespace AutomateFast
{
    [Binding]
    public class SellerAddProfileDetailsSteps
    {
        [Given(@"I have Logged Into Skillswap")]
        public void GivenIHaveLoggedIntoSkillswap()
        {
            CommonDriver.Driver = new ChromeDriver();

            //steps to login
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.Driver);
        }

        [Then(@"I should be able to add a language successfully")]
        public void ThenIShouldBeAbleToAddALanguageSuccessfully()
        {
            //steps for language
            Language languageObj = new Language();
            languageObj.EnterLanguage(CommonDriver.Driver);
        }

        [Then(@"Close browser")]
        public void ThenCloseBrowser()
        {
            //close driver
            CommonDriver.Driver.Close();
        }

        [Then(@"I should be able to add a certificate successfully")]
        public void ThenIShouldBeAbleToAddACertificateSuccessfully()
        {
            //steps for certification
            Certification certiObj = new Certification();
            certiObj.EnterCertification(CommonDriver.Driver);
        }

        [Then(@"I should be able to add  an education successfully")]
        public void ThenIShouldBeAbleToAddAnEducationSuccessfully()
        {
            //steps for education
            Education eduObj = new Education();
            eduObj.EnterEducation(CommonDriver.Driver);
        }
    }
}