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
    class Certification
    {
        //function for adding certification
        public void EnterCertification(IWebDriver driver)

        {
            Thread.Sleep(2000);
            //click the Certification Tab 
            driver.FindElement(By.PartialLinkText("Certifications")).Click();
            Console.WriteLine("cer Tab clicked");

            Thread.Sleep(2000);

            //Click Add New button 
            driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();


            //enter name of cer
            IWebElement Certificate_Name = driver.FindElement(By.Name("certificationName"));
            Certificate_Name.SendKeys("Quality Assurance");

            //enter name received from
            IWebElement Certificate_From = driver.FindElement(By.Name("certificationFrom"));
            Certificate_From.SendKeys("IBM");

            Thread.Sleep(2000);

            //Select certificate yr
            IWebElement chooseyear = driver.FindElement(By.Name("certificationYear"));
            var yearvalue = driver.FindElement(By.Name("certificationYear"));
            var year = new SelectElement(yearvalue);
            year.SelectByValue("2018");
            Thread.Sleep(2000);

            //Click Add
            driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(5) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.row div.five.wide.field:nth-child(3) > input.ui.teal.button:nth-child(1)")).Click();
            Thread.Sleep(2000);

            ////Click Add New button 
            //driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();


            ////enter name of cer
            //IWebElement CertificateNameTwo = driver.FindElement(By.Name("certificationName"));
            //CertificateNameTwo.SendKeys("Agile");

            //Thread.Sleep(2000);
            ////enter name received from
            //IWebElement CertificateFromTwo = driver.FindElement(By.Name("certificationFrom"));
            //CertificateFromTwo.SendKeys("UNITEC");

            //Thread.Sleep(2000);

            ////Select certificate yr
            //IWebElement chooseyearTwo = driver.FindElement(By.Name("certificationYear"));
            //var yearvalueTwo = driver.FindElement(By.Name("certificationYear"));
            //var yearTwo = new SelectElement(yearvalueTwo);
            //yearTwo.SelectByValue("2017");
            //Thread.Sleep(2000);

            ////Click Add for edu
            //driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();
            //Thread.Sleep(1000);

            //Verification
            Thread.Sleep(3000);
            String expResult3 = "Quality Assurance has been added to your certification";
            String actualResult3 = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            if (expResult3 == actualResult3)
            {
                Console.WriteLine("Test Pass: Quality Assurance certificate added");

                //screenshot
                Helpers.SaveScreenShotClass.SaveScreenshot(CommonDriver.Driver, "Certification");
            }

            else
            {
                Console.WriteLine("Test Fail: Quality Assurance certificate not added");
            }
        }
    }
}