using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateFast.Pages
{
    class LoginPage
    {
        //steps to login to skillswap page
        public void LoginSteps(IWebDriver driver)
        {
            ////launch chrome web browser
            //IWebDriver driver = new ChromeDriver();

            //enter the URL
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");

            //maximise the window
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);

            //click the sign in button
            IWebElement SigninButton = driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
            SigninButton.Click();

            //enter email address
            IWebElement EmailAddress = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
            EmailAddress.SendKeys("priyamishti290@gmail.com");

            //enter password
            IWebElement Password = driver.FindElement(By.XPath("//INPUT[@type='password']"));
            Password.SendKeys("123456");
            Thread.Sleep(1000);

            //click login 
            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
            LoginButton.Click();

            //verify if the user is logged in successfully
        }
    }
}