using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Pages01
{
    public class ShoppingPage :BasePage
    {
        [FindsBy(How = How.Id, Using = "main-nav")]
        private IWebElement Menu;

        [FindsBy(How = How.Id, Using = "menu-item-33")]
        private IWebElement ProductCategory;

        [FindsBy(How = How.CssSelector, Using = "li.menu-item-36 a")]
        private IWebElement iPadCategory;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_93")]
        private IWebElement iPadProduct;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_93 div.input-button-buy input")]
        private IWebElement iPadAddToCart;

        [FindsBy(How = How.Id, Using = "header_cart")]
        private IWebElement HeaderCart;

        [FindsBy(How = How.CssSelector, Using = "td.wpsc_product_name")]
        private IWebElement ProductNameCart;

        [FindsBy(How = How.CssSelector, Using = "a.step2")]
        private IWebElement ContinueBtn;

        [FindsBy(How = How.Id, Using = "wpsc_shopping_cart_container")]
        private IWebElement Step3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_9")]
        private IWebElement EmailStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_2")]
        private IWebElement FirstNameStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_3")]
        private IWebElement LastNameStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_4")]
        private IWebElement AddressStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_5")]
        private IWebElement CityStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_6")]
        private IWebElement StateStep3;

        [FindsBy(How = How.CssSelector, Using = "select#wpsc_checkout_form_7  option:nth-last-of-type(16)")]
        private IWebElement CountryStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_8")]
        private IWebElement PostalCodeStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_18")]
        private IWebElement PhoneStep3;

        [FindsBy(How = How.CssSelector, Using = "input.make_purchase")]
        private IWebElement PurchaseBtn;

        [FindsBy(How = How.CssSelector, Using = "div.wpsc-transaction-results-wrap")]
        private IWebElement FinalPage;
        
        String defaultText="test";
        String email = "burcevakate@gmail.com";
        private IWebDriver driver;

        public ShoppingPage(IWebDriver driver) : base(driver)
        {
        }

        public void SelectIpadProduct()
        {
            ProductCategory.Click();
            iPadCategory.Click();
        }
        //  public event EventHandler MouseEventArgs;

        public void clcikAddtoCart()
        {
            iPadAddToCart.Click();

        }

        public void clickPurchase()
        {
            PurchaseBtn.Click();
        }

        public void clickContinueBtn()
        {
            ContinueBtn.Click();
        }

        public void fillFormWithData()
        {
            EmailStep3.SendKeys(email);
            FirstNameStep3.SendKeys(defaultText);
            LastNameStep3.SendKeys(defaultText);
            AddressStep3.SendKeys(defaultText);
            CityStep3.SendKeys(defaultText);
            StateStep3.SendKeys(defaultText);
            CountryStep3.Click();
            PostalCodeStep3.SendKeys(defaultText);
            PhoneStep3.SendKeys(defaultText);

        }
        public bool isStep2PageOpened(IWebElement HeaderCart)
        {
            return HeaderCart.Displayed;
        }

        public bool isElementDisplayedCart(IWebElement ProductNameCart)
        {
            return ProductNameCart.Displayed;
        }

        public bool isStep3PageOpened(IWebElement Step3)
        {
            return Step3.Displayed;
        }
    }
             

    }

