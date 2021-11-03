using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Unit_Test_UI
{
    public class Tests_Newbookmodels
    {
        IWebDriver driver;
        Actions builder;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://newbookmodels.com/");
            Actions actions = new Actions(driver);
        }
        public IWebElement FindElement(string Selector, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(By.CssSelector(Selector)));
            }
            return driver.FindElement(By.CssSelector(Selector));
        }

        [Test]
        public void Registration()
        {
            IWebElement singUpButton = driver.FindElement(By.CssSelector("[class=\"Navbar__signUp--12ZDV\"]"));
            singUpButton.Click();
            string inputFirstName = "Amy";
            IWebElement firstNameSpace = driver.FindElement(By.CssSelector("[name=\"first_name\"]"));
            firstNameSpace.SendKeys(inputFirstName);
            string inputSecondtName = "Parker";
            IWebElement secondNameSpace = driver.FindElement(By.CssSelector("[name=\"last_name\"]"));
            secondNameSpace.SendKeys(inputSecondtName);
            IWebElement email = driver.FindElement(By.CssSelector("[name='email']"));
            DateTime dataTime = new DateTime();
            dataTime = DateTime.Now;
            string name = dataTime.ToString();
            name = name.Replace(".", "");
            name = name.Replace(" ", "");
            name = name.Replace(":", "");
            email.SendKeys("newMail" + name + "@test.com");
            string inputPassword = "12345Nm$";
            IWebElement passwordSpace = driver.FindElement(By.CssSelector("[name=\"password\"]"));
            passwordSpace.SendKeys(inputPassword);
            string confirmPassword = "12345Nm$";
            IWebElement confirmPasswordSpace = driver.FindElement(By.CssSelector("[name=\"password_confirm\"]"));
            confirmPasswordSpace.SendKeys(confirmPassword);
            string mobileNumber = "444.567.7893";
            IWebElement phoneNumperSpace = driver.FindElement(By.CssSelector("[name=\"phone_number\"]"));
            phoneNumperSpace.SendKeys(mobileNumber);
            IWebElement nextButton = driver.FindElement(By.CssSelector("[class=\"SignupForm__submitButton--1m1C2 " +
                "Button__button---rQSB Button__themePrimary--E5ESP Button__sizeMedium--uLCYD Button__fontSmall--1EPi5 " +
                "Button__withTranslate--1qGAH\"]"));
            nextButton.Click();
            string companyName = "Tionele";
            IWebElement companyNameSpace = driver.FindElement(By.CssSelector("[name=\"company_name\"]"));
            companyNameSpace.SendKeys(companyName);
            string companyWebsite = companyName +".com";
            IWebElement companyWebsiteSpace = driver.FindElement(By.CssSelector("[name=\"company_website\"]"));
            companyWebsiteSpace.SendKeys(companyWebsite);
            string companyLocation = "4417 Aylesford Street, Big Spring, TX, USA";
            IWebElement locationSpace = driver.FindElement(By.CssSelector("input[name=\"location\"]"));
            locationSpace.SendKeys(companyLocation);
            Thread.Sleep(1500);
            locationSpace.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            locationSpace.SendKeys(Keys.Enter);
            IWebElement buttonIndustry = driver.FindElement(By.CssSelector("[name=\"industry\"]"));
            buttonIndustry.Click();
            buttonIndustry.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            buttonIndustry.SendKeys(Keys.Enter);
            IWebElement buttonFinish = driver.FindElement(By.CssSelector("[class=\"SignupCompanyForm__submitButton--3mz3p " +
                "Button__button---rQSB Button__themePrimary--E5ESP Button__sizeMedium--uLCYD Button__fontSmall--1EPi5 " +
                "Button__withTranslate--1qGAH\"]"));
            buttonFinish.Click();
            Assert.Pass();
        }

        [Test]

        public void EditProfile()
        {
            IWebElement logInButton = driver.FindElement(By.CssSelector("[class *=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx " +
                "Navbar__login--28b35\"]"));
            logInButton.Click();
            IWebElement logInEmail = driver.FindElement(By.CssSelector("[type='email']"));
            logInEmail.SendKeys("marineriscr@gmail.com");
            IWebElement logInPassword = driver.FindElement(By.CssSelector("[name='password']"));
            logInPassword.SendKeys("14finans14Se*");
            IWebElement Finish = driver.FindElement(By.CssSelector("[type='submit']"));
            Finish.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]")));
            IWebElement avatarIcon = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
            avatarIcon.Click();
            IWebElement editAccountInfo1 = driver.FindElement(By.XPath("/html/body/nb-app/ng-component/nb-internal-layout/common-layout/" +
                "section/div/ng-component/nb-account-info-edit/common-border/div[1]/div/nb-account-info-general-information/form/div[1]" +
                "/div/nb-edit-switcher/div/div"));
            editAccountInfo1.Click();
            IWebElement editName = driver.FindElement(By.CssSelector("[class=\"input__self input__self_type_text-underline" +
                " ng-pristine ng-valid ng-touched\"]"));
            editName.SendKeys("ly");
            IWebElement editAccountInfo2 = driver.FindElement(By.XPath("/html/body/nb-app/ng-component/nb-internal-layout/common-" +
                "layout/section/div/ng-component/nb-account-info-edit/common-border/div[2]/div/nb-account-info-email-address/form/div[1]" +
                "/div/nb-edit-switcher/div/div"));
            editAccountInfo2.Click();
            IWebElement verifEmailPassword = driver.FindElement(By.CssSelector("class [type ='text']"));
            verifEmailPassword.SendKeys("1234%Gfk");
            IWebElement saveEdit = driver.FindElement(By.CssSelector("[type='submit']"));
            saveEdit.Click();
            IWebElement cardNumber = driver.FindElement(By.CssSelector("[name='company_website']"));
            cardNumber.SendKeys("5551046548903454");
            IWebElement expCartDate = driver.FindElement(By.CssSelector("[name='exp-date']"));
            expCartDate.SendKeys("0523");
            IWebElement cvc = driver.FindElement(By.CssSelector("[name='cvc']"));
            cvc.SendKeys("341");
            IWebElement saveCard = driver.FindElement(By.CssSelector("[type='submit']"));
            saveCard.Click();
            Assert.Pass();
        }

        [Test]
        public void AutorizationAndExit()
        {
            IWebElement logInButton = driver.FindElement(By.CssSelector("[class=\"Navbar__navLink--3lL7S Navbar__navLinkSingle--3x6Lx " +
                "Navbar__login--28b35\"]"));
            logInButton.Click();
            IWebElement logInEmail = driver.FindElement(By.CssSelector("[name=\"email\"]"));
            logInEmail.SendKeys("marineriscr@gmail.com");
            IWebElement logInPassword = driver.FindElement(By.CssSelector("[name=\"password\"]"));
            logInPassword.SendKeys("14finans14Se*");
            IWebElement autologInButton = driver.FindElement(By.CssSelector("[type=\"submit\"]"));
            autologInButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras
                .WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]")));
            IWebElement avatarIconForExit = driver.FindElement(By.CssSelector("[class=\"AvatarClient__avatar--3TC7_\"]"));
            avatarIconForExit.Click();
            IWebElement exit = driver.FindElement(By.CssSelector("[class=\"link link_type_logout link_active\"]"));
            exit.Click();
            Assert.Pass();
        }

        [TearDown]
        public void After()
        {
            //driver.Quit();
        }
    }
}
