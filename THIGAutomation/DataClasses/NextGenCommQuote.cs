using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextGen.ControlMapping;
using NextGen.Utilities;


namespace NextGen.DataClasses
{
    public class NextGenCommQuote
    {
        public static string iteration = "";

        public static List<WorkflowObjects> NextGenCommQuoteControlsList = new List<WorkflowObjects>();

        public static List<WorkflowObjects> getNextGenCommQuoteControls()
        {
            var now = DateTime.Now;

            #region NextGenCommQuote & Sub Items

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Header",
                PropertyType = "RelXPath",
                PropertyValue1 = "//nav[@id='main-navigation']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TowerHillBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TowerHillImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[1]/a[1]/img[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CommRateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h2[contains(text(),'Commercial Rating & Policy Management')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyOverrideBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[1]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyOverrideImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[1]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuickLinkBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #region SubArea-Quicklinks
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuickLinkBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgentDashBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[1]/mat-grid-tile[1]/figure[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgentDashImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[1]/mat-grid-tile[1]/figure[1]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InnovationBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[2]/mat-grid-tile[1]/figure[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InnovationImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[2]/mat-grid-tile[1]/figure[1]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SupportDocumentsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[3]/mat-grid-tile[1]/figure[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SupportDocumentsImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[3]/mat-grid-tile[1]/figure[1]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RPMBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[4]/mat-grid-tile[1]/figure[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RPMImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[2]/form[1]/mat-grid-list[1]/div[1]/div[1]/a[4]/mat-grid-tile[1]/figure[1]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "Quicklinks",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #endregion SubArea-Quicklinks


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuickLinkImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[2]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "News&AnnouncBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[@id='kt_quick_panel_toggler_btn']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "News&AnnouncImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[3]/div[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PersonalInfoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header/div[1]/nav[1]/div[3]/div[2]/div[4]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PersonalInfoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Hi,')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PersonalInfoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Test AutomationAccount')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PersonalInfoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Tower Hill Test Agency')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AccountIdTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'7777')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Navbar",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='navbarCollapse']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ApplicationsBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header-menu/div[1]/div[1]/div[1]/div[1]/ul[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HomeBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header-menu/div[1]/div[1]/div[1]/div[1]/ul[1]/li[1]/a[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HomeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Home')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyManagBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header-menu/div[1]/div[1]/div[1]/div[1]/ul[1]/li[2]/a[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyManagTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Policy Management')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewQuoteBtn",
                PropertyType = "RelXPath",
                //PropertyValue1 = "//app-header-menu/div[1]/div[1]/div[1]/div[1]/ul[1]/li[3]/a[1]",
                PropertyValue1 = "//*[@id='kt_header_menu']/ul/li[3]/a",            
                //PropertyValue1 = "//*[@id='kt_quick_panel_close_btn']/mat-icon",               
                //*[@id="kt_header_menu"]/ul/li[3]/a/span
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewsQuitBtn",
                PropertyType = "RelXPath",              
              //  PropertyValue1 = "/html/body/div[1]/app-root/div[2]/app-notification/div/div/a",
                PropertyValue1 = "//*[@id='kt_quick_panel_close_btn']/mat-icon",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #region SubArea-NewQuote
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/app-date-picker[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = now.ToString("MM//dd/yyyy"),
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateCalendarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[2]/app-date-picker[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateCalendarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[2]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[2]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LegalEntityTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LegalEntityTypeDrpDwn",
                PropertyType = "RelXPath",
                //PropertyValue1 = "",
                PropertyValue1 = "//*[@id='legalEntityType']/div/div[1]/div[3]",                 
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LegalEntityTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
                ItemName = "",
                ItemValue = "",
                NewQuoteType = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FirstNameTxt",
                PropertyType = "RelXPath",               
                PropertyValue1 = "//*[@id='customer|individual|individualCustomer|firstName']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LastNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|individual|individualCustomer|lastName']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessNameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='legalEntityNameIndividual']/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer||businessName']",
                //PropertyValue1 = "",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "Functional Co-1",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FEINLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[4]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FEINTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer||feinNumber']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "123457",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-group-auto-complete[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quote|businessClass']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "LRO",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassDrpDwnItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-initial-qualifier/div/div/div/div/div/form/app-group-auto-complete/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CompanyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CompanyTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-dropdown[3]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisanewVentureLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisAnewVentureYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|isNewVenture|Yes']/label/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisAnewVentureYesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[1]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisAnewVentureNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[1]/div[1]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisAnewVentureNoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[1]/div[1]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyLossesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyLossesYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[2]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyLossesYesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[2]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyLossesNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|hasLosses|No']/label/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyLossesNoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[2]/div[1]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyPriorInsuranceLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyPriorInsuranceYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[3]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyPriorInsuranceYesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[3]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyPriorInsuranceNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[3]/div[1]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnyPriorInsuranceNoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|isPriorInsuranceCancelled|No']/label/div[1]",                                 
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HasCustomerHadABankruptcyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HasCustomerHadABankruptcyYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[4]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HasCustomerHadABankruptcyYesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[4]/div[1]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HasCustomerHadABankruptcyNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-initial-qualifier[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/app-radio[4]/div[1]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HasCustomerHadABankruptcyNoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-initial-qualifier/div/div/div/div/div/form/app-radio[4]/div/mat-radio-group/mat-radio-button[2]/label/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsthisaDeclinationNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-initial-qualifier/div/div/div/div/div/form/app-radio[5]/div/mat-radio-group/mat-radio-button[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NextBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='initQual|step1|next']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLocationLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Address Location')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLocationBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]/section[1]/form[1]/div[1]/div[1]/app-group-auto-complete[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]/section[1]/form[1]/div[1]/div[1]/app-group-auto-complete[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CommercialResidentialTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Commercial Residential')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLineOneLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]/section[1]/form[1]/div[1]/div[2]/app-google-place[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

           
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressDropDown",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]/section[1]/form[1]/div[1]/div[2]/app-google-place[1]/mat-form-field[1]/div[1]/div[1]/div[3]",                            
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "12290 San Jose Boulevard, Jacksonville, FL, USA",
                EnteredText = "12290 San Jose Boulevard, Jacksonville, FL, USA",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLineOneTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|addressLine1']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "12290 San Jose Boulevard, Jacksonville, FL, USA",
                EnteredText = "12290 San Jose Boulevard, Jacksonville, FL, USA",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EnterlocationImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-icon[contains(text(),'room')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SuiteLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Suite')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SuiteTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-clearance[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]/div[1]/app-address-common[1]/div[1]/div[1]/section[1]/form[1]/div[1]/div[3]/div[1]/div[1]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ManualInputBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(), 'Manual Input ?')]",
                //PropertyValue1 = "//*[ text() = ‘Manual Input ?’ ]"
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CityTxt",
                PropertyType = "RelXPath",
                //PropertyValue1 = "//*[input[@name='locationSection|locations|location|city']]",
                PropertyValue1 = "//*[@id='locationSection|locations|location|city']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "Jacksonville",
                EnteredText = "Jacksonville",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDropDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='state']/div/div[1]/div[3]",              
                //*[@id="mat-option-53"]/div
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PriorPolicySourceDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='priorPolicySource']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PriorPolicySourceDrpDwnItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PriorPolicyNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|priorPolicyNumber']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QIStateDropDnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDropDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(), 'Florida')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipCodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|zipCode']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "32223",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UseAsEnteredBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='suggested_candidateLocation0']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "verifyBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|verify']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PrevBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='initQual|step2|prev']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='initQual|step2|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExitBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='initQual|step2|exit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoveragesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Policy Coverages')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoveragesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='page-container']/app-root/div[1]/main/div/app-quick-quote/div/app-quotedetails/div/div[2]/mat-card/mat-list/mat-list-item[1]/div/div[3]/div[2]/app-button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessLiabilityLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessLiabilityLimitTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='mat-select-value-11']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessLiabilityLimitBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddTerrorismCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddTerorismCoverageDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Terrorism Coverage ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddTerorismCoverageDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddTerorismCoverageDrpDwnItemNo",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MedicalExpensesLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MedicalExpensesLimitDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            //*[contains(text(),'here')]
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MedicalExpensesLimitDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CauseOfLossLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CauseOfLossDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InflationGuardLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='inflationGuard']/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InflationGuardDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='inflationGuard']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InflationGuardDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DamagetoPremisesRentedbyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DamagetoPremisesRentedbyDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/app-dropdown[3]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DamagetoPremisesRentedbyDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalCoveragesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Additional Coverages')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BlanketToolsAndEquipmentBtn",
                PropertyType = "RelXPath",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                PropertyValue1 = "",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BlanketToolsAndEquipmentTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Blanket Tools and Equipment')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BlanketToolsAndEquipmentBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[2]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BlanketToolsAndEquipmentLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Limit Amount']", 
                                   //*[@id="quote|coverages|coverage1321|lineItemSection|lineItems|lineItem0|limitAmount"]
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeBenefitsLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employee Benefits Liability')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeBenefitsLiabilityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employee Benefits Liability')]",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeBenefitsLiabilityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[3]/div/div[1]/app-checkbox/div/mat-checkbox/label/span/span[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofEmployeesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[3]/div[2]/app-line-items[1]/app-employee-benefits-liability[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofEmployeesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Number Of Employees']",
                //PropertyValue1 = "input[type='Number Of Employees']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "20",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RetroactiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[3]/div[2]/app-line-items[1]/app-employee-benefits-liability[1]/app-date-picker[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RetroactiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='mmddyyyy']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "01012021",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            //*[@id="page-container"]
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "F12Test",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quoteDetailsSection|policyAndCoveragesSection|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RetroactiveDateCalendarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[3]/div[2]/app-line-items[1]/app-employee-benefits-liability[1]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeDishonestyBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employee Dishonesty')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeDishonestyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employee Dishonesty')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeDishonestyLblBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Limit Amount')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/div[1]/div[1]/mat-option[6]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfEmployeesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfEmployeesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Number of Employees']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "20",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfEmployeesTxtBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfLocationsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfLocationsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Number of Locations']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "1",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfLocationsTxtBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[2]/app-line-items[1]/app-employee-dishonesty[1]/app-masked-input[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeesToolsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employees Tools')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[6]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeesToolsBTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Employees Tools')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeesToolsLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quote|coverages||lineItemSection|lineItems|lineItem0|limitAmount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ForgeryandAlterationBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),' Forgery or Alteration ')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[7]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ForgeryandAlterationLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[6]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeesToolsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeDishonestyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[4]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmployeeBenefitsLiabilityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BlanketToolsandEquipmentLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[2]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedAutoLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),' Hired and Non-Owned Auto Liability ')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedAutoLiabilityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[7]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredUseOwnedAuotsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-hired-nonowned-liability[1]/app-radio[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredProvideAnyshuttleServicesYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages||lineItemSection|lineItems|lineItem0|shuttleServices|Yes]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredProvideAnyDeliveryServicesYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages|coverage1462|lineItemSection|lineItems|lineItem0|deliveryServices|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredUseOwnedAuots3300YesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages||lineItemSection|lineItems|lineItem0|ownedAutos|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredUseOwnedAuotsYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages|coverage1461|lineItemSection|lineItems|lineItem0|ownedAutos|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheInsuredUseOwnedAuotsNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='quote|coverages|coverage1532|lineItemSection|lineItems|lineItem0|ownedAutos|No']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AutoInsurerLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-hired-nonowned-liability[1]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AutoInsurerTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Auto Insurer']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "Toyota Arlington",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyNuymberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-hired-nonowned-liability[1]/app-text-field[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyNuymberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Policy Number']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "FL599999-200",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-hired-nonowned-liability[1]/app-date-picker[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[8]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDeliveryServiceDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[7]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDateTxt3300",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[7]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDateTxt1310",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[8]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDateTxt7203",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[7]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HiredAndNon-OwnedEffectiveDateTxt1195",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-policy-coverages/div/div/form/div[1]/div[10]/div[2]/app-line-items/app-hired-nonowned-liability/app-date-picker/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "10/1/2020",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateCalendarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-hired-nonowned-liability[1]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Installation Coverage')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[9]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[8]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Limit Amount')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='mat-select-value-25']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageLimitAmountDrpdwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Limit Amount')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InstallationCoverageLimitAmountDrpdwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/div[1]/div[1]/mat-option[4]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Non_OwnedToolsandEquipmentBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Non-Owned Tools and Equipment')]",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Non_OwnedToolsandEquipmentLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[9]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Non_OwnedToolsandEquipmentLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[9]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Non_OwnedToolsandEquipmentLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages||lineItemSection|lineItems|lineItem0|limitAmount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesAndDisposalLegalLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),' Sales & Disposal Legal Liability ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesAndDisposalLegalLiabilityLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[12]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesAndDisposalLegalLiabilityLimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages|coverage1418|lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesAndDisposalLegalLiabilityLimitAmountDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerGoodsLegalLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages|coverage1404|coverageName']/label/div",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerGoodsLegalLiabilityLimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quote|coverages|coverage1404|lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerGoodsLegalLiabilityLimitAmountDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[9]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-policy-coverages[1]/div[1]/div[1]/form[1]/div[1]/div[9]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoverageContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quote|coverages|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsAndBuildingsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='page-container']/app-root/div[1]/main/div/app-quick-quote/div/app-quotedetails/div/div[2]/mat-card/mat-list/mat-list-item[2]/div/div[3]/div[2]/app-button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoveragesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Policy Coverages')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Locations&BuildingsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Locations & Buildings')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Additional Interest')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Summary')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quoteDetailsSection|summarySection|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GenerateQuoteLetterBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='generateQuoteLetter']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GenerateQuoteLetterSaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='summarySection|bindingRequirements|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='summary|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Request To Bind')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='quoteDetailsSection|requestToBindSection|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindStreetAddressTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|mailing|addressLine1']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "12290 SAN JOSE BLVD",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindCityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|mailing|locality']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "JACKSONVILLE",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindStateDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='mailingState']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindStateDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[14]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RequesttoBindZipCodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|mailing|postalCode']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "32223",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SameAsMailingAddressBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='customer|billing|isSameAsMailing']/label/div",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ConformationLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Confirmation')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteNumberBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsMenuButton']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Quote Number:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'QT0000142030')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InsuredNameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Insured Name:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InsuredNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Functional Co-1')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Effective Date:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'01/29/2021')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Expiration Date:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateLTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'01/29/2022')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Product Type:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Business Owners Policy')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

        NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CompanyDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='company']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CompanyDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Business Class:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[6]/span[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyStatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Policy Status:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyStatusTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'QUOTE')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CarrierLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Carrier:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CarrierTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Tower Hill Prime')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Premium:')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[9]/span[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaxesAndFeesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[10]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaxesAndFeesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[10]/span[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumIncclTaxesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[11]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumIncclTaxesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[1]/div[2]/div[1]/ul[1]/li[11]/span[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalPremiumBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='documentsMenuButton']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalPremiumBtnImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[@id='collapseExample']/div[1]/div[1]/div[1]/div[1]/button[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalPremiumBtnImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[@id='collapseExample']/div[1]/div[1]/div[1]/div[1]/button[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Underwriter-WarningsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='WarningButton']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Underwriter-WarningsBtnImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//header/div[@id='collapseExample']/div[1]/div[1]/div[1]/div[2]/button[1]/span[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ContactUsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|contactUs']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RateBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|rate']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExitBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|exit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Locations')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddNewBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locationSummary|addNew']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationDetailsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-step-header",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[1]/h4[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[1]/app-location-list[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/a[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskAddressLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskAddressTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|addressLine1']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLineTwoTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|addressLine2']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|city']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='mat-select-value-25']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipCodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|zipCode']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SuiteTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|zipCode']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OrderSDIIReportBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|orderSDII']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationTab|locationSection|locations|location|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-icon[contains(text(),'edit')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationDetailLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Location Detail')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnnualRevenueLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnnualRevenueTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|annualRevenue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "44871",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnnualRevenue$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AnnualRevenueCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CountyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CountyDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectionClassLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CountyDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CountyDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectionClassDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='protectionClass']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectionClassDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialInstructionForInspectionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Special Instructions for Inspection')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialInstructionForInspectionTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|specialInstrforInspection']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoastalDistanceLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoastalDistanceDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='coastalDistance']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoastalDistanceDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-group-auto-complete[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessSubClassTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|locationSubclass']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessClassTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-group-auto-complete[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Location Deductible')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailDrpDwnItemsNo",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailDrpDwnItemsNo7203",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailDrpDwnItemsNo7203",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExcludeWind/HailDrpDwnItemsYes",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/div[1]/div[1]/mat-option[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DeductibleTypelbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DeductibleTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DeductibleTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllOtherPerilsDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllOtherPerilsDeductibleLblDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='perilsDeductible']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllOtherPerilsDeductibleLblDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HurricaneDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HurricaneDeductibleDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='hurricaneDeductible']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HurricaneDeductibleDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WindHailDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WindHailDeductibleLblDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[4]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WindHailDeductibleLblDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IncludeSinkHoleLossCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Sinkhole Loss Coverage ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IncludeSinkHoleLossCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[5]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IncludeSinkHoleLossCoverageDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages|coverage24963|lineItemSection|lineItems|lineItem0|sinkholeLossDeductible']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IncludeSinkHoleLossCoverageDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IncludeSinkHoleLossCoverageDrpDwnItems5000",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[8]/div",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SinkholeLossDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[6]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SinkholeLossDeductibleDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[6]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SinkholeLossDeductibleDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[6]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ValuationMethodLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[7]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ValuationMethodLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[4]/div[1]/app-dropdown[7]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UnderwritingQuestionsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Underwriting Questions')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalParkingAreaOwnedOrMaintainedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalParkingAreaOwnedOrMaintainedTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|glQuestions|parkingArea|totalParkingAreaOwnOrmaintainedByApplicant']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsNextBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[1]/form/div/div/div/app-locations/div/div/footer/div/div/div/app-button/button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AccountsReceivableLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AccountsReceivableBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AccountsReceivableLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AccountsReceivableLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html[1]/body[1]/div[1]/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/input[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "200000",
                EnteredText = "200000",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[1]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredClubMemberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[2]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredClubMemberBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[2]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredClubMemberBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredCondominiumUnitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredCondominiumUnitBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredTownhouseAssociationLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[4]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredTownhouseAssociationBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[4]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredUsersOfGolfMobilesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInsuredUsersOfGolfMobilesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeWithExtraExpenseCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[6]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeWithExtraExpenseCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'Business Income with Extra Expense Coverage')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeWithExtraExpenseLimitTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[3]/div[2]/app-line-items/app-business-extra-expense/app-masked-input/div/mat-form-field/div/div[1]/div[4]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MonthIndemnityDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MonthIndemnityDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[6]/div[2]/app-line-items[1]/app-type-list[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExtraExpenseTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|type']/div/div[1]/div[3]",
                                  //*[@id="locationSection|locations|location|coverages|coverage22726|lineItemSection|lineItems|lineItem0|type"]/div/div[1]/div[3]
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExtraExpenseTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeordinaryPayrollLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[7]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeordinaryPayrollBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Business Income (Ordinary Payroll Expenses) ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeExtendedCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[2]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[8]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeExtendedCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'Business Income (Extended) Coverage')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessIncomeExtendedCoverageLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[8]/div[2]/app-line-items/app-business-income-extended/app-masked-input/div/mat-form-field/div/div[1]/div[4]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofDaysLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[8]/div[2]/app-line-items[1]/app-business-income-extended[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofDaysDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|numberOfDays']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofDaysDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ComprehensiveBusinessLiabilityExclusionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[9]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ComprehensiveBusinessLiabilityExclusionBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[9]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[9]/div[2]/app-line-items[1]/app-decription-text[1]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages|coverage24745|lineItemSection|lineItems|lineItem0|description']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DebrisRomvalAdditionalInsuranceLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[10]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DebrisRomvalAdditionalInsuranceBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Debris Removal Additional Insurance ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DebrisRomvalAdditionalInsuranceLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='propertyCoveragesPage']/div[10]/div[2]/app-line-items/app-limit-amount-integer/app-masked-input/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DebrisRemovalLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']",
                //PropertyValue1 = "//*[@id="locationSection | locations | location | coverages | coverage23360 | lineItemSection | lineItems | lineItem0 | limitAmount"]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "100000",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmoun$tTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[10]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[10]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EquipmentBreakdownLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[11]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EquipmentBreakdownBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Equipment Breakdown ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[11]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EquipmentBreakdownLimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[11]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FineArtsCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[12]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FineArtsCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Fine Arts Coverage ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LiquorLiabilityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LiquorLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LiquorLiabilityTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[2]/app-line-items[1]/app-liquor-liability[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LiquorLiabilityTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[2]/app-line-items[1]/app-liquor-liability[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesTotalLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[2]/app-line-items[1]/app-liquor-liability[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesTotalTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages|coverage24869|lineItemSection|lineItems|lineItem0|salesTotal']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesTotal$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[2]/app-line-items[1]/app-liquor-liability[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesTotalCentTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[13]/div[2]/app-line-items[1]/app-liquor-liability[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MoneyandSecuritiesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[14]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MoneyandSecuritiesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Money and Securities ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[14]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MoneyandSecuritiesLimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[14]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "MoneyandSecuritiesLimitAmountDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[14]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[15]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Outdoor Signs ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[15]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "15000",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsLimitAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[15]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OutDoorSignsLimitAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[15]/div[2]/app-line-items[1]/app-limit-amount-integer[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolluantCoverageDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages|coverage23926|lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolluantCoverageDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyDamageLegalLiabilityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[16]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyDamageLegalLiabilityBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Property Damage Legal Liability ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyDamageLegalLiabilityLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[16]/div[2]/app-line-items/app-limit-type-list/app-dropdown/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyDamageLegalLiabilityLimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyDamageLegalLiabilityLimitAmountDrpDwnitems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ScheduledToolsAndEquipmentLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[17]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ScheduledToolsAndEquipmentBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[17]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoverageAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoverageAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages|lineItemEditable|coverageAmount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoverageAmount$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoverageAmountCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages|lineItemEditable|description']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SerialNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-text-field[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SerialNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|coverages|lineItemEditable|serialNumber']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-scheduled-tools-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DiscardBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|coverages|lineItemEditable|discard']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|coverages|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CloseBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'×')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[18]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Special Class Property ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-special-class-property-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-special-class-property-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyLimitTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages|lineItemEditable|limit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Limit$Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-special-class-property-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-special-class-property-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitCentsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-special-class-property-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[5]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyDiscardBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|coverages|lineItemEditable|discard']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertySaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|coverages|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyNewLineItemBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'New Line Item')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpecialClassPropertyTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[19]/div[1]/div[1]/app-checkbox/div/mat-checkbox/label/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(DirectDamage)Lbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[20]/div[2]/app-line-items/app-utility-services/app-dropdown[1]/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(DirectDamage)Btn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Utility Services (Direct Damage) ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(DirectDamage)LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[20]/div[2]/app-line-items/app-utility-services/app-dropdown[1]/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(DirectDamage)LimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(DirectDamage)LimitAmountDrpDwnItems",
                PropertyType = "RelXPath",
                //PropertyValue1 = "//*[contains(text(),'here')]",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DirectDamageExcludeOverheadPowerLineLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='propertyCoveragesPage']/div[18]/div[2]/app-line-items/app-utility-services/app-dropdown[2]/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DirectDamageExcludeOverheadPowerLineDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|excludeOverheadPowerLine']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DirectDamageExcludeOverheadPowerLineDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(TimeElement)Lbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[2]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[20]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(TimeElement)Btn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Utility Services (Time Element) ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(TimeElement)LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[21]/div[2]/app-line-items[1]/app-utility-services[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(TimeElement)LimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UtilityServices(TimeElement)LimitAmountDrpDwnItens",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TimeElementExcludeOverheadPowerLineLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[2]/form/div/div/div/app-property-coverages/div/div/div[21]/div[2]/app-line-items/app-utility-services/app-dropdown[2]/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TimeElementExcludeOverheadPowerLineDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|excludeOverheadPowerLine']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TimeElementExcludeOverheadPowerLineDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterBackupandSumpOverFlowCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[2]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[21]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterBackupandSumpOverFlowCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Water Backup and Sump Overflow Coverage ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterBackupandSumpOverFlowCoverageLimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='propertyCoveragesPage']/div[20]/div[2]/app-line-items/app-limit-type-list/app-dropdown/div/label",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterBackupandSumpOverFlowCoverageDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|coverages||lineItemSection|lineItems|lineItem0|limitAmount']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterBackupandSumpOverFlowCoverageDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WindDrivenPreceptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[22]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WindDrivenPreceptionBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[1]/app-property-coverages[1]/div[1]/div[1]/div[22]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PreviousPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|location|coverages|prev']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyCoverageNextPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|location|propertyCoverages|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TypeBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SerialNumberBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[2]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[3]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CoverageAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[4]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ActionsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//th[contains(text(),'Actions')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|coverages|coverage22948|lineItemSection|lineItems|lineItem0|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DeleteBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|coverages|coverage22948|lineItemSection|lineItems|lineItem0|delete']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewLineItemBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|coverages|coverage22948|lineItemSection|addNewLineItem']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddExposureTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Add Exposure')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposureListLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Add Exposure')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposureListDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[3]/form[1]/div[1]/div[1]/div[1]/app-liabilities-exposure[1]/div[1]/div[1]/div[1]/div[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposureListDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[18]/div",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposureListDrpDwnItems2",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/div[1]/div[1]/mat-option[20]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposureListAddBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='exposurePage']/div/div/div[2]/app-button/button",
                //PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[3]/form[1]/div[1]/div[1]/div[1]/app-liabilities-exposure[1]/div[1]/div[1]/div[1]/div[1]/div[2]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PreviousBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|liabExpSection|prev']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LiabilityExposureNextBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[3]/form/div/div/div/app-liabilities-exposure/div/footer/div/div/div[2]/div/app-button/button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "VacantLandItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[26]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OfficeCoverageItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[16]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OfficeCoverageItemTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[3]/form/div/div/div/app-liabilities-exposure/div/div[2]/div/div/div[2]/app-line-items/app-area-sqft-type/app-dropdown/div/mat-form-field/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OfficeCoverageItemTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ParksAndPlaygroundTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ParksAndPlaygroundTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ParksAndPlaygroundSaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ParksAndPlaygroundDescribeBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|describe']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "VacantLandAreaLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[3]/form[1]/div[1]/div[1]/div[1]/app-liabilities-exposure[1]/div[1]/div[2]/div[1]/div[1]/div[2]/app-line-items[1]/app-area-acre-integer[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "VacantLandAreaTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|liabExpSection|liabExps|VACANTLAND|lineItemSection|lineItems|lineItem0|area']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RacquetBallAreaTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[3]/form/div/div/div/app-liabilities-exposure/div/div[2]/div/div/div[2]/app-line-items/app-area-sqft-integer/app-masked-input/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "7",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h5[@id='mat-dialog-title-2']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-multi-type-list-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[1]/div[1]/mat-option[2]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSalesTotalLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-multi-type-list-modal[1]/mat-dialog-content[1]/div[1]/form[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSalesTotalTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|salesTotal']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "5000",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageDiscardBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|discard']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExposuresAddedTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Exposures Added')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Open Storage Coverage')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSaveBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageDeleteBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|liabExpSection|liabExps|OPENSTORAGECOV|exposureName']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSalesTypeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|salesTotal']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenStorageCoverageSalesSavesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|liabExpSection|liabExps|lineItemEditable|save']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TypeBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SalesTotalBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[2]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Racquet/HandballAreaTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|liabExpSection|liabExps|RACQUETHANDBALLFACILITY|lineItemSection|lineItems|lineItem0|area']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "2500",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ActionsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//th[contains(text(),'Actions')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|liabExpSection|liabExps|OPENSTORAGECOV|lineItemSection|lineItems|lineItem0|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|liabExpSection|liabExps|OPENSTORAGECOV|lineItemSection|lineItems|lineItem0|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DeleteBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='locationSection|locations|location|liabExpSection|liabExps|OPENSTORAGECOV|lineItemSection|lineItems|lineItem0|delete']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewLineItemBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|liabExpSection|liabExps|OPENSTORAGECOV|lineItemSection|addNewLineItem']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingListTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Buildings List')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewBuildingBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|buildingSection|addNewBuilding']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PreviousBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|buildingSection|prev']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingListContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|buildingSection|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingDetailsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Building Details')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskDescriptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskDescriptionTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfStoriesDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "1StoryItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "2StoriesItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "3StoriesItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "//html/body/div[3]/div[2]/div/div/div/mat-option[3]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfStoriesDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "YearBuiltLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "YearBuiltBuildingTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|yearBuilt']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "2004",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SquareFeetLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SquareFeetBuildingTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|squareFeet']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "48158",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ConstructionTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ConstructionTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ConstructionTypeDrpDwnitems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[3]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofingMaterialLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofingMaterialDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[4]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofingMaterialDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpeningProtectionTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[5]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpeningProtectionTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='Opening Protection Type']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpeningProtectionTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectiveSafeguardsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[6]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectiveSafeguardYesNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectiveSafeguardYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|buildingSection|buildings|building|protectiveSafeguardSelection|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectiveSafeguardNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|buildingSection|buildings|building|protectiveSafeguardSelection|No']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProtectiveSafeguardsDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "%UsedforResidentialLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-masked-input[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "%UsedforResidentialTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[4]/form/div/div/div/app-buildings/div/div/form/div[2]/div[2]/div[1]/app-masked-input[3]/div/mat-form-field/div/div[1]/div[3]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingCodeGrade(BCEG)Lbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[7]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingCodeGrade(BCEG)DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='buildingCodeGrade']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingCodeGrade(BCEG)DrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingCodeGrade(BCEG)DrpDwnItem3",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[3]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingCodeGrade(BCEG)DrpDwnItem4",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[4]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsThisbuildingLessThan30%OccupiedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[1]/app-dropdown[8]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsThisbuildingLessThan30%OccupiedDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[3]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "IsThisbuildingLessThan30%OccupiedDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Hotel/MotelTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='hotelMotelType']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Hotel/MotelTypeDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[3]/div[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingLimitTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingCoverageLimit|buildingLimit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "4729100",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessPersonalPropertyLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[3]/div[1]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BusinessPersonalPropertyLimitTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingCoverageLimit|buildingPerPropLimit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "0",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingImprovementsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingImprovementsDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingImprovementsDrpDwnItemsYes",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BuildingImprovementsDrpDwnItemsNo",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WiringYearLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[2]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WiringYearTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingImprovements|wiringYear']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PlumbingYearLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[2]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PlumbingYearTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingImprovements|plumbingYear']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofingYearLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[2]/app-masked-input[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RoofingYearTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingImprovements|roofYear']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HeatingYearlbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[2]/app-masked-input[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HeatingYearTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingImprovements|heatingYear']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AirConditioningYearLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[4]/div[2]/app-masked-input[5]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AirConditioningYearTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|buildingImprovements|airConditionYear']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterMitigationVerificationFormCompletedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[5]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterMitigationVerificationFormCompletedDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[5]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "YearParkEsablishedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "YearParkEsablishedTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|yearParkEstablished']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PercentgeOfunpavedCommonStreetLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-masked-input[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PercentgeOfunpavedCommonStreetTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|perOfUnpavdCmmnSt']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllCommonStreetsLightedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[7]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllCommonStreetsLightedDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[3]/div[1]/app-dropdown[7]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllCommonStreetsLightedDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberOfCamperOrTentSitesTx",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|numOfCamperOrTentSites']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-radio[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|healthFitnessFacilities|provideGymOtherOrFitnessActivities|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DoesTheApplicantProvideAGymNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|healthFitnessFacilities|provideGymOtherOrFitnessActivities|No']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HealthFitnessTypeDropDown",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='healthFitnessType']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HealthFitnessTypeDropDownItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOfResidentilUnitsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOfResidentialUnitsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|glQuestions|sitesAndRentalUnits|totalResidentialUnits']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HowManyofThoseUnitsAreRentalsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-masked-input[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "HowManyofThoseUnitsAreRentalsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|glQuestions|sitesAndRentalUnits|rentalUnits']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOfSwimmingPools/Spaslbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-masked-input[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOfSwimmingPools/Spastxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|glQuestions|swimmingFacility|totalNoOfSwimmingPool']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DivingPlatformLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-radio[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DivingPlatformLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-radio[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DivingPlatformYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|swimmingFacility|divingPlatform|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DivingPlatformNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|swimmingFacility|divingPlatform|No']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SlideLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-radio[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SlideYesBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|swimmingFacility|slide|Yes']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SlideNoBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-radio-button[@id='locationSection|locations|location|glQuestions|swimmingFacility|slide|No']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOrRetentionPondsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/app-locations[1]/div[1]/div[1]/div[5]/div[1]/div[1]/div[2]/app-masked-input[4]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalNumberOrRetentionPondsTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|glQuestions|waterhazard|totalNumberOfPonds']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CancellationNoticeisToAppearLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Cancellation Notice is to Appear')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CancellationNoticeisToAppearDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CancellationNoticeisToAppearDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[2]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FormsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FormsDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[3]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FormsDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "WaterMitigationVerificationFormCompletedDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage1Btn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[1]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage1Lbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[1]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage12/3CombinedLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[2]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[2]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[2]/div[2]/app-line-items[1]/app-limit-type-list[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2ForDemolitionCostsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[2]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2ForDemolitionCostsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[2]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[3]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2ForDemolitionCostsSelectLimitDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[3]/div[2]/app-line-items[1]/app-ordinance-limit-amount[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionAndIncreasedCostOfConstructionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[2]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[4]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionAndIncreasedCostOfConstructionBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Ordinance/Law Coverage 2/3 Combined for Demolition and Increased Cost of Construction ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionSelectLimitDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|buildingSection|buildings|building|additionalCoverages|coverages||lineItemSection|lineItems|lineItem0|selectLimit']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionSelectLimitDrpDwn6322",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='locationSection|locations|location|buildingSection|buildings|building|additionalCoverages|coverages|coverage31251|lineItemSection|lineItems|lineItem0|selectLimit']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionSelectLimitDrpDwn7057",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[4]/form/div/div/div/app-buildings/div/div/form/div[2]/div[6]/div/div/div[4]/div[2]/app-line-items/app-ordinance-limit-amount/app-masked-input/div/mat-form-field/div/div[1]/div[4]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionSelectLimitDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-location-and-building/div[2]/div[2]/mat-horizontal-stepper/div[2]/div[4]/form/div/div/div/app-buildings/div/div/form/div[2]/div[6]/div/div/div[4]/div[2]/app-line-items/app-ordinance-limit-amount/app-masked-input/div/mat-form-field/div/div[1]/div[4]/input",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage2/3CombinedForDemolitionLimitAmountTxt6322",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='locationSection|locations|location|buildingSection|buildings|building|additionalCoverages|coverages|coverage31251|lineItemSection|lineItems|lineItem0|limitAmount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage3ForIncreasedCostofConstructionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[2]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Ordinace/LawCoverage3ForIncreasedCostofConstructionBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[2]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[5]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageCoverageLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[6]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageCoverageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Spoilage Coverage ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageLimitLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[6]/div[2]/app-line-items[1]/app-spoilage-coverage[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageLimitDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Spoilage Limit')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageLimitDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageDeductibleLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[6]/div[2]/app-line-items[1]/app-spoilage-coverage[1]/app-dropdown[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageDeductibleDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Spoilage Deductible')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageDeductibleDrpDwnItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SpoilageLimitDrpDwnItem50000",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[4]/span",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[6]/div[2]/app-line-items[1]/app-spoilage-coverage[1]/app-dropdown[3]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DescriptionDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[6]/div[2]/app-line-items[1]/app-spoilage-coverage[1]/app-dropdown[3]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ValuablePapersLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[7]/div[1]/div[1]/app-checkbox[1]/div[1]/mat-checkbox[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ValuablePapersBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),' Valuable Papers ')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LimitAmountLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-location-and-building[1]/div[2]/div[2]/mat-horizontal-stepper[1]/div[2]/div[4]/form[1]/div[1]/div[1]/div[1]/app-buildings[1]/div[1]/div[1]/form[1]/div[2]/div[6]/div[1]/div[1]/div[7]/div[2]/app-line-items[1]/app-limit-amount-text[1]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ValuablePapersLimitAmountTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@placeholder='Limit Amount']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "75000",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SaveBuildingBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|buildingSection|buildings|building|add']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DiscardBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|locations|location|buildingSection|buildings|building|cancel']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[3]/div[1]/div[3]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='page-container']/app-root/div[1]/main/div/app-quick-quote/div/app-quotedetails/div/div[2]/mat-card/mat-list/mat-list-item[3]/div/div[3]/div[2]/app-button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Step3AdditionalInterestBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='dropdownMenuButton']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Additional Interests')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewAdditionalInterestBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='addIntSection|addNewAddInt']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InterestTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InterestTypeDropDown",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InterestTypeDropDownItens",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LoanNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Loan Number')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LoanNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='addIntSection|addInts|addInt|loanNumber']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/app-text-field[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalIntNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='addIntSection|addInts|addInt|name']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/app-text-field[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalIntAddressTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='addIntSection|addInts|addInt|address']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Town/CityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/app-text-field[2]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Town/CityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='addIntSection|addInts|addInt|city']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/app-dropdown[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDropDown",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/app-dropdown[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDropDownItems",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html[1]/body[1]/div[3]/div[2]/div[1]/div[1]/div[1]/mat-option[12]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDropDownItemsTx",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipCodeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-additional-interest[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalZipCodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='addIntSection|addInts|addInt|zip']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SaveAdditionalInterestBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='addIntSection|addInts|addInt|add']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SelectLocationList",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[1]/app-root/div[1]/main/div/app-quick-quote/div/app-additional-interest/div/div/div/div/div[2]/div/form/app-multi-checkbox/div/div/div/mat-list/div[2]/div/mat-list-item/div/mat-checkbox/label/div",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestNextBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='page-container']/app-root/div[1]/main/div/app-quick-quote/div/app-additional-interest/div/div/div/div[2]/app-button",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsSection|additionalInterestSection|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalInterestCompletedImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[3]/div[1]/div[3]/div[2]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsAndBuildingsEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsSection|locationAndBuildingsSection|edit']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsAndBuildingsCompletedImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[2]/div[1]/div[3]/div[2]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[2]/div[1]/div[3]/div[2]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "/iv[1]/app-quotedetails[1]/div[1]v[3]/div[2]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SubmitForReviewBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='submitforReview']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GenerateQuoteLetterBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='generateQuoteLetter']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskPremiumLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Risk 12290 SAN JOSE BLVD JACKSONVILLE FL 32223 Pre')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RiskPremiumDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='riskPremium']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationPremiumDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='locationPremium']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Liability&ExposuresPremiumDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='liabilityExposures']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PropertyPremiumLocation1DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='propertyCoverages']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalBuilding1CoveragePremium-Location1DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalBuilding2CoveragesPremium-Location1DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[2]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalBuilding3CoveragesPremium-Location1DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[3]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalItemPremium-Location1DrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[@id='locationItems']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BasePremiumDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BasePremiumAdditionalCoveragesDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyFeesDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalFinalRaterOutputDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[5]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FormsAvailableTbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'No Forms Available')]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SummaryContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='summary|continue']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationPremiumEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/span[1]/app-icon[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalCoveragesEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[3]/div[1]/span[1]/app-icon[1]/a[1]/mat-icon[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AdditionalCoveragesEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-summary[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[3]/div[1]/span[1]/app-icon[1]/a[1]/mat-icon[1]",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddAnotherLocationBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='locationSection|addAnotherLocation']",
                ParentArea = "CommQuote",
                SubArea = "NewQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #endregion SubArea-NewQuote


            #region  SubArea-Location-PopUp
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-location-modal[1]/h2[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "LocationPopUp",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SuggestedLocationsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[3]/div[2]/div[1]/mat-dialog-container[1]/app-location-modal[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "LocationPopUp",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SuggestedAddressBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='suggested_candidateLocation0']",
                ParentArea = "CommQuote",
                SubArea = "LocationPopUp",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UseAsEnteredBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[contains(text(),'Use As Entered')]",
                ParentArea = "CommQuote",
                SubArea = "LocationPopUp",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocatiionsPopupWindow",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-dialog-container[@id='mat-dialog-0']",
                ParentArea = "CommQuote",
                SubArea = "LocationPopUp",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = "",
            });

            #endregion // SubArea-Location-PopUp

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewQuoteTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'New Quote')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskManagerBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//app-header-menu/div[1]/div[1]/div[1]/div[1]/ul[1]/li[4]/a[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            #region SubArea-TaskManager
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskManagerLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Task Manager')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskByLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Task by')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskByDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='kt_content']/div/div/div[2]/div[1]/div/div[1]/mat-form-field/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ForLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'For')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ForDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/div[2]/thig-task-filter-selection[1]/div[1]/div[2]/div[1]/mat-form-field[1]/div[1]/div[1]/div[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTaskBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[1]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTaskTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'New Tasks:')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTask#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[1]/mat-radio-button[1]/label[1]/div[2]/span[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTaskBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[1]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[2]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Open Tasks:')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasks#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[2]/mat-radio-button[1]/label[1]/div[2]/span[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[2]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalTaskBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[3]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalTask#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[3]/mat-radio-button[1]/label[1]/div[2]/span[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalTaskBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[1]/app-task-list-summary[1]/ul[1]/mat-radio-group[1]/li[3]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GoToTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Go To:')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GoToDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-task-manager-page[1]/div[1]/div[1]/div[1]/app-task-view-table[1]/div[1]/div[1]/div[2]/div[1]/div[2]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BatchReassignBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='batchReassign']",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExportToExcelBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='export']",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RefreshBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//a[@id='refresh']",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RecordsToDisplayTbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'No records to display.')]",
                ParentArea = "CommQuote",
                SubArea = "TaskManager",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #endregion SubArea-TaskManager

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskManagerTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Task Manager')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskListBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskListTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h6[contains(text(),'Task List')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskFilloutBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskByTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Task By')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskByDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyCodeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Agency Code')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyCodeEntry",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[2]/app-auto-complete[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NumberofTaskbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[3]/ul[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTasksbckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[3]/ul[1]/li[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTasksLBL",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'New Tasks:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTasks#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[3]/ul[1]/li[1]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Open Tasks:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasks#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[3]/ul[1]/li[2]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalTaskLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Total Tasks:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TotalTask#Txt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[3]/ul[1]/li[3]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTasksBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NewTaskLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[1]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OpenTasksLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[2]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllNonClosedTaskBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[3]/label[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AllNonClosedTasksLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[5]/mat-radio-group[1]/mat-radio-button[3]/label[1]/div[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GoToLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Go To:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "GoToDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[6]/div[2]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "BatchReassignBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='batchReassign']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExportToExcelBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='export']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RefreshBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-icon[contains(text(),'refresh')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExportToExcelBatchReassignBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-tasklist[1]/div[1]/div[1]/div[1]/div[2]/div[4]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RecordDisplayWindow",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'No records to display.')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteListHeader",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteListLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h3[contains(text(),'Quote List')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SearchBar",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quickSearchField']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteListTbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExtendDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/button[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            #region SubArea-ExtendDpDwn
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicyNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Quote/Policy Number')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicyNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|quoteNumber']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "policyEffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Policy Effective Date')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "policyEffectiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|policyEffectiveDate']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "policyEffectiveDateCalendarBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/app-date-picker[1]/div[1]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmailLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Email')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EmailTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|email']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SearchBar",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quickSearchField']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PrimaryPhoneNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[4]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });


            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PrimaryPhoneNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|primaryPhoneNumber']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PrimaryPhoneNumberBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[4]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PrimaryPhoneNumberImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-icon[contains(text(),'phone')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerNameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Customer Name')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|customerName']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerNameBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[5]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerDBALbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Customer DBA')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerDBATxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|customerDba']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerDBABckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[6]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicySatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Quote/Policy Status')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicySatusDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[7]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Address')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|address']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AddressBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[8]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CityLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'City')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CityTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|city']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });
            
            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CityBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[9]/app-text-field[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'State')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[10]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipcodeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[11]/app-masked-input[1]/div[1]/label[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipcodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//input[@id='quoteSearch|zipCode']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ZipcodeBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[11]/app-masked-input[1]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SubmissionStatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//label[contains(text(),'Submission Status')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SubmissionStatusDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[12]/div[1]/mat-form-field[1]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ArchivedQuote/PolicyBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[13]/mat-checkbox[1]/label[1]/div[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ArchivedQuote/PolicyTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[13]/mat-checkbox[1]/label[1]/span[1]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SearchBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[contains(text(),'Search')]",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "RestBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='reset']",
                ParentArea = "CommQuote",
                SubArea = "ExtendDrpDwn",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #endregion SubArea-ExtendDrpDwn

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicyNumberBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "Quote/PolicyNumberLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Quote/Policy Number')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerNameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Customer Name')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CustomerNameBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[2]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Effective Date')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[3]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'State')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StateBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[4]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Product')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[5]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[6]/div[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "StatusBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[6]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Agency')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[7]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SubmissionStatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Submission Status')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SubmissionStatusBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//thead/tr[1]/th[8]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ActionsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//th[contains(text(),'Actions')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LastPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[4]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LastPageImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[4]/span[1]/*[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NextPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[3]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "NextPageImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[3]/span[1]/*[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PreviousPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PreviousPageImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[2]/span[1]/*[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FirstPageBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "FirstPageImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-home[1]/app-quotelist[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/mat-paginator[1]/div[1]/div[1]/div[1]/button[1]/span[1]/*[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TowerHillFooter",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/div[2]/app-footer[1]/footer[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TowerHillFooterImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/div[2]/app-footer[1]/footer[1]/div[1]/img[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TowerHillcopyright",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/div[2]/app-footer[1]/footer[1]/div[1]/div[1]/div[1]/div[2]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LooktothetowerLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//em[contains(text(),'Look to the Tower.®')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "DateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Date: Wed Jan 27 2021 15:24:39 GMT-0500 (Eastern S')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "SessionLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//div[contains(text(),'Session: ecdbe61e-c5f3-4b3b-a891-bc847e76c4fa')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoTeNumberTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='page-container']/app-root/div[1]/main/div/app-quick-quote/div/app-initial-qualifier/header/div[1]/div[2]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UnderwritingBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteNavig|underwriting']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InsuredNameLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Insured Name:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "InsuredNameTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Functional Co-1')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UnderwriterLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Underwriter:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UnderwriterTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'----')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Effective Date:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EffectiveDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'01/28/2021')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Expiration Date:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExpirationDateTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'01/28/2022')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyCodeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Agency Code:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "AgencyCodeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/div[1]/ul[1]/li[6]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "UwTeamContactsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quote|uwContactsSectionOpen']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "XMLDBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='xmlMenu']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteNavig|edit']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Product Type:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Business Owners Policy')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeDrpDwn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[@id='productType']/div/div[1]/div[3]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeDrpDwnItemBusOwner",
                PropertyType = "RelXPath",
                PropertyValue1 = "/html/body/div[3]/div[2]/div/div/div/mat-option[1]/span",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProductTypeDrpDwnItem",
                PropertyType = "RelXPath",
                PropertyValue1 = "//*[contains(text(),'here')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProgramTypeLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Program Type:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ProgramTypeTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Office/Retail')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyStatusLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Policy Status:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyStatusTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'OPEN')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyStatusEditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//mat-icon[contains(text(),'edit')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CreatedByLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Created By:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CreatedByTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'TESTAUTOMATION1@THIG')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CarrierLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Carrier:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CarrierTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Tower Hill Prime')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//span[contains(text(),'Premium:')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/ul[1]/li[8]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaxesAndFeesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/ul[1]/li[9]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaxesAndFeesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/ul[1]/li[9]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumInclTaxesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/ul[1]/li[10]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PremiumInclTaxesTxt",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]/div[2]/ul[1]/li[10]/span[2]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteNumberInfoBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[1]/mat-card[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "QuoteDetailsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h4[contains(text(),'Quote Details')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ContactUsBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteNavig|contactUs']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CloneBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteNavig|clone']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TaskBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='policyTasks']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ExitBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteNavig|exit']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoveragesBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[1]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "PolicyCoveragesLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h3[contains(text(),'Policy Coverages')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsSection|policyAndCoveragesSection|continue']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "OneImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[1]/div[1]/div[3]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "CheckMarkImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[1]/div[1]/div[3]/div[2]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "EditBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsSection|policyAndCoveragesSection|edit']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsAndBuildingsLbl",
                PropertyType = "RelXPath",
                PropertyValue1 = "//h3[contains(text(),'Locations and Buildings')]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "TwoImg",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[2]/div[1]/div[3]/div[1]/span[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "ContinueBtn",
                PropertyType = "RelXPath",
                PropertyValue1 = "//button[@id='quoteDetailsSection|locationAndBuildingsSection|continue']",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            NextGenCommQuoteControlsList.Add(new WorkflowObjects()
            {
                Description = "LocationsAndBuildingBckgrd",
                PropertyType = "RelXPath",
                PropertyValue1 = "//body/div[@id='page-container']/app-root[1]/div[1]/main[1]/div[1]/app-quick-quote[1]/div[1]/app-quotedetails[1]/div[1]/div[2]/mat-card[1]/mat-list[1]/mat-list-item[2]/div[1]",
                ParentArea = "CommQuote",
                SelectedItem = "",
                EnteredText = "",
                IsSelected = "",
                TypeString = "",
                URL = ""
            });

            #region Sub Items

            //    NextGenTemplateControls.Add(new WorkflowObjects()
            //    {
            //        Description = "AcctLifecycleAccts",
            //        ControlType = "Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlHyperlink, Microsoft.VisualStudio.TestTools.UITesting, Version = 15.0.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a",
            //        PropertyType = "InnerText",
            //        PropertyValue1 = "  Accounts   ",
            //        PropertyValue2 = "",
            //        SelectedItem = "",
            //        EnteredText = "",
            //        IsSelected = "",
            //        TypeString = "",
            //        URL = ""
            //    }); //AcctLifecycleAccts

            #endregion Sub Items

            #endregion  ### & Sub Items

            return NextGenCommQuoteControlsList;
        }
    }
}