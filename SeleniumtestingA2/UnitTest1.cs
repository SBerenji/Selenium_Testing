namespace SeleniumtestingA2
{
    // Creating references for Selenium to work with Visual Studio and MSTest
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System.Data;
    using System.Threading;
    using System;


    [TestClass]
    public class UnitTest1
    {
        // Creating a Selenium webdriver object
        IWebDriver driver;


        // The folowing 12 test methods will show the working for each option selected in the province menu. Each test method 
        // will have different inputs and will verify whether the user is directed to the next page for
        // confirming their registration upon entering valid data or not


        //                                               ****** Test Method 1 ******

        [TestMethod]
        public void Ontario_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **
            
            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName")); 
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("4 King street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Waterloo");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Ontario");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);  

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 2 ******

        [TestMethod]
        public void Newfoundland_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Harry");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Perling");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("140 Queen street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("St. John's");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Newfoundland");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N8H 3K7");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("333-356-4864");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("harry@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("2");

            Thread.Sleep(2000);

            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 3 ******

        [TestMethod]
        public void PrinceEdwardIsland_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Sara");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Hanks");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("50 Great George Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Charlottetown");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);


            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Prince Edward Island");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));

            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("M9N 4L3");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("573-986-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("sarah@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 4 ******

        [TestMethod]
        public void NovaScotia_ResultRegisterSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Steve");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Brown");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("12 Barington Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Halifax");

            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Nova Scotia");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("B8F 9K7");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("833-111-1234");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("browns@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }





        //                                               ****** Test Method 5 ******

        // In this method the phone pattern tested is (111)111-1111, unlike the tests above.
        // Even though this is a valid phone pattern based on the requirements, the test fails.

        [TestMethod]
        public void NewBrunswick_ResultRegisterationFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Evander");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Sterlink");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("1 Queen Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Fredericton");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("New Brunswick");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)            field5.SendKeys("B8F 9K7");
            field5.SendKeys("J4G 3K7");


            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of (111)111-1111
            field6.SendKeys("(234)111-5522");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("ster@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 6 ******

        //  In addition to testing the 'Quebec' option from the drop down menu, this test also tests for
        //  the alphabetical order requirement of the dropdown menu options

        [TestMethod]
        public void Quebec_ResultRegisterationFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Seraphina");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Duvall");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("45 Sainte-Catherine Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Montreal");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" 
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Quebec");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);


            // Testing to see if the Province options are in alphabetical order and contain all the required options or not
            
            // Storing the text of actual options in an array
            var optionElements = dropDown_province.Options;
            string[] actualArray = optionElements.Select(option => option.Text).ToArray();


            // Creating an array of expected options
            string[] expectedArray = new string[]
            {
                "Alberta", "British Columbia", "Manitoba", "New Brunswick",
                "Newfoundland", "NorthWest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", 
                "Quebec", "Saskatchewan", "Yukon Territory"
            };


            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("J8H 1J7");


            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("111-234-5248");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("duvall21@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Comparing the two arrays to see if the province dropdown contains the correct options
            // and if the options are in the right order or not
            CollectionAssert.AreEqual(expectedArray, actualArray);


            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }





        //                                               ****** Test Method 7 ******


        [TestMethod]
        public void Saskatchewan_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Melan");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Serila");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("88 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Saskatchewan");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N4N 6R8");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("344-123-5030");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("melan01@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }






        //                                               ****** Test Method 8 ******


        [TestMethod]
        public void Alberta_ResultRegisterationFail()    // this test will fail because of the wrong spelling of 'Alberta' in the website
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Jaxon");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Hawthorne");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("44 Stephen Avenue Walk, Tower 2");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Calgary");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Alberta");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)            field5.SendKeys("M5F 7N8");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("976-444-2456");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("jaxon01@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }





        //                                               ****** Test Method 9 ******


        [TestMethod]
        public void BritishColumbia_ResultRegisterationFail()   // This test will fail because of the wrong order of the name 'British Columbia'
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Elowen");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Grayson");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("44 Robsn Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Vancouver");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("British Columbia");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("B3G 3G7");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("111-070-0664");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("graysonj@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 10 ******


        [TestMethod]
        public void YukonTerritory_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Liora");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Ravenscroft");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("12 Main Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Whitehorse");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Yukon Territory");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("M3M 4J4");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("145-256-7323");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("liora@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 11 ******


        [TestMethod]
        public void NorthWestTerritories_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Vaeloria");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Nightshade");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("11 Franklin Avenue");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Yellowknife");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("NorthWest Territories");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));

            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("G3H 2J5");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("555-364-3578");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("shadevaeloria@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }





        //                                               ****** Test Method 12 ******


        [TestMethod]
        public void Nunavut_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Quinlan");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Rivers");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("13 Syllabics Road");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Iqaluit ");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);
            // Select the element identified by the id "province" and select an option by its displayed text from the dropdown menu
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByText("Nunavut");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("J3F 3J7");


            Thread.Sleep(2000);
            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("352-677-2357");
            Thread.Sleep(2000);


            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("revirsq@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        // The folowing 6 test methods test the 'How many pariticipants?' section of the form.


        //                                               ****** Test Method 13 ******

        [TestMethod]
        public void OneParticipant_ON_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("4 King street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Waterloo");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("ON");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }


        //                                               ****** Test Method 14 ******

        [TestMethod]
        public void TwoParticipants_BC_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("4 Regina street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Vancouver");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("BC");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("2");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 15 ******

        [TestMethod]
        public void ThreeParticipants_ON_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("485 Stephen Avenue Walk, Tower 2");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Kitchener");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("ON");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 16 ******

        [TestMethod]
        public void FourParticipants_QC_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("485 Stephen Avenue Walk, Tower 2");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Montreal");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("QC");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("sababerenji01@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("4");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";

            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 17 ******

        [TestMethod]
        public void FiveParticipants_SK_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("5");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }



        //                                               ****** Test Method 18 ******

        [TestMethod]
        public void SixParticipants_SK_ResultRegisterationSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");

            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("6");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);


            String expectedURL = "https://localhost/register/viewRegistration.html";


            //   ** Act ** 

            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();


            //   ** Assert **

    
            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the next page or not 
            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }


        // The following 3 test methods will verify whether registrants attending day 1 will be charged $450 or not.


        //                                               ****** Test Method 19 ******

        [TestMethod]
        public void OneParticipant_Day1_Price450_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            string expectedPrice = "$450";

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");

            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();

        }


        //                                               ****** Test Method 20 ******

        [TestMethod]
        public void TwoParticipants_Day1_Price900_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("2");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            int num = 2 * 450;
            string expectedPrice = "$" + num.ToString();

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");

            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 21 ******

        [TestMethod]
        public void ThreeParticipants_Day1_Price1350_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));

            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            int num = 3 * 450;
            string expectedPrice = "$" + num.ToString();

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");



            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();

        }







        // The following 3 test methods will verify whether registrants attending day 2 will be charged $350 or not.


        //                                               ****** Test Method 22 ******

        [TestMethod]
        public void OneParticipant_Day2_Price350_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            string expectedPrice = "$350";

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();
        }





        //                                               ****** Test Method 23 ******

        [TestMethod]
        public void TwoParticipants_Day2_Price700_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");


            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("2");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            int num = 2 * 350;
            string expectedPrice = "$" + num.ToString();

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");



            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();

        }




        //                                               ****** Test Method 24 ******

        [TestMethod]
        public void ThreeParticipants_Day2_Price1050_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            int num = 3 * 350;
            string expectedPrice = "$" + num.ToString();

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");



            Assert.AreEqual(expectedPrice, actualPrice);

            // Close the driver
            driver.Close();

        }




        // The following 3 test methods will verify whether registrants attending both days will be charged $750 or not.


        //                                               ****** Test Method 25 ******

        [TestMethod]
        public void OneParticipant_BothDays_Price750_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);

            string expectedPrice = "$750";


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }






        //                                               ****** Test Method 26 ******

        [TestMethod]
        public void TwoParticipants_BothDays_Price1500_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("2");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);


            int num = 2 * 750;
            string expectedPrice = "$" + num.ToString();


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }





        //                                               ****** Test Method 27 ******

        [TestMethod]
        public void ThreeParticipants_BothDays_Price2250_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);


            int num = 3 * 750;
            string expectedPrice = "$" + num.ToString();


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }







        // The following 3 test methods will verify whether more than 5 registrants will get 10% discount or not



        //                                               ****** Test Method 28 ******

        [TestMethod]
        public void SixParticipants_Day1_Price2430_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("6");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);

            // Calculating the fee considering the 10% discount
            int initialPrice = 6 * 450;
            float discount = initialPrice * 0.1f;
            float finalPrice = initialPrice - discount;
            string expectedPrice = "$" + finalPrice.ToString();


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }


        //                                               ****** Test Method 29 ******

        [TestMethod]
        public void SixParticipants_Day2_Price1890_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");


            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("6");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            // Calculating the fee considering the 10% discount
            int initialPrice = 6 * 350;
            float discount = initialPrice * 0.1f;
            float finalPrice = initialPrice - discount;
            string expectedPrice = "$" + finalPrice.ToString();


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }



        //                                               ****** Test Method 30 ******

        [TestMethod]
        public void SevenParticipants_BothDays_Price4725_ResultFail()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            // Selecting a drop down menu option takes more time so this pause is needed for selenium to successfully do the selection
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("7");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the value given from it
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("both");
            Thread.Sleep(2000);

            // Calculating the fee considering the 10% discount
            int initialPrice = 7 * 750;
            float discount = initialPrice * 0.1f;
            float finalPrice = initialPrice - discount;
            string expectedPrice = "$" + finalPrice.ToString();


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);


            //   ** Assert **

            //getting the actual fee on the confirmation page
            IWebElement price = driver.FindElement(By.Id("price"));
            string actualPrice = price.GetAttribute("value");


            //Using the AreEqual method to compare the expected fee with the actual fee on the confirmation page
            Assert.AreEqual(expectedPrice, actualPrice);


            // Close the driver
            driver.Close();
        }





        // The following three test methods test to verify whether the three links for "THE Event!", "Home",
        // and "Link to Conestogac College" exist on top of the view registration page and are working or not




        //                                               ****** Test Method 31 ******

        [TestMethod]
        public void THEEventLink_RedirectionSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("100 Regina Street North");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Waterloo");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("ON");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("sberenji4567@conetogac.on.ca");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("1");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the option with the given value
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);

            // Find an element identified by the LinkText attribute equal to "THE Event!" and click on it
            IWebElement eventLink = driver.FindElement(By.LinkText("THE Event!"));
            eventLink.Click();

            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/index.html";

            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the THEEvent page (register page) or not 

            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();


        }



        //                                               ****** Test Method 32 ******

        [TestMethod]
        public void HomeLink_RedirectionSuccessfull()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("100 Regina Street North");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Waterloo");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("ON");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("sberenji4567@conetogac.on.ca");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("3");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the option with the given value
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day1");
            Thread.Sleep(2000);


            //   ** Act ** 


            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);

            // Find an element identified by the LinkText attribute equal to "Home                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  " and click on it
            IWebElement eventLink = driver.FindElement(By.LinkText("Home"));
            eventLink.Click();


            Thread.Sleep(2000);

            String expectedURL = "https://localhost/register/index.html";

            //   ** Assert **

            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the home page (register) or not 

            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();

        }


        //                                               ****** Test Method 33 ******

        [TestMethod]
        public void ConestogaLink_RedirectionFailed()
        {

            // The following three lines of code are to eliminate the SSL issues so Selenium can open the URLs
            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            string url = "https://localhost/register/index.html";
            driver.Navigate().GoToUrl(url);  // opening the url/webpage passed for testing


            //   ** Arrange **

            // Find the element identified by the name attribute "firstName", and pass the string/input to it
            IWebElement field1 = driver.FindElement(By.Name("firstName"));
            field1.SendKeys("Saba");

            // Find the element identified by the name attribute "lastName", and pass the string/input to it
            IWebElement field2 = driver.FindElement(By.Name("lastName"));
            field2.SendKeys("Berenji");

            // Find the element identified by the name attribute "address", and pass the string/input to it
            IWebElement field3 = driver.FindElement(By.Name("address"));
            field3.SendKeys("34 Albert Street");

            // Find the element identified by the name attribute "city", and pass the string/input to it
            IWebElement field4 = driver.FindElement(By.Name("city"));
            field4.SendKeys("Saskatoon");

            // Pause the program for 2000 ms
            Thread.Sleep(2000);

            // Select the element identified by the id "province" and select the value given from it
            SelectElement dropDown_province = new SelectElement(driver.FindElement(By.Id("province")));
            dropDown_province.SelectByValue("SK");
            Thread.Sleep(2000);

            // Find the element identified by the name attribute "postalCode", and pass the string/input to it
            IWebElement field5 = driver.FindElement(By.Name("postalCode"));
            // passing a postal code in the form of A1A 1A1 (where A represents an alpha character A - Z and 1 represents a digit from 0 - 9)
            field5.SendKeys("N2F 3J6");

            // Find the element identified by the name attribute "phone", and pass the string/input to it
            IWebElement field6 = driver.FindElement(By.Name("phone"));
            // Passing a phone number in the form of 111-111-1111
            field6.SendKeys("123-444-5678");

            // Find the element identified by the name attribute "email", and pass the string/input to it
            IWebElement field7 = driver.FindElement(By.Name("email"));
            field7.SendKeys("berenjisaba@gmail.com");

            // Find the element identified by the name attribute "numberOfParticipants", and pass the string/input to it
            IWebElement field8 = driver.FindElement(By.Name("numberOfParticipants"));
            field8.SendKeys("4");


            Thread.Sleep(2000);
            // Select the element identified by the id "daysRegistered" and select the option with the given value
            SelectElement dropDown_days = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dropDown_days.SelectByValue("day2");
            Thread.Sleep(2000);

            //   ** Act ** 

            Thread.Sleep(2000);
            // Find the element (button) identified by the id "btnSubmit" and click on it
            IWebElement cbutton = driver.FindElement(By.Id("btnSubmit"));
            cbutton.Click();
            Thread.Sleep(2000);

            // Find the element identified by the link text attribute "Link to Conestoga College" and click on it
            IWebElement eventLink = driver.FindElement(By.LinkText("Link to Conestoga College"));
            eventLink.Click();


            Thread.Sleep(2000);


            // The link to the main page of Conestoga College
            String expectedURL = "https://www.conestogac.on.ca/";

            //   ** Assert **


            // Using the AreEqual method to compare the expected URL with the current URL of the webpage
            // in order to verify if the user was directed to the main page of Conestoga College or not 

            Assert.AreEqual(expectedURL, driver.Url);

            // Close the driver
            driver.Close();


        }



    }
}



