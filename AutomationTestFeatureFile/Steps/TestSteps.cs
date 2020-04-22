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
            WebPageObject registerPage = new WebPageObject(driver);
            driver.Navigate().GoToUrl(registerPage.homePage);
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            WebPageObject registerPage = new WebPageObject(driver);

            registerPage.ClickOnSignInButton();
        }

        [When(@"Enter unregisterd email for every registration (.*)")]
        public void WhenEnterValidE_Mail(string email)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterTextInEmailField(email);
        }
        [When(@"I enter new valid email for every registration")]
        public void WhenIEnterNewValidEmailForEveryRegistration()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterNewEmailForRegistration();
        }



        [When(@"Click on Create account button")]
        public void WhenClickOnCreateAccountButton()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.ClickCreateAccountButton();
        }
        
        [When(@"I enter my First Name (.*)")]
        public void WhenIEnterMyFirstName(string firstName)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterFirstNameInFirstNameField(firstName);
        }
        
        [When(@"I enter my Last Name (.*)")]
        public void WhenIEnterMyLastName(string lastName)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterLastNameInLastNameField(lastName);
        }
        
        
        [When(@"I enter my password (.*)")]
        public void WhenIEnterMyPassword(string password)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterPasswordInPasswordField(password);
        }
        
        [When(@"I enter my address (.*)")]
        public void WhenIEnterMyAddress(string address)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterAddressInAddressField(address);
        }
        
        [When(@"I enter City (.*)")]
        public void WhenIEnterCity(string city)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterCityInCityField(city);
        }
        
        [When(@"I choose state from dropdown")]
        public void WhenIChooseStateFromDropdown()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.ChooseStateFromDropdown();
        }
        
        [When(@"I enter postal code (.*)")]
        public void WhenIEnterPostalCode(string postalCode)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterPostalCodeInPostalCodeField(postalCode);
        }
        
        [When(@"I enter my Mobile phone (.*)")]
        public void WhenIEnterMyMobilePhone(string mobilePhone)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterMobilePhoneInMobilePhoneField(mobilePhone);
        }
        
        [When(@"I enter the Assign an address alias for future reference (.*)")]
        public void WhenIEnterTheAssignAnAddressAliasForFutureReference(string aliasAddress)
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.EnterAliasAddressInAlliasAddressField(aliasAddress);
        }

        [When(@"I click on registerButton")]
        public void WhenIClickOnRegisterButton()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            registerPage.ClickRegisterButton();
        }


        [Then(@"Welcome message should be displayed in user profile page")]
        public void ThenMyAccountMessageShouldBeVisible()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            Assert.IsTrue(registerPage.IsSuccessful());
        }


        [Then(@"A error message should be displayed on top of the page about invalid input of the postal code")]
        public void ThenErrorAppears()
        {
            WebPageObject registerPage = new WebPageObject(driver);
            Assert.IsTrue(registerPage.InNotSuccessful());
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
