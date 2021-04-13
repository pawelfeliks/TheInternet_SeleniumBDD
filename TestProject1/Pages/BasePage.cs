﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ScrollToTheBottom()
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor) Driver;

            javaScriptExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
    }
}