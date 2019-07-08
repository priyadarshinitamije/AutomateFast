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
    class Education
    {
        //function for adding education

        public void EnterEducation(IWebDriver driver)

        {
            Thread.Sleep(5000);
            //Education Tab Clicked
            driver.FindElement(By.LinkText("Education")).Click();
            Console.WriteLine("edu Tab done");
            Thread.Sleep(2000);

            //Add Education
            driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(4) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(6) > div.ui.teal.button")).Click();

            //Add Education name
            IWebElement CollegeNameOne = driver.FindElement(By.Name("instituteName"));
            CollegeNameOne.SendKeys("AUT");

            //Choose college country
            IWebElement CollegeCountryOne = driver.FindElement(By.Name("country"));
            var countryOne = driver.FindElement(By.Name("country"));
            var country = new SelectElement(countryOne);
            country.SelectByValue("New Zealand");

            //Choose the title
            IWebElement TitleOne = driver.FindElement(By.Name("title"));
            var titleOne = driver.FindElement(By.Name("title"));
            var selecttitle = new SelectElement(titleOne);
            selecttitle.SelectByValue("B.Tech");

            Thread.Sleep(2000);

            //Add degree
            IWebElement degreeOne = driver.FindElement(By.Name("degree"));
            degreeOne.SendKeys("IT");

            Thread.Sleep(2000);

            //Choose year
            IWebElement yr = driver.FindElement(By.Name("yearOfGraduation"));
            var year1 = driver.FindElement(By.Name("yearOfGraduation"));
            var selectyear = new SelectElement(year1);
            selectyear.SelectByValue("2016");
            Thread.Sleep(3000);

            //Click Add in education
            driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(4) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.row div.fields:nth-child(3) div.sixteen.wide.field > input.ui.teal.button:nth-child(1)")).Click();

            ////Add Education
            //driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(4) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(6) > div.ui.teal.button")).Click();
            //Thread.Sleep(2000);
            ////Add Education name
            //IWebElement CollegeNameTwo = driver.FindElement(By.Name("instituteName"));
            //CollegeNameTwo.SendKeys("WELTEC");
            //Thread.Sleep(2000);

            ////Choose college country
            //IWebElement CollegeCountryTwo = driver.FindElement(By.Name("country"));
            //var countryTwo = driver.FindElement(By.Name("country"));
            //var countrySecond = new SelectElement(countryTwo);
            //countrySecond.SelectByValue("New Zealand");
            //Thread.Sleep(2000);

            ////Choose the title
            //IWebElement TitleTwo = driver.FindElement(By.Name("title"));
            //var titleTwo = driver.FindElement(By.Name("title"));
            //var selecttitleSecond = new SelectElement(titleTwo);
            //selecttitleSecond.SelectByValue("B.Tech");

            //Thread.Sleep(2000);

            ////Add degree
            //IWebElement degreeTwo = driver.FindElement(By.Name("degree"));
            //degreeTwo.SendKeys("Automation");

            //Thread.Sleep(2000);

            ////Choose year
            //IWebElement yrTwo = driver.FindElement(By.Name("yearOfGraduation"));
            //var year2 = driver.FindElement(By.Name("yearOfGraduation"));
            //var selectyearSecond = new SelectElement(year2);
            //selectyearSecond.SelectByValue("2017");
            //Thread.Sleep(2000);

            ////Click Add in education
            //driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();

            //Verification
            Thread.Sleep(4000);
            String expResult2 = "Education has been added";
            String actualResult2 = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            if (expResult2 == actualResult2)
            {
                Console.WriteLine("AUT education added");

                //screenshot
                Helpers.SaveScreenShotClass.SaveScreenshot(CommonDriver.Driver, "Education");
            }

            else
            {
                Console.WriteLine("AUT education not added");
            }

        }




        ////internal void EnterEducation(object driver)
        ////{
        ////    throw new NotImplementedException();
        ////}
    }
}