using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomateFast.Helpers;

namespace AutomateFast.Pages
{
    class Language
    {
        //function for adding language
        public void EnterLanguage(IWebDriver driver)
        {
            ////click Languages
            //IWebElement Languages = driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']"));
            //Languages.Click();
            Thread.Sleep(3000);
            //click add new 
            IWebElement AddNew = driver.FindElement(By.XPath("(//DIV[@class='ui teal button '][text()='Add New'][text()='Add New'])[1]"));
            AddNew.Click();

            Thread.Sleep(1000);
            //details in language box
            IWebElement AddLanguage = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            AddLanguage.SendKeys("Spanish");


            Thread.Sleep(2000);
            //details in level box
            IWebElement chooselanguageOne = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            var level1 = driver.FindElement(By.Name("level"));
            var select_level1 = new SelectElement(level1);
            select_level1.SelectByValue("Conversational");

            Thread.Sleep(500);
            //click add
            IWebElement Add = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            Add.Click();


            Thread.Sleep(500);
            //AddNew.Click();

            //Thread.Sleep(1000);
            ////details in language box
            //IWebElement LanguageTwo = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            //LanguageTwo.SendKeys("Tamil");


            //Thread.Sleep(2000);
            ////details in level box
            //IWebElement chooselanguageTwo = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            //var level2 = driver.FindElement(By.Name("level"));
            //var select_level2 = new SelectElement(level2);
            //select_level2.SelectByValue("Conversational");

            //Thread.Sleep(500);
            ////click add Two
            //IWebElement AddTwo = driver.FindElement(By.XPath("//input[@class='ui teal button']"));
            //AddTwo.Click();

            //Verification
            Thread.Sleep(4000);
            String expResult1 = "Spanish has been added to your languages";
            String actualResult1 = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")).Text;
            if (expResult1 == actualResult1)
            {
                Console.WriteLine("Spanish languag added");

                //screenshot
                Helpers.SaveScreenShotClass.SaveScreenshot(CommonDriver.Driver, "Language");
            }

            else
            {
                Console.WriteLine("Spanish languag not added");

            }
        }
    }
}