using Amazon.DynamoDBv2;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestFeatureFile.PageObject
{
    class WebPageObject
    {
        public string homePage = "http://automationpractice.com/index.php";
        private string state = "Florida";

        IWebDriver driver;

        readonly By signInButton = By.CssSelector(".login");
        readonly By emailField = By.CssSelector("#email_create");
        readonly By createAccountButton = By.CssSelector("#SubmitCreate");
        readonly By firstNameField = By.CssSelector("#customer_firstname");
        readonly By lastNameField = By.CssSelector("#customer_lastname");
        readonly By passwordField = By.CssSelector("#passwd");
        readonly By addressField = By.CssSelector("#address1");
        readonly By cityField = By.CssSelector("#city");
        readonly By postalField = By.CssSelector("#postcode");
        readonly By mobilePhoneField = By.CssSelector("#phone_mobile");
        readonly By aliesAddressField = By.CssSelector("#alias");
        readonly By stateDropdown = By.CssSelector("#id_state");
        readonly By registerButton = By.CssSelector("#submitAccount");
        readonly By welcomeMessage = By.CssSelector(".page-heading");
        readonly By errorMessage = By.CssSelector(".alert-danger");
        

        public WebPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void clickOnSignInButton()
        {
            driver.FindElement(signInButton).Click();
        }

        public void enterTextInEmailField(string email)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(emailField));
            driver.FindElement(emailField).Clear();
            driver.FindElement(emailField).SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            driver.FindElement(createAccountButton).Click();
        }

        public void EnterFirstName(string firstName)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(firstNameField));
            driver.FindElement(firstNameField).Clear();
            driver.FindElement(firstNameField).SendKeys(firstName);

        }
        public void EnterLastName(string lastName)
        {
            driver.FindElement(lastNameField).Clear();
            driver.FindElement(lastNameField).SendKeys(lastName);

        }

        public  void enterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void enterAddress(string address)
        {
            driver.FindElement(addressField).SendKeys(address);
        }

        public void enterCity(string city)
        {
            driver.FindElement(cityField).SendKeys(city);
        }

        public void enterPostalCode(string postalCode)
        {
            driver.FindElement(postalField).SendKeys(postalCode);
        }

        public void enterMobilePhone(string mobilephone)
        {
            driver.FindElement(mobilePhoneField).SendKeys(mobilephone);
        }

        public void enterAliasAddress(string aliasAddress)
        {
            driver.FindElement(aliesAddressField).SendKeys(aliasAddress);
        }

        public void chooseFromDropdown()
        {
            SelectElement stateFromDropDown = new SelectElement(driver.FindElement(stateDropdown));
            stateFromDropDown.SelectByText(state);
        }

        public void clickRegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public bool isSuccessful()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(welcomeMessage));
            return driver.FindElement(welcomeMessage).Displayed;
        }

        public bool inNotSuccessful()
        {
            return driver.FindElement(errorMessage).Displayed;
        }

    }
}
