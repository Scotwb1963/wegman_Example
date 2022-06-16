using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextGen.ControlMapping;


namespace NextGen.DataClasses
{
    public class NextGenMainPageControls
    {
        public static string iteration = "";

        public static List<WorkflowObjects> NextGenMainPageControlsList = new List<WorkflowObjects>();

        public static List<WorkflowObjects> getNextGenMainPageControls()
        {
            #region Main Page

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                Description = "NewsQuitBtn",
                PropertyType = "RelXPath",
                //*[@id="kt_quick_panel_close_btn"]/mat-icon
                //PropertyValue1 = "//a[@id='kt_quick_panel_close_btn']",
                PropertyValue1 =   "//*[@id='kt_content']/div/div/div[1]/div/h6",
                //*[@id="kt_quick_panel_close_btn"]/mat-icon
                //*[@id="kt_quick_panel_close_btn"]/mat-icon
                //PropertyValue1 = "/html/body/div[1]/app-root/div[2]/app-notification/div/div/a/mat-icon",
                                    
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TowerHillLogo",
                PropertyType = "RelXPath",
                PropertyValue1 = "//img[@id='thigLogo']",
                ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "WelcomeHdr",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[1]/div[1]/div[2]",
                ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "WelcomeHdrTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h3[@id='product-title']",
                ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AccountName",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Test AutomationAccount')]",
                ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AccountImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/a[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "PreferencesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/a[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "logOutImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/a[2]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "LogOutBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/a[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "PersonalLinesbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "PersonalLinesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/button[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "PersonalLinesImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "Citadelbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "CitadelBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/button[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "CitadelImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[2]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "Templarbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[3]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TemplarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[3]/form[1]/button[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TemplarImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[3]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "NewCommercialbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[4]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "NewCommercialBtn",
                PropertyType = "RelXPath",
                //PropertyValue1 = "//*[@id='application-container']/div[2]/div/div/div[4]/div/div/div[1]",
                PropertyValue1 = "//*[@id='application-container']/div[2]/div/div/div[4]/div/div/div[1]/a",
                ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "NewCommercialTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[contains(text(),'New Commercial Quote Portal')]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "NewCommercialInovationTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/div[1]/div[3]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AgentDashWatercraftBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AgentDashbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AgentdashBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/form[1]/button[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "AgentdashImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "Watercraftbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "WatercraftBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/form[1]/button[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "WatercraftImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "WatercraftImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/form[1]/button[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TowerblogTrainingvidBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TowerblogImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/a[1]/img[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TowerblogBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/a[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TowerblogBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TrainingVidBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TrainingVidBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/a[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "TrainingVidImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/a[1]/img[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "SocialMediaBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[3]/div[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "FacebookImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[3]/div[1]/a[1]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "GoogleImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[3]/div[1]/a[2]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "GoogleImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[3]/div[1]/a[2]/img[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "CopyrightFooter",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/footer[1]/div[1]/p[1]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenMainPageControlsList.Add(new WorkflowObjects()
            {
                iterationName = iteration,
                Description = "SessionFooter",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/footer[1]/div[1]/p[2]",
               ParentArea = "MainPage",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #endregion // Main Page

            return NextGenMainPageControlsList;
        }        
    }
}