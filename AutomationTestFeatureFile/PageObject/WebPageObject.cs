using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
        public void ClickOnSignInButton()
        {
            driver.FindElement(signInButton).Click();
        }

        public string GenerateRandomEmail()
        {
            string mailEnding = "@abv.bg";
            Random random = new Random();
            int mailNumber = random.Next(1000);
            return mailNumber+mailEnding;
        }

        public void EnterNewEmailForRegistration()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(emailField));
            driver.FindElement(emailField).Clear();
            driver.FindElement(emailField).SendKeys(GenerateRandomEmail());
        }

        public void EnterTextInEmailField(string email)
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

        public void EnterFirstNameInFirstNameField(string firstName)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(firstNameField));
            driver.FindElement(firstNameField).Clear();
            driver.FindElement(firstNameField).SendKeys(firstName);

        }
        public void EnterLastNameInLastNameField(string lastName)
        {
            driver.FindElement(lastNameField).Clear();
            driver.FindElement(lastNameField).SendKeys(lastName);

        }

        public  void EnterPasswordInPasswordField(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void EnterAddressInAddressField(string address)
        {
            driver.FindElement(addressField).SendKeys(address);
        }

        public void EnterCityInCityField(string city)
        {
            driver.FindElement(cityField).SendKeys(city);
        }

        public void EnterPostalCodeInPostalCodeField(string postalCode)
        {
            driver.FindElement(postalField).SendKeys(postalCode);
        }

        public void EnterMobilePhoneInMobilePhoneField(string mobilephone)
        {
            driver.FindElement(mobilePhoneField).SendKeys(mobilephone);
        }

        public void EnterAliasAddressInAlliasAddressField(string aliasAddress)
        {
            driver.FindElement(aliesAddressField).SendKeys(aliasAddress);
        }

        public void ChooseStateFromDropdown()
        {
            SelectElement stateFromDropDown = new SelectElement(driver.FindElement(stateDropdown));
            stateFromDropDown.SelectByText(state);
        }

        public void ClickRegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public bool IsSuccessful()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(welcomeMessage));
            return driver.FindElement(welcomeMessage).Displayed;
        }

        public bool InNotSuccessful()
        {
            return driver.FindElement(errorMessage).Displayed;
        }

    }
}
