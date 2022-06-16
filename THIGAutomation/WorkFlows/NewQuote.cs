using System;
using System.Windows.Forms;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NextGen.ControlMapping;
using NextGen.DataClasses;
using NextGen.Utilities;
using OpenQA.Selenium.Chrome;
using NextGen.Tests;



namespace NextGen.WorkFlows
{
    public class NewQuoteArea
    {
        #region Static Variable Declarations
            public static List<WorkflowObjects> NextGenMainPageControlsList = NextGenMainPageControls.getNextGenMainPageControls();
            public static List<WorkflowObjects> NextGenCommQuoteControlsList = NextGenCommQuote.getNextGenCommQuoteControls();
            public static WorkflowObjects tempObj;
            public static WorkflowObjects tempData;

        #endregion

      #region 
        public static void SelectNewQuote()
        {
            ////// ///////////////////////////////////////////////////////////////////
            //////       The code below selects "New Comm Quote Portal" Link        //
            //////// ///////////////////////////////////////////////////////////////////
            //tempObj = NextGenMainPageControlsList.Find(x => x.Description.Contains("NewCommercialBtn"));
            //Common.Click(tempObj);
            //Common.ImplicitWait();

           // Common.ChangeURL();


            //*[@id="kt_quick_panel_close_btn"]/mat-icon

            // ///////////////////////////////////////////////////////////////////
            //             The code below selects "Quit News" Btn               //
            //// ///////////////////////////////////////////////////////////////////
            Common.ImplicitWait();
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("NewsQuitBtn")));
            Common.Click(tempObj);
            Common.ImplicitWait();

            //   SendKeys.SendWait("{F5}");

            /////////////////////////////////////////////////////////////////////
            //             The code below selects "New Quote" Link             //
            /////////////////////////////////////////////////////////////////////
            //Thread.Sleep(6000);
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("NewQuoteBtn"));
            Common.Click(tempObj);
           // Common.WsTest(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("QuoTeNumberTxt")));
            //Thread.Sleep(500);


        }
        #endregion
    }
}