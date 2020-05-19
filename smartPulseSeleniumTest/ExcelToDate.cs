using System;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace smartPulseSeleniumTest
{
    [TestClass]
    public class ExcelToDate
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                driver.Manage().Window.Maximize();
                driver.Url = allElement.url;
                VerifyUrl(driver, allElement.url);
                popupIsActive();
                IWebElement waitUretimMenu = ExpliciWait(driver, allElement.uretimMenu);
                driver.FindElement(By.Id(allElement.uretimMenu)).Click();
                driver.FindElement(By.Id(allElement.planlamaMenu)).Click();
                driver.FindElement(By.XPath(allElement.kgupXpath)).Click();
                IWebElement waitKgup = ExpliciWait(driver, allElement.uygulabutton);

                //Günü Datapicker dan seçiyorum.
                driver.FindElement(By.XPath(allElement.baslangicTarih)).Click();
                driver.FindElement(By.ClassName(allElement.AySec)).Click();
                driver.FindElement(By.XPath(allElement.Mart)).Click();
                driver.FindElement(By.XPath(allElement.SecilecekGun)).Click();
                ElementisClickable(driver, allElement.bitisTarih);

                //Günü Datapicker dan seçiyorum.
                driver.FindElement(By.XPath(allElement.bitisTarih)).Click();
                driver.FindElement(By.ClassName(allElement.AySec)).Click();
                driver.FindElement(By.XPath(allElement.Mart)).Click();
                driver.FindElement(By.XPath(allElement.SecilecekGun)).Click();
                IWebElement waitUygulaButton = ExpliciWait(driver, allElement.uygulabutton);
                driver.FindElement(By.Id(allElement.uygulabutton)).Click();
                IWebElement excelWaitImg = ExpliciWait(driver, allElement.excelImageid);
                driver.FindElement(By.Id(allElement.excelImageid)).Click();
                Thread.Sleep(10000);
                 driver.Quit();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                throw;
            }
        }
        public static IWebElement ExpliciWait(IWebDriver driver, string Identifer)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementIsVisible(By.Id(Identifer)));
        }
        public void VerifyUrl(IWebDriver driver,string url)
        {
            if (driver.Url==url.ToString())
            {
                Console.WriteLine("Url Doğrulandı !");
            }
            else
            {
                driver.Url = allElement.url;
                Console.WriteLine("Erişilmedi fakat tekrar açıldı !");
            }
        }   
        public void popupIsActive()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(allElement.popupkapat))).Click();
                Console.WriteLine("Popup Kapatıldı.");

            }
            catch (Exception)
            {

                Console.WriteLine("Popup Gözükmüyor");
            }
        }
        public void ElementisClickable(IWebDriver driver,string Identifer)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(Identifer))).Click();
                Console.WriteLine("Bu " + Identifer + " Element tıklanabilir.");
            }
            catch (Exception e)
            {

                Console.WriteLine("Not Clikable " + e.ToString());
            }
        }
      
    }
}
