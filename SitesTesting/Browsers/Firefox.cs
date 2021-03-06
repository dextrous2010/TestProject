﻿using OpenQA.Selenium.Firefox;

namespace SitesTesting.Browsers
{
    public class Firefox : Browser
    {
        public Firefox() : base(new FirefoxDriver())
        {
        }

        public Firefox(bool maximizeWindow = false) : base(new FirefoxDriver(), maximizeWindow)
        {
        }
    }
}