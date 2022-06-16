using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextGen.ControlMapping;


namespace NextGen.DataClasses
{
    

    public class NextGenLoginControls
    {
        public static string iteration = "";

        public static List<WorkflowObjects> NextGenLoginControlsList = new List<WorkflowObjects>();

        public static List<WorkflowObjects> getNextGenLoginControls()
        {
          #region Login & Sub Items

             NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginGroupIDBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/i[1]",
                ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
                ItemName = "",
                ItemValue = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginGroupIDLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[1]/label[1]",
                ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginGroupIDTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='inputGroupID']",
                //PropertyValue1 = "//input[@id='inputGroupID']",
                ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginUserIDLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[2]/label[1]",
                ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginUserIDBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/i[1]",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginUserIDTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='inputUserName']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "lmurphy",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginPasswordIDLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[3]/label[1]",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginPasswordIDBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[3]/div[1]/div[1]/div[1]/div[1]/i[1]",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginPasswordIDTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='inputPassword']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "Egc091124",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginSubmitBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='authSubmit']",
                ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginSubmitIDTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='authSubmit']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginForgotPassowrdID",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='showFPForm']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginID",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[@id='loginTitle']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginIDImgBack",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/main[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginIDImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//img[@id='towerRound']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenLoginControlsList.Add(new WorkflowObjects()
            {
                 
                Description = "LoginIDBack",
                PropertyType = "RelXPath",
                PropertyValue1 = "//form[@id='thigLoginForm']",
               ParentArea = "Login",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

                #region Sub Items

            

                #endregion Sub Items

            #endregion  Login & Sub Items

            return NextGenLoginControlsList;
        }
    }
}