using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using NextGen.ControlMapping;
using NextGen.DataClasses;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Reflection;
using Newtonsoft.Json;

namespace NextGen.Utilities
{
    public class Common
    {
        #region Static Variable Declarations
        public static IWebDriver driver;
        public static IWebElement keystroke;
        public static IWebElement tempIWebElement;
        public static Stopwatch timer = new Stopwatch();
        public static Stopwatch internalTime = new Stopwatch();
        public static int counter = 0;
        public static bool boolFlag;
        public static bool clickboolFlag;
        public static string json = "";
        public static string html = "";

        public static List<WorkflowObjects> NextGenLoginControlsList = NextGenLoginControls.getNextGenLoginControls();
        public static List<WorkflowObjects> NextGenMainPageControlsList = NextGenMainPageControls.getNextGenMainPageControls();
        public static List<WorkflowObjects> NextGenCommQuoteControlsList = NextGenCommQuote.getNextGenCommQuoteControls();
        
        public static LoginItems loginItems = new LoginItems();
        public static RAItems raItems = new RAItems();
        public static SystemUnderTest sut = GetSUTData();
        public static WorkflowObjects tempObj;
        public static WorkflowObjects tempData;
        public static WorkflowObjects tempClickObj;
        public static ReportingItems reportItems = new ReportingItems();
        public static FileStream stream;
        public static string pathName = "", newPathName = "", modifiedString = "";
      



        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Variable below determines globally how long to wait for a control to be present on the page     //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static int globalWaitTime = 40;

        #endregion

        #region Script Setup
        //////////////////////////////////////////////////////////////////////////////
        //                    Code below sets up "Starter Files"                    //
        //////////////////////////////////////////////////////////////////////////////       
        public static void ScriptSeup()
        {
            LaunchBrowser();
            Login();
        }
        #endregion

        #region Launch Browser Code
        //////////////////////////////////////////////////////////////////////////////
        //                     Code below "Launches the Browser"                    //
        //////////////////////////////////////////////////////////////////////////////       
        public static void LaunchBrowser()
        {
            driver = new ChromeDriver(); //Launches the Browser
            driver.Manage().Window.Maximize(); //Maximizes the Browser
            ImplicitWait();

        }
        #endregion

        #region Login Code
        //////////////////////////////////////////////////////////////////////////////
        //                 Code below "Login into the Application"                  //
        //////////////////////////////////////////////////////////////////////////////         
        public static void Login()
        {
            driver.Url = loginItems.Url;
            ImplicitWait();

            tempClickObj = NextGenLoginControlsList.Find(x => x.Description.Contains("LoginGroupIDTxt"));
            tempClickObj.EnteredText = loginItems.GroupId;
            EnterText(tempClickObj); //GroupID
            PageDwn(tempClickObj);
            Thread.Sleep(2000);
            ImplicitWait();

            tempClickObj  = NextGenLoginControlsList.Find(x => x.Description.Contains("LoginUserIDTxt")); //Username
            tempClickObj.EnteredText = loginItems.UserName;
            EnterText(tempClickObj); 
            ImplicitWait();

            tempClickObj = NextGenLoginControlsList.Find(x => x.Description.Contains("LoginPasswordIDTxt")); //Password
            tempClickObj.EnteredText = loginItems.Password;
            EnterText(tempClickObj);
            ImplicitWait();


             tempClickObj = NextGenLoginControlsList.Find(x => x.Description.Contains("LoginSubmitBtn"));
            ImplicitWait();
            Thread.Sleep(3000);
            ImplicitWait();
            ScrollBar(tempClickObj);

            Click(NextGenLoginControlsList.Find(x => x.Description.Contains("LoginSubmitBtn"))); //Submit
            ImplicitWait();

        }
        #endregion

        #region Using IJavaScriptExecutor
        //////////////////////////////////////////////////////////////////////////////
        //             Code below create an interface for "JavaExecutor"            //
        //////////////////////////////////////////////////////////////////////////////       
        public static IJavaScriptExecutor UsingIJavaScriptExecutor()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            return jse;
        }

        #endregion //Using IJavaScriptExecutor

