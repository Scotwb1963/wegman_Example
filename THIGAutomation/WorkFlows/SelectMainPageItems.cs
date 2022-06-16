using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NextGen.ControlMapping;
using NextGen.DataClasses;
using OpenQA.Selenium.Chrome;
using NextGen.Tests;

namespace NextGen.WorkFlows
{
    public class MainPageArea 
    {
        #region Static Variable Declarations
            public static List<WorkflowObjects> NextGenMainPageControlsList = NextGenMainPageControls.getNextGenMainPageControls();
            public static WorkflowObjects tempObj;
            public static WorkflowObjects tempData;
        #endregion //Static Variable Declarations
   
    #region Select MainPage Items
        public static void SelectMainPageItems()
        {
            
        }
    #endregion   // Select MainPage Items

    }       

}