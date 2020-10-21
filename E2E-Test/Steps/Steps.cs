using E2E_Test.Infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using TechTalk.SpecFlow;

namespace E2E_Test.Steps
{
    [Binding]
    public class Steps
    {
        [Given(@"I navigate to ""(.*)""")]
        public void NavigateTo(string url)
        {
            WebDriver.Current.Navigate().GoToUrl(url);
        }

        [When(@"I click the link ""(.*)""")]
        public void ClickTheLink(string linkText)
        {

            var selectElements = WebDriver.Current
                .FindElements(By.TagName("select"));

            var selectedLanguage = new SelectElement(selectElements.First())
                .SelectedOption.Text;

            if (selectedLanguage == "Русский")
            {
                linkText = "Детали";
            }   

            WebDriver.Current
                    .FindElements(By.TagName("a"))
                    .First(element => element.Text == linkText)
                    .Click();
        }

        [Then(@"the button ""(.*)"" is visible")]
        public void TheButtonIsVisible(string text)
        {
            var selectElements = WebDriver.Current
                .FindElements(By.TagName("select"));

            var selectedLanguage = new SelectElement(selectElements.First())
                .SelectedOption.Text;

            if (selectedLanguage == "Русский")
            {
                text = "Изменить";
            }

            Assert.That(WebDriver.Current.PageSource.Contains(text), Is.True);
        }
    }
}