        #region This Closes the Browser
        public static void BrowserQuit()
        {
            //////////////////////////////////////////////////////////////////////////////
            //                     Code below "Closes the Browser"                      //
            //////////////////////////////////////////////////////////////////////////////          
            driver.Quit();

        }
        #endregion // This Closes the Browser

        #region This Scrolls Down With ScrollBar
        public static void ScrollBar(WorkflowObjects tempObj)
        {
            //////////////////////////////////////////////////////////////////////////////
            //                Code below "Scrolls Down With ScrollBar"                  //
            //////////////////////////////////////////////////////////////////////////////          

            tempIWebElement = FindControl(tempObj);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", tempIWebElement);         

        }
        #endregion // This Scrolls Down With ScrollBar

        #region PageDwn
        public static void PageDwn(WorkflowObjects tempObj)
        {
            bool ifExist = false;
            bool isVisible = false;
            bool isClickable = false;
            bool boolValue = false;
            bool inStalenessOf = false;

            timer.Reset();
            timer.Start();
            Actions action = new Actions(driver);

            do
            {
                if (timer.Elapsed.Seconds > globalWaitTime)
                {
                    //CaptureScreenShot(reportItems);
                    Assert.Fail("The Search for - " + tempObj.Description + " timed out");
                }
                else
                {
                    try
                    {
                        //Check if the value of control is not empty, if it is then retries
                        if (tempObj != null)
                        {
                            tempIWebElement = FindControl(tempObj);

                            if (tempIWebElement != null)
                            {
                                ifExist = ElementExists(tempObj);
                                if (ifExist != false)
                                {
                                    isVisible = ElementIsVisible(tempObj);
                                    if (isVisible != false)
                                    {
                                        inStalenessOf = ElementStalenessOf(tempIWebElement);
                                        if (inStalenessOf != false)
                                        {
                                            isClickable = ElementClickable(tempIWebElement);
                                            if (isClickable != false)
                                            {
                                                action.SendKeys(Keys.PageDown).Build().Perform();

                                                action.SendKeys(Keys.Tab).Build().Perform();
                                                boolValue = true;
                                            }

                                        }
                                    }
                                }
                            }
                            else
                            {
                                Assert.Fail("The value of " + tempObj.Description + " was not found");
                            }
                        }
                        else
                        {
                            Assert.Fail("The value of " + tempObj.Description + " was Null");
                        }

                    }
                    catch (OpenQA.Selenium.ElementClickInterceptedException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.NoSuchElementException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.ElementNotInteractableException e)
                    {
                        if (e.Source == null)
                        {

                            Thread.Sleep(3000);
                        }
                    }
                    catch (StaleElementReferenceException e)
                    {
                        if (e.Source == null)
                        {

                            Thread.Sleep(3000);
                        }
                    }
                }
            } while (boolValue != true);

            timer.Stop();

            Thread.Sleep(1000);
        }

        #endregion //PageDwn

        #region Implicit Wait 
        public static void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        
        }

        #endregion //Implicit Wait 

        #region Wait for Element to be Clickable 
        //////////////////////////////////////////////////////////////////////////////
        //                Code below checks if "Element is Clickable"               //
        //////////////////////////////////////////////////////////////////////////////      
        public static bool ElementClickable(IWebElement tempElement)
        {
            internalTime.Reset();
            internalTime.Start();
            boolFlag = true;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(tempElement));

            if (internalTime.Elapsed > TimeSpan.FromSeconds(9))
            {
                boolFlag = false;
            }

            internalTime.Stop();

            return boolFlag;

        }
        #endregion ///Wait for Element to be Clickable

        #region Wait for Element StalenessOf 
        //////////////////////////////////////////////////////////////////////////////
        //                Code below checks if "Element is StalenessOf"               //
        //////////////////////////////////////////////////////////////////////////////      
        public static bool ElementStalenessOf(IWebElement tempElement)
        {
            //internalTime.Reset();
            //internalTime.Start();
            //boolFlag = true;

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.StalenessOf(tempElement));

            //if (internalTime.Elapsed > TimeSpan.FromSeconds(9))
            //{
            //    boolFlag = false;
            //}

            //internalTime.Stop();

            return boolFlag;

        }
        #endregion /// Wait for Element StalenessOf 

        #region Wait for Element to be Visible   
        //////////////////////////////////////////////////////////////////////////////
        //                 Code below checks if "Element is Visible"                //
        //////////////////////////////////////////////////////////////////////////////      
        public static bool ElementIsVisible(WorkflowObjects tempObj)
        {
            internalTime.Reset();
            internalTime.Start();
            boolFlag = true;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement tempElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(tempObj.PropertyValue1)));

            if (internalTime.Elapsed > TimeSpan.FromSeconds(9))
            {
                boolFlag = false;
            }

            internalTime.Stop();

            return boolFlag;
        }
        #endregion //Wait for Element to be Visible 

        #region Wait for Element to Exists 
        //////////////////////////////////////////////////////////////////////////////
        //                   Code below checks if "Element Exist"                   //
        ////////////////////////////////////////////////////////////////////////////// 
        public static bool ElementExists(WorkflowObjects tempObj)
        {
            internalTime.Reset();
            internalTime.Start();
            boolFlag = true;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement tempElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(tempObj.PropertyValue1)));


            if (internalTime.Elapsed > TimeSpan.FromSeconds(9))
            {
                boolFlag = false;
            }

            internalTime.Stop();

            return boolFlag;

        }
        #endregion // Wait for Element to Exists 

        #region Launch TFS Code
        //public static BrowserWindow LaunchTFS()
        //{

        //    BrowserWindow browserWindow = new BrowserWindow();

        //    //////////////////////////////////////////////////////////////////////////////
        //    //           Code below sets multiple Browserwindow Class Settings          //
        //    //////////////////////////////////////////////////////////////////////////////          
        //    //Clears Cache
        //    BrowserWindow.ClearCache();
        //    //Clear Cookies
        //    BrowserWindow.ClearCookies();
        //    //Sets the Browser Type
        //    BrowserWindow.CurrentBrowser = tfs.browserType; 
        //    return _commonBrowserWindow;
        //}
        #endregion

        #region Launch TFS Code
        //public static BrowserWindow TFSLogout()
        //{

        //    BrowserWindow browserWindow = new BrowserWindow();

        //    //////////////////////////////////////////////////////////////////////////////
        //    //           Code below sets multiple Browserwindow Class Settings          //
        //    //////////////////////////////////////////////////////////////////////////////          
        //    //Clears Cache
        //    BrowserWindow.ClearCache();
        //    //Clear Cookies
        //    BrowserWindow.ClearCookies();
        //    //Sets the Browser Type
        //    BrowserWindow.CurrentBrowser = tfs.browserType;

        //    //////////////////////////////////////////////////////////////////////////////
        //    //                     Code below "Launches the Browser"                    //
        //    //////////////////////////////////////////////////////////////////////////////
        //    _commonBrowserWindow = BrowserWindow.Launch(new System.Uri(tfs.url));
        //    _commonBrowserWindow.Maximized = true;

        //    return _commonBrowserWindow;
        //}
        #endregion

        #region Read In SystemUnderTest details
        //////////////////////////////////////////////////////////////////////////////////////////////
        // The code below reads in all details about a system under test and returns a list of SUTs //
        //////////////////////////////////////////////////////////////////////////////////////////////
        public static SystemUnderTest GetSUTData()
        {
            SystemUnderTest sut = new SystemUnderTest();
            sut.url = Environment.GetEnvironmentVariable("testURL");
            sut.username = Environment.GetEnvironmentVariable("username");
            sut.password = Environment.GetEnvironmentVariable("password");
            sut.browserType = Environment.GetEnvironmentVariable("testBrowser");
            sut.driverLocation = Environment.GetEnvironmentVariable("driverFilepathChrome");
            sut.email = Environment.GetEnvironmentVariable("email");
            return sut;
        }
        #endregion

        #region Read In a File
        ///////////////////////////////////////////////////////////////////
        //          The code below reads in data from a filees           //
        ///////////////////////////////////////////////////////////////////
        public static List<string> ReadinaFile(string filePath)
        {
            StreamReader reader = null;

            List<string> listA = new List<string>();

            //while (CsvReader.Read())
            //{
            //    if (CsvReader.Context.Record.IsEmpty())
            //    {
            //        ListListMyClass.Add(new List<MyClass>(ListObject));
            //        ListMyClass.Clear();
            //        continue;
            //    }
            //    ListMyClass.Add(CsvReader.GetRecord<MyClass>());
            //}


            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    List<string> lineValues = line.Split(',').ToList();

                    foreach (var item in lineValues)
                    
                    {
                        foreach (var row1 in listA)
                        {
                            Console.WriteLine(row1);
                        }

                        listA.Add(item);
                    }
                    foreach (var coloumn1 in listA)
                    {
                        Console.WriteLine(coloumn1);
                    }


                }

            }

            return listA;
        }
        #endregion // Read In a File

        #region Temp Method
        ////////////////////////////////////////////////////////////////////////
        ////            The code below "Logs" in the Application              //
        ////////////////////////////////////////////////////////////////////////  
        public static void TempEnterText(WorkflowObjects enterTextObj)
        {
            //tempIWebElement = driver.(By.XPath("*//label[text()='City*']/following-silbling::"));
            tempIWebElement = driver.FindElement(By.XPath("//*[@id='locationSection|locations|location|city']"));
            tempIWebElement.SendKeys(enterTextObj.EnteredText);
        }
        #endregion//Temp Method

        #region Click
        public static void Click(WorkflowObjects tempClickObj)
        {
            bool boolValue = false;
            bool ifExist = false;
            bool isVisible = false;
            bool isClickable = false;
            bool inStalenessOf = false;

            timer.Reset();
            timer.Start();

            do
            {
                if (timer.Elapsed.Seconds > globalWaitTime)
                {
                    //CaptureScreenShot(reportItems);
                    Assert.Fail("The Search for - " + tempClickObj.Description + " timed out");
                }
                else
                {
                    try
                    {
                        //Check if the value of control is not empty, if it is then retries
                        if (tempClickObj != null)
                        {
                            tempIWebElement = FindControl(tempClickObj);

                            if (tempIWebElement != null)
                            {
                                ifExist = ElementExists(tempClickObj);
                                if (ifExist != false)
                                {
                                    isVisible = ElementIsVisible(tempClickObj);
                                    if (isVisible != false)
                                    {
                                        isClickable = ElementClickable(tempIWebElement);
                                        if (isClickable != false)
                                        {
                                            tempIWebElement.Click();
                                            boolValue = true;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Assert.Fail("The value of " + tempClickObj.Description + " was not found");
                            }
                        }
                        else
                        {
                            Assert.Fail("The value of " + tempClickObj.Description + " was Null");
                        }

                    }
                    catch (OpenQA.Selenium.ElementClickInterceptedException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.NoSuchElementException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.ElementNotInteractableException e)
                    {
                        if (e.Source == null)
                        {

                            Thread.Sleep(3000);
                        }
                    }
                    catch (StaleElementReferenceException e)
                    {
                        if (e.Source == null)
                        {

                            Thread.Sleep(3000);
                        }
                    }
                }
            } while (boolValue != true);

            timer.Stop();

        }

        #endregion //Click

        #region Enter Text
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // The Code Below Clicks on the given object and waits for the expected object to become available in the given amount of time //
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void EnterText(WorkflowObjects enterTextObj)
        {
            bool boolValue = false;
            bool ifExist = false;
            bool isVisible = false;
            bool isClickable = false;
            bool inStalenessOf = false;

            timer.Reset();
            timer.Start();

            do
            {
                if (timer.Elapsed.Seconds > globalWaitTime)
                {
                    //CaptureScreenShot(reportItems);
                    Assert.Fail("The Control - " + enterTextObj.Description + " wasn't found");
                }
                else
                {
                    try
                    {
                        //Check if the value of control is not empty, if it is then retries
                        if (enterTextObj != null)
                        {
                            tempIWebElement = FindControl(enterTextObj); // This finds the Control based on PropertyType

                            if (tempIWebElement != null)
                            {
                                ifExist = ElementExists(enterTextObj);

                                if (ifExist != false)
                                {
                                    isVisible = ElementIsVisible(enterTextObj);

                                    if (isVisible != false)
                                    {
                                        inStalenessOf = ElementStalenessOf(tempIWebElement);
                                        
                                        if (inStalenessOf != false)
                                        {
                                            isClickable = ElementClickable(tempIWebElement);

                                            if (isClickable != false)
                                            {
                                                tempIWebElement.SendKeys(enterTextObj.EnteredText);
                                                boolValue = true;

                                            }

                                        }
                                    }

                                }
                            }

                        }
                        else
                        {
                            Assert.Fail("The value of " + enterTextObj.Description + " was Null");
                        }

                    }
                    catch (OpenQA.Selenium.ElementClickInterceptedException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.NoSuchElementException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.ElementNotInteractableException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                }
            } while (boolValue != true);

            timer.Stop();

        }
        #endregion

        #region Click Using JavaScript
        /////////////////////////////////////////////////////////////
        //  The Code below clicks Object using JavaScript Executor //    
        /////////////////////////////////////////////////////////////
        public static void ClickUsingJavaScript(WorkflowObjects tempClickObj)
        {
            IJavaScriptExecutor jse = UsingIJavaScriptExecutor();

            String javascript = "arguments[0].click()";

            tempIWebElement = FindControl(tempClickObj);

            bool boolValue = false;

            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();

            do
            {
                if (timer.Elapsed.Seconds > globalWaitTime)
                {
                    //CaptureScreenShot(reportItems);
                    Assert.Fail("The Control " + tempClickObj.Description + " was not found");
                }
                else
                {
                    try
                    {
                        //Check if the value of control is not empty, if it is then retries
                        if (tempClickObj != null)
                        {
                            jse.ExecuteScript(javascript, driver.FindElement(By.XPath(tempClickObj.PropertyValue1)));
                            boolValue = true;
                        }
                        else
                        {
                            Assert.Fail("The value of " + tempClickObj.Description + " was Null");
                        }

                    }
                    catch (OpenQA.Selenium.ElementClickInterceptedException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.NoSuchElementException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.ElementNotInteractableException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                }
            } while (boolValue != true);

            timer.Stop();

        }
        #endregion //Click Using JavaScript

        #region Enter Text Using JavaScript
        /////////////////////////////////////////////////////////////
        //   The Code below Enters Text using JavaScript Executor  //    
        /////////////////////////////////////////////////////////////
        public static void EnterTextUsingJavaScript(WorkflowObjects tempEnterObj)
        {
            IJavaScriptExecutor jse = UsingIJavaScriptExecutor();

            tempIWebElement = FindControl(tempEnterObj);

            bool boolValue = false;

            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();

            do
            {
                if (timer.Elapsed.Seconds > globalWaitTime)
                {
                    //CaptureScreenShot(reportItems);
                    Assert.Fail("The Control " + tempEnterObj.Description + " was not found");
                }
                else
                {
                    try
                    {
                        //Check if the value of control is not empty, if it is then retries
                        if (tempEnterObj != null)
                        {
                            jse.ExecuteScript("arguments[0].value=" + tempEnterObj.EnteredText, tempIWebElement);
                            boolValue = true;
                        }
                        else
                        {
                            Assert.Fail("The value of " + tempEnterObj.Description + " was Null");
                        }

                    }
                    catch (OpenQA.Selenium.ElementClickInterceptedException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.NoSuchElementException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    catch (OpenQA.Selenium.ElementNotInteractableException e)
                    {
                        if (e.Source == null)
                        {
                            Thread.Sleep(3000);
                        }
                    }
                }
            } while (boolValue != true);

            timer.Stop();

        }
        #endregion //GetDropDown

        #region Dropdown: SelectedItem
        /////////////////////////////////////////////////////////////
        //    The Code below selects an "Item" from a Dropdown     //    
        /////////////////////////////////////////////////////////////
        public static void DropdownSelectedItem(WorkflowObjects tempDropdownObj)
        {
            //try
            //{
           
           tempIWebElement = FindControl(tempDropdownObj);

            int numofitems = tempIWebElement.FindElements(By.TagName("option")).Count;

            for (int i = 1; i < numofitems; i++)
            {
                //driver.s.select("TagName = option", "index = i");
            }

            SelectElement oSelect = new SelectElement(tempIWebElement);
           // SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath(tempDropdownObj.PropertyValue1)));
            oSelect.SelectByText(tempDropdownObj.SelectedItem);

            //}
            //catch ( )
            //{

            //}
        }
        #endregion //Dropdown: SelectedItem

        #region Find Control Code
        ////////////////////////////////////////////////////////////////////////////////////////
        ////             Code below will find a "Control" by a given attribute                //
        ////////////////////////////////////////////////////////////////////////////////////////  
        public static IWebElement FindControl(WorkflowObjects objectToFind)
        {
            if (objectToFind.PropertyType == "RelXPath")
                tempIWebElement = driver.FindElement(By.XPath(objectToFind.PropertyValue1));
            else if (objectToFind.PropertyType == "Name")
                tempIWebElement = driver.FindElement(By.Name(objectToFind.PropertyValue1));
            else if (objectToFind.PropertyType == "Id")
                tempIWebElement = driver.FindElement(By.Id(objectToFind.PropertyValue1));
            else if (objectToFind.PropertyType == "cssSelector")
                tempIWebElement = driver.FindElement(By.CssSelector(objectToFind.PropertyValue1));



            return tempIWebElement;
        }
        #endregion

        #region Find Current Project Path
        public static string CurrentProjectPath()
        {
            try
            {
                string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                return directoryName.Substring(0, directoryName.IndexOf("bin"));
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        #endregion //Find Current Project Path

        #region Find Current File Path
        public static string ConfigFilePath(string configFolderName, string configFileName)
        {
            try
            {
                string str1 = CurrentProjectPath();
                string codeBase = Assembly.GetCallingAssembly().CodeBase;
                string str2 = str1 + configFolderName + "\\" + configFileName + ".config";
                //Report.ReportPass("Able to fetch the Config File path. Foldername: " + configFolderName + " File Name: " + configFileName);
                return str2;
            }
            catch (Exception ex)
            {
                //Report.ReportFail("Unable to fetch the Current project path. Foldername: " + configFolderName + " File Name: " + configFileName + "Error message:" + ex.InnerException.ToString());
                return "";
            }
        }

        #endregion //Find Current  File Path  

        #region Deserialize Object
        public static void DeserializeObject(string strJSON)
        {
            try
            {
               // LoginItemsList = JsonConvert.DeserializeObject<LoginItems>(02);
            }
            catch
            {
                 
            }
            
        }
        #endregion //Deserialize Object

        #region Read in RA's Json File
        public static void ReadRAJsonFile()
        {
            json = File.ReadAllText(@"c:\Ws\JsonFiles\8554.json");

            raItems = JsonConvert.DeserializeObject<RAItems>(json);
            Console.WriteLine(raItems.AccountReceivable);
            Console.WriteLine(raItems.SpecialClassPropertyLimit);



        }
        #endregion //Read in RA's Json File

        #region /Read in Login's Json File
        public static void ReadLoginJsonFile()
        {
                json = File.ReadAllText(@"c:\Ws\Login.json");

            loginItems = JsonConvert.DeserializeObject<LoginItems>(json);
                Console.WriteLine(loginItems.UserName);          
 
        

        }
        #endregion //Read in Login's Json File

        #region Clearing TextBox Contents
        public static void Clear(WorkflowObjects tempObj)
        {
            Actions action = new Actions(driver);

            tempIWebElement = FindControl(tempObj);
            //action.SendKeys(Keys.Control).Build().Perform();
            action.KeyDown(Keys.Control);
            action.SendKeys("a");
            action.KeyUp(Keys.Control);
            action.Perform();
            action.SendKeys(Keys.Backspace).Build().Perform();

        }


        #endregion Clearing TextBox Contents

        #region Pressing F12
        public static void F12(WorkflowObjects tempObj)
        {
            Actions action = new Actions(driver);
            tempIWebElement = FindControl(tempObj);

            action.SendKeys(Keys.F12).Build().Perform();
            
           

        }


        #endregion pressing F12

        #region Write out a Json File
        public static void WriteOutaJsonFile()
        {
            //ControlMap objectToFind = controlsList.Find(X => X.description.Contains(description));

            //IWebElement element = null;

            //element = FindInputField(objectToFind);

            //element.Click();

            //if ((objectToFind.textToEnter != null) || (objectToFind.textValue == "*"))
            //{
            //    element.SendKeys(objectToFind.textToEnter);
            //}
            //else
            //{
            //    element = browser.FindElement(By.XPath(objectToFind.textValue));
            //    element.Click();
            //}

        }
        #endregion // Write out a Json File

    }
}