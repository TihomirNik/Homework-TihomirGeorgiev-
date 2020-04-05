using AutomationTestFeatureFile.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestFeatureFile
{
    [Binding]
    public class TestSteps : IDisposable
    {
        ChromeDriver driver = new ChromeDriver();


        [Given(@"I naovigate to Automationpractice website")]
        public void GivenINaovigateToAutomationpracticeWebsite()
        {
            WebPageObject webPage = new WebPageObject(driver);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(webPage.homePage);
        }
        
        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            WebPageObject webPage = new WebPageObject(driver);
            
            webPage.clickOnSignInButton();
        }

        [When(@"Enter valid e-mail (.*)")]
        public void WhenEnterValidE_Mail(string email)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterTextInEmailField(email);
        }


        [When(@"Click on Create account button")]
        public void WhenClickOnCreateAccountButton()
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.ClickCreateAccountButton();
        }
        
        [When(@"I enter my First Name (.*)")]
        public void WhenIEnterMyFirstName(string firstName)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.EnterFirstName(firstName);
        }
        
        [When(@"I enter my Last Name (.*)")]
        public void WhenIEnterMyLastName(string lastName)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.EnterLastName(lastName);
        }
        
        
        [When(@"I enter my password (.*)")]
        public void WhenIEnterMyPassword(string password)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterPassword(password);
        }
        
        [When(@"I enter my address (.*)")]
        public void WhenIEnterMyAddress(string address)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterAddress(address);
        }
        
        [When(@"I enter City (.*)")]
        public void WhenIEnterCity(string city)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterCity(city);
        }
        
        [When(@"I choose state from dropdown")]
        public void WhenIChooseStateFromDropdown()
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.chooseFromDropdown();
        }
        
        [When(@"I enter postal code (.*)")]
        public void WhenIEnterPostalCode(string postalCode)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterPostalCode(postalCode);
        }
        
        [When(@"I enter my Mobile phone (.*)")]
        public void WhenIEnterMyMobilePhone(string mobilePhone)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterMobilePhone(mobilePhone);
        }
        
        [When(@"I enter the Assign an address alias for future reference (.*)")]
        public void WhenIEnterTheAssignAnAddressAliasForFutureReference(string aliasAddress)
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.enterAliasAddress(aliasAddress);
        }

        [When(@"I click on registerButton")]
        public void WhenIClickOnRegisterButton()
        {
            WebPageObject webPage = new WebPageObject(driver);
            webPage.clickRegisterButton();
        }


        [Then(@"My account message should be visible")]
        public void ThenMyAccountMessageShouldBeVisible()
        {
            WebPageObject webPage = new WebPageObject(driver);
            Assert.IsTrue(webPage.isSuccessful());
        }


        [Then(@"Error appears")]
        public void ThenErrorAppears()
        {
            WebPageObject webPage = new WebPageObject(driver);
            Assert.IsTrue(webPage.inNotSuccessful());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
