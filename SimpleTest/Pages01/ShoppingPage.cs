using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Pages01
{
    public class ShoppingPage :BasePage
    {
        

        [FindsBy(How = How.Id, Using = "menu-item-33")]
        public IWebElement ProductCategory;

        [FindsBy(How = How.CssSelector, Using = "li.menu-item-36 a")]
        private IWebElement iPadCategory;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_93")]
        private IWebElement iPadProduct;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_40 div.input-button-buy input")]
        private IWebElement iPadAddToCart;        

        [FindsBy(How = How.CssSelector, Using = "td.wpsc_product_name")]
        private IWebElement ProductNameCart;

        [FindsBy(How = How.CssSelector, Using = "a.step2")]
        private IWebElement ContinueBtn;      

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

        [FindsBy(How = How.CssSelector, Using = "h1.entry-title")]
        private IWebElement FinalPage;
    
        [FindsBy(How = How.CssSelector, Using = "div#header_cart a")]
       private IWebElement Cart;

        [FindsBy(How = How.CssSelector, Using = "td.wpsc_product_remove input[name='submit']")]
        private IWebElement RemoveBtn;

        String defaultText="test";
        String email = "burcevakate@gmail.com";
        private IWebDriver driver;

        public ShoppingPage(IWebDriver driver) : base(driver)
        {
        }
        
        public void SelectIpadProduct()
        {
           iPadCategory.Click();
         
        }
     

        public void ClcikAddtoCart()
        {
            iPadAddToCart.Click();
            Thread.Sleep(5000);

        }

        public void ClickContinueButton()
        {
            ContinueBtn.Click();
            Thread.Sleep(5000);
        }

        public void ClickPurchase()
        {
            PurchaseBtn.Click();
        }

        public void ClickGoToCart()
        {
            
            Cart.Click();
        }
        public bool IsCartDisplayed()
       {
            Boolean isDisplayed = Cart.Displayed;
           return isDisplayed;
        }

        public void FillFormWithData()
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

        public bool IsElementDisplayedCart()
        {
            Boolean isDisplayed = ProductNameCart.Displayed;
            return isDisplayed;
          
        }
        public bool IsFinalPageDisplayed()
        {
            Boolean isDisplayed = FinalPage.Displayed;
            return isDisplayed;
            ;

        }

        public void Remove()
        {
            RemoveBtn.Click();
        }

        
    }
             

    }

