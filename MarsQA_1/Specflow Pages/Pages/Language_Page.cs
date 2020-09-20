﻿using MarsQA_1.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Pages
{
    class Language_Page
    {
        
        
        public void tab(IWebDriver driver)
        {

            //Enter Language
            Thread.Sleep(2000);
            IWebElement Language = driver.FindElement(By.Name("name"));
            Language.SendKeys("Hindi");
        }

        public void Addnew(IWebDriver driver)
        { 
            //Select dropdown
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='Fluent']")).Click();

            

        }

        public void Language_Validation(IWebDriver driver)
        {
            //Add Language
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }

        

        //public void EditLangauge(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

        //    //language.Click();
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();

        //    //language clear;
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();

        //    //language new value add
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("British");


        //    //Select dropdown
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select")).Click();
        //    driver.FindElement(By.XPath("//option[text()='Conversational']")).Click();

        //    //click on the update button
        //    driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        //}

        //public void DeleteLangauge(IWebDriver driver)
        //{

        //    //Delete the Record
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='British']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
        //    driver.FindElement(By.XPath("//td[text()='British']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();

            

        //}





    }
}
