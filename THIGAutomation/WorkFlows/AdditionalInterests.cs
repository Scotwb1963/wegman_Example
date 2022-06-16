using System;
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
    public class AdditionalInterests
    {
        #region Static Variable Declarations
            public static List<WorkflowObjects> NextGenMainPageControlsList = NextGenMainPageControls.getNextGenMainPageControls();
            public static List<WorkflowObjects> NextGenCommQuoteControlsList = NextGenCommQuote.getNextGenCommQuoteControls();
            public static WorkflowObjects tempObj;
            public static WorkflowObjects tempData;
        #endregion

      #region 
        public static void AdditionalInterest()
        {


                //////////////////////////////////////////////////////////////////////
                //          Clicks The continiue Into Additonal Interest            //
                /////////////////////////////////////////////////////////////////////
                Thread.Sleep(5000);
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AdditionalInterestContinueBtn")));
                Common.Click(tempObj);
                Common.Click(tempObj);
                Common.ImplicitWait();

            if (Common.raItems.intType != "")
            {
                /////////////////////////////////////////////////////////////////////
                //               Clicks New Additional Interest Button             //
                /////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("NewAdditionalInterestBtn")));
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                   Selects Interest Type DropDown                //
                ///////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("InterestTypeDropDown")));
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                Selects Interest Type DropDown Items             //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("InterestTypeDropDownItens")));
                tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.intType + "')]";
                Common.Click(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                        Enters Loan Number                       //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("LoanNumberTxt")));
                tempObj.EnteredText = Common.raItems.LoanNumber;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                        Selects Form Drop Down                  //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("FormsDrpDwn")));               
                Common.Click(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                        Selects Form Drop Down Items                  //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("FormsDrpDwnItems")));
                tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.Forms + "')]";
                Common.Click(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                           Enters Name                           //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AdditionalIntNameTxt")));
                tempObj.EnteredText = Common.raItems.Name;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                           Enters Address                        //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AdditionalIntAddressTxt")));
                tempObj.EnteredText = Common.raItems.Address;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                           Enters Town/City                      //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("Town/CityTxt")));
                tempObj.EnteredText = Common.raItems.TownCity;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                     Selects State Drop Down                     //
                ///////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDown")));
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                   Selects State Drop Down Items                 //
                ///////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDownItems")));
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                         Enters Zip Code                         //
                ///////////////////////////////////////////////////////////////////////
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AdditionalZipCodeTxt")));
                tempObj.EnteredText = Common.raItems.ZipCode;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////                      Clicks Location List                       //
                ///////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("SelectLocationList")));
                Common.ImplicitWait();

                ///////////////////////////////////////////////////////////////////////
                ////              Clicks Save Additional Interest Button             //
                ///////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("SaveAdditionalInterestBtn")));
                Common.ImplicitWait();
            }

                /////////////////////////////////////////////////////////////////////
                //                    Clicks The Continue Button                   //
                /////////////////////////////////////////////////////////////////////
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AdditionalInterestNextBtn")));
                Common.ImplicitWait();
            
        }
        #endregion
    }
}