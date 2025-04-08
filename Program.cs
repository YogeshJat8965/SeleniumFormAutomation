using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    static void Main()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--window-size=1920,1080");

        IWebDriver driver = new ChromeDriver(options);

        try
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("fname")));

            try
            {
                IWebElement firstNameField = driver.FindElement(By.Id("fname"));
                firstNameField.Clear();
                firstNameField.SendKeys("Yogesh");
                Console.WriteLine("First Name field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("First Name field test failed: " + e.Message);
            }

            try
            {
                IWebElement lastNameField = driver.FindElement(By.Id("lname"));
                lastNameField.Clear();
                lastNameField.SendKeys("Jat");
                Console.WriteLine("Last Name field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Last Name field test failed: " + e.Message);
            }

            try
            {
                IWebElement maleRadioButton = driver.FindElement(By.Id("male"));
                if (!maleRadioButton.Selected)
                {
                    maleRadioButton.Click();
                }
                Console.WriteLine("Gender field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Gender field test failed: " + e.Message);
            }

            try
            {
                IWebElement dobField = driver.FindElement(By.Id("dob"));
                dobField.Clear();
                dobField.SendKeys("2002-12-20");
                Console.WriteLine("Date of Birth field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Date of Birth field test failed: " + e.Message);
            }

            try
            {
                IWebElement mobileField = driver.FindElement(By.Id("mobile"));
                mobileField.Clear();
                mobileField.SendKeys("8965900973");
                Console.WriteLine("Mobile Number field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Mobile Number field test failed: " + e.Message);
            }

            try
            {
                IWebElement emailField = driver.FindElement(By.Id("email"));
                emailField.Clear();
                emailField.SendKeys("yogeshjat8965@gmail.com");
                Console.WriteLine("Email field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Email field test failed: " + e.Message);
            }

            try
            {
                IWebElement countryField = driver.FindElement(By.Id("country"));
                countryField.Clear();
                countryField.SendKeys("India");
                Console.WriteLine("Country field test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Country field test failed: " + e.Message);
            }

            try
            {
                SelectElement stateDropdown = new SelectElement(driver.FindElement(By.Id("state")));
                stateDropdown.SelectByText("Madhya Pradesh");
                Console.WriteLine("State dropdown test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("State dropdown test failed: " + e.Message);
            }

            try
            {
                IWebElement danceCheckbox = driver.FindElement(By.Id("Dance"));
                if (!danceCheckbox.Selected)
                {
                    danceCheckbox.Click();
                }
                Console.WriteLine("Dance checkbox test passed.");

                IWebElement readingCheckbox = driver.FindElement(By.Id("Reading"));
                if (!readingCheckbox.Selected)
                {
                    readingCheckbox.Click();
                }
                Console.WriteLine("Reading checkbox test passed.");

                IWebElement cricketCheckbox = driver.FindElement(By.Id("Cricket"));
                if (!cricketCheckbox.Selected)
                {
                    cricketCheckbox.Click();
                }
                Console.WriteLine("Cricket checkbox test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Hobbies checkboxes test failed: " + e.Message);
            }

            try
            {
                IWebElement aboutTextarea = driver.FindElement(By.Name("About"));
                aboutTextarea.Clear();
                aboutTextarea.SendKeys("My name is Yogesh Jat, currently pursuing B.Tech in CSE from MITS Gwalior in a 6th semester. Talking about my skills, I am a MERN stack developer, having successfully delivered three high-quality projects to Indian clients, ensuring best-in-class UI and fully responsive designs. Recently, I developed my personal Chat Karo app, enabling live communication with proper authentication and authorization. Apart from web development, I am also an AI model trainer with experience in 10+ projects for foreign clients, where I trained their models, solving real-world challenges using AI. When it comes to problem-solving, I have tackled 500+ DSA problems and am a 2-star competitive programmer with a 1450+ rating on CodeChef.");
                Console.WriteLine("About Yourself textarea test passed.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("About Yourself textarea test failed: " + e.Message);
            }
        }
        finally
        {
            // driver.Quit();
        }
    }
}