using System;
using System.Windows.Input;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using NextGen.ControlMapping;
using NextGen.DataClasses;
using NextGen.Utilities;
using NextGen.WorkFlows;
using OpenQA.Selenium.Chrome;

//////////////////////////////////////////////////////////////////////////////////////////
//                                                                                      //
// Script Name:    NUTest_GetNewQuote.cs                                                //
// Author:          Winfield B. Scott, Jr                                               //
// Creation Date:   2/1/2021                                                            //
// Last Modified:   6/16/22                                                             //
// AUT:             Comm Lines                                                          //
// Script Purpose:                                                                      //
//                                                                                      //
//                                                                                      //
//////////////////////////////////////////////////////////////////////////////////////////

namespace NextGen.Tests
{
 
    [TestFixture] // This Attribute at the beginning indicates that this class is Test Fixture so that NUnit can identify it as a runnable test class

    public class NUTest_GetNewQuote0616
    {
        #region Setup Variables
        public string iterationNumber;
        public static ReportingItems reportItems = new ReportingItems();

        public static List<WorkflowObjects> NextGenCommQuoteControlsList = NextGenCommQuote.getNextGenCommQuoteControls();
        public static List<WorkflowObjects> testObj = new List<WorkflowObjects>();



        #endregion // End of Setup Variables 

        [SetUp] // This TestFixture provides a common set of functions that are performed just before each [Test] method is called
        public void Setup()
        {
            reportItems.TestName = "NUTest_GetNewQuote0616.cs";
            Common.ScriptSeup();    
                 
        }

        [Test]
        public void NUTestGetNewQuote()
        {
            WorkFlows.NewQuoteArea.SelectNewQuote();           
            WorkFlows.Qualifying_Info_Area.EnterQualInfo();
            WorkFlows.PolicyCoverages.Policy_Coverage();
           
            Thread.Sleep(5000);
        }

         [TearDown] // This TestFixture provides a common set of functions that are performed after each [Test] method is called
        public void Tear()
        {
            Common.BrowserQuit();
        }
    }
}