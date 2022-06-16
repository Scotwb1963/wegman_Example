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
    public class Qualifying_Info_Area
    {
        #region Static Variable Declarations
            public static List<WorkflowObjects> NextGenMainPageControlsList = NextGenMainPageControls.getNextGenMainPageControls();
            public static List<WorkflowObjects> NextGenCommQuoteControlsList = NextGenCommQuote.getNextGenCommQuoteControls();
            public static WorkflowObjects tempObj;
            public static WorkflowObjects tempData;
            //public static RAItems raItems = new RAItems();
            public static LoginItems loginItems = new LoginItems();
            public static string busNumber = "100";
        #endregion

        #region
        public static void EnterQualInfo()
        {

            ////////////////////////////////////////////////////////////////////////
            //                       Enter Effective Date                         //
            ////////////////////////////////////////////////////////////////////////  
            //Common.EnterText(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("EffectiveDateTxt"))); 
            //Common.ImplicitWait(););

            ////////////////////////////////////////////////////////////////////////
            //                       Enter Expiration Date                        //
            ////////////////////////////////////////////////////////////////////////  
            //Common.EnterText(NextGenCommQuoteControlsList.Find(x => x.Description.Contains(""))); 
            //Common.ImplicitWait(););

            //////////////////////////////////////////////////////////////////////////
            //                Selects Prior Policy Source Drop Down                //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("PriorPolicySourceDrpDwn")));
            Common.Click(tempObj);
            Common.ImplicitWait();

            //////////////////////////////////////////////////////////////////////////
            //              Selects Prior Policy Source Drop Down Items            //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("PriorPolicySourceDrpDwnItem")));
            Common.Click(tempObj);
            Common.ImplicitWait();

            //////////////////////////////////////////////////////////////////////////
            //                       Enter Prior Policy Number                     //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("PriorPolicyNumberTxt")));
            tempObj.EnteredText = Common.raItems.PriorPolicyNumber;
            Thread.Sleep(3000);
            Common.EnterText(tempObj);
            Common.ImplicitWait();

            if (Common.raItems.QIState != null)
            {

                ////////////////////////////////////////////////////////////////////////////
                ////                           Clicks State DrpDwn                       //
                //////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDwn")));
                Common.Click(tempObj);
                Common.ImplicitWait();

                ////////////////////////////////////////////////////////////////////////////
                ////                       Clicks State DrpDwn Items                     //
                //////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDownItemsTx")));
                tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.QIState + "')]";
                Common.Click(tempObj);
                Common.ImplicitWait();
            }
            else
            {
                ////////////////////////////////////////////////////////////////////////////
                ////                           Clicks State DrpDwn                       //
                //////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDwn")));
                Common.Click(tempObj);
                Common.ImplicitWait();

                ////////////////////////////////////////////////////////////////////////////
                ////                       Clicks State DrpDwn Items                     //
                //////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("QIStateDropDnItems")));                
                Common.Click(tempObj);
                Common.ImplicitWait();
            }


            ////////////////////////////////////////////////////////////////////////
            //                     Enter Legal Entity Type                        //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("LegalEntityTypeDrpDwn")));
            Thread.Sleep(2000);
            Common.Click(tempObj);
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                      Select Dropdown Value                         //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("LegalEntityTypeDrpDwnItems")));
            tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.LegalEntityType + "')]";
            Common.Click(tempObj);
            Common.ImplicitWait();

            if (Common.raItems.LegalEntityType == "Individual")
            {
                //////////////////////////////////////////////////////////////////////////
                //                          Enter First Name                           //
                ////////////////////////////////////////////////////////////////////////  
                tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("FirstNameTxt"));
                tempObj.EnteredText = Common.raItems.FirstName;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                //////////////////////////////////////////////////////////////////////////
                //                          Enter Last Name                           //
                ////////////////////////////////////////////////////////////////////////  
                tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("LastNameTxt"));
                tempObj.EnteredText = Common.raItems.LastName;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                //////////////////////////////////////////////////////////////////////////
                //                      Clicks Off Of Enter Last Name                  //
                ////////////////////////////////////////////////////////////////////////  
                Thread.Sleep(2000);
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("BusinessNameLbl")));
                Common.ImplicitWait();               
            }
            else
            {

                ////////////////////////////////////////////////////////////////////////
                //                        Enter Business Name                         //
                ////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("BusinessNameTxt")));
                tempObj.PropertyValue1 = "//*[@id='customer|" + Common.raItems.BusinessNameID + "|businessName']";
                tempObj.EnteredText = Common.raItems.BusinessName;
                Common.EnterText(tempObj);
                Common.ImplicitWait();

                ////////////////////////////////////////////////////////////////////////
                //                            Enter FEIN                              //
                ////////////////////////////////////////////////////////////////////////  

                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("FEINTxt")));
                tempObj.PropertyValue1 = "//*[@id='customer|" + Common.raItems.FEINID + "|feinNumber']";
                tempObj.EnteredText = tempObj.EnteredText + busNumber;
                Common.EnterText(tempObj);
                Common.ImplicitWait();
            }

            ////////////////////////////////////////////////////////////////////////
            //                       Select Business Class                        //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("BusinessClassTxt"));
            Common.ClickUsingJavaScript(tempObj);
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                     Select DropDown Option                         //
            ////////////////////////////////////////////////////////////////////////
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("BusinessClassDrpDwnItem"));
            tempObj.EnteredText = Common.raItems.BusinessClass;
            Common.EnterText(tempObj);
            Common.ImplicitWait();
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("BusinessClassDrpDwnItem"));
            tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.BusinessClassSubClass + "')]";
            Common.Click(tempObj);
            Common.ImplicitWait();

            if (Common.raItems.ProductType == "")
            {
                //////////////////////////////////////////////////////////////////////////
                //                      Selects the Product Type                       //
                ////////////////////////////////////////////////////////////////////////  
                Thread.Sleep(2000);
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ProductTypeDrpDwn")));
                Common.ImplicitWait();

                //////////////////////////////////////////////////////////////////////////
                //                      Selects the Product Type Items                 //
                ////////////////////////////////////////////////////////////////////////  
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ProductTypeDrpDwnItemBusOwner")));
                Common.ImplicitWait();
            }
            else
            {

                //////////////////////////////////////////////////////////////////////////
                //                      Selects the Product Type                       //
                ////////////////////////////////////////////////////////////////////////  
                Thread.Sleep(2000);
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ProductTypeDrpDwn")));
                Common.ImplicitWait();

                //////////////////////////////////////////////////////////////////////////
                //                      Selects the Product Type Items                 //
                ////////////////////////////////////////////////////////////////////////  
                tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ProductTypeDrpDwnItem")));
                Common.ImplicitWait();
                tempObj.PropertyValue1 = "//*[contains(text(),'" + Common.raItems.ProductType + "')]";
                Common.Click(tempObj);
                Common.ImplicitWait();
            }
            
            if(Common.raItems.Company != "" )
            {
                //////////////////////////////////////////////////////////////////////////
                //                    Selects the Company Drp Dwn                      //
                ////////////////////////////////////////////////////////////////////////
                Thread.Sleep(3000);  
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("CompanyDrpDwn")));        
                Common.ImplicitWait();
                //////////////////////////////////////////////////////////////////////////
                //                  Selects the Company Drp Dwn items                  //
                ////////////////////////////////////////////////////////////////////////  
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("CompanyDrpDwnItems")));
                Common.ImplicitWait();
            }

            ////////////////////////////////////////////////////////////////////////
            //                      Is This a new venture                         //
            ////////////////////////////////////////////////////////////////////////  
            Thread.Sleep(4000);
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("IsthisAnewVentureYesBtn")));
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("IsthisAnewVentureYesBtn")));
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                  Any Loses within the las 5 years                  //
            ////////////////////////////////////////////////////////////////////////       
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AnyLossesNoBtn")));
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AnyLossesNoBtn")));
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //               Any prior insurance coverage been canceled           //
            //////////////////////////////////////////////////////////////////////  
            Thread.Sleep(2000);
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AnyPriorInsuranceNoTxt")));
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AnyPriorInsuranceNoTxt")));
            Common.ImplicitWait();
            
            ///////////////////////////////////////////////////////////////////////
            //                   Has the customer had a bankruptcy                //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("HasCustomerHadABankruptcyNoTxt")));
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("HasCustomerHadABankruptcyNoTxt"))); // Here because must be clicked Twice
            Common.ImplicitWait();
        
            
            
                //////////////////////////////////////////////////////////////////////////
                //                        Is this a declination                        //
                ////////////////////////////////////////////////////////////////////////  
                Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("IsthisaDeclinationNoBtn")));                
                Common.ImplicitWait();
           
            // This location area should be a separte .cs File //

            ////////////////////////////////////////////////////////////////////////
            //                              Next Page                             //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("NextBtn"))); 
            Common.ImplicitWait();
            //Thread.Sleep(3000);

            ////////////////////////////////////////////////////////////////////////
            //                              Enter Address                         //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AddressLineOneTxt")));
            tempObj.EnteredText = Common.raItems.AddressLineOne;
            Common.EnterText(tempObj);
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                       Select Address DropDown                      //
            //////////////////////////////////////////////////////////////////////// 
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("AddressDropDown"));
            Common.ClickUsingJavaScript(tempObj);
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                      Select Manual Input ? Btn                     //
            ////////////////////////////////////////////////////////////////////////  
            Thread.Sleep(2000);
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ManualInputBtn")));
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                              Enter City                            //
            //////////////////////////////////////////////////////////////////////// 
            tempObj = NextGenCommQuoteControlsList.Find(x => x.Description.Contains("CityTxt"));
            tempObj.EnteredText = Common.raItems.City;
            Common.TempEnterText(tempObj);
            Common.ImplicitWait();


            ////////////////////////////////////////////////////////////////////////
            //                             Select State                           //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDwn")));
            Thread.Sleep(2000);
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("StateDropDwnItems")));
            Common.Click(tempObj);
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                            Enter Zip Code                          //
            ////////////////////////////////////////////////////////////////////////  
            tempObj = (NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ZipCodeTxt")));
            tempObj.EnteredText = Common.raItems.Zipcode;
            Common.EnterText(tempObj);
            Common.ImplicitWait();
            ////////////////////////////////////////////////////////////////////////
            //                              Verify Address                        //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("verifyBtn")));
            Common.ImplicitWait();

            ////////////////////////////////////////////////////////////////////////
            //                     Select Suggested Location                      //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("UseAsEnteredBtn")));
            Common.ImplicitWait();
            Thread.Sleep(3000);

            ////////////////////////////////////////////////////////////////////////
            //                              Continue on                           //
            ////////////////////////////////////////////////////////////////////////  
            Common.Click(NextGenCommQuoteControlsList.Find(x => x.Description.Contains("ContinueBtn")));
            Common.ImplicitWait();
        }
        #endregion
    }
}