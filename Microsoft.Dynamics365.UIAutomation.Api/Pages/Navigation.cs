// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Microsoft.Dynamics365.UIAutomation.Api
{

    /// <summary>
    ///  The Xrm Navigation page.
    ///  </summary>
    public class Navigation
        : XrmPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public Navigation(InteractiveBrowser browser)
            : base(browser)
        {
            SwitchToDefault();
        }

        /// <summary>
        /// Global Search
        /// </summary>
        /// <param name="searchText">The SearchText</param>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.GlobalSearch("Contoso");</example>
        public BrowserCommandResult<bool> GlobalSearch(string searchText, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Global Search: {searchText}"), driver =>
            {
                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.SearchButton]),
                    new TimeSpan(0, 0, 5),
                    "The Global Search button is not available.");

                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.SearchLabel]), TimeSpan.FromSeconds(1));

                driver.WaitUntilClickable(By.XPath(Elements.Xpath[Reference.Navigation.Search]),
                    new TimeSpan(0, 0, 5),
                    e =>
                    {
                        e.SendKeys(searchText, true);
                        Browser.ThinkTime(500);
                        e.SendKeys(Keys.Enter);
                    },
                    "The Global Search text field is not available."
                    );

                return true;
            });
        }

        /// <summary>
        /// Opens About from navigation bar
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenAbout();</example>
        public BrowserCommandResult<bool> OpenAbout(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open About"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.About]);

                return true;
            });
        }

        /// <summary>
        /// Opens the Admin Portal
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenAdminPortal();</example>
        public BrowserCommandResult<bool> OpenAdminPortal(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Admin Portal"), driver =>
            {
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.AdminPortal]))?.Click();

                return true;
            });
        }

        /// <summary>
        /// Open the Advanced Find
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenAdvancedFind();</example>
        public BrowserCommandResult<bool> OpenAdvancedFind(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Advanced Find"), driver =>
            {
                //Narrow down the scope to the Search Tab when looking for the search input
                var navBar = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.AdvFindSearch]));

                navBar.FindElement(By.ClassName("navTabButtonLink")).Click();

                return true;
            });
        }

        /// <summary>
        /// Open Apps for Dynamics
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenAppsForDynamicsCRM();</example>
        public BrowserCommandResult<bool> OpenAppsForDynamicsCRM(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Apps for Dynamics"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.AppsForCRM]);

                return true;
            });
        }

        /// <summary>
        /// Opens the Guided Help
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenGuidedHelp();</example>
        public BrowserCommandResult<bool> OpenGuidedHelp(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Guided Help"), driver =>
            {
                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.GuidedHelp]));

                return true;
            });
        }

        public BrowserCommandResult<bool> OpenHomePage(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            //TODO: Implement HomePage logic
            throw new NotImplementedException();
        }

        public BrowserCommandResult<bool> NavigateToLeadsPage(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            return this.Execute("Leads", driver =>
            {
                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.Navigation.Leads]));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Navigation.Leads]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.Leads])).Click();
                driver.WaitForPageToLoad();
                return true;
            });
        }

        public BrowserCommandResult<bool> NavigateToEmployersPage(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            return this.Execute("Employers", driver =>
            {
                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.Navigation.Employers]));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Navigation.Employers]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.Employers])).Click();
                driver.WaitForPageToLoad();
                return true;
            });
        }

        public BrowserCommandResult<bool> NavigateToJobOrdersPage(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            return this.Execute("JobOrders", driver =>
            {
                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.Navigation.JobOrders]));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Navigation.JobOrders]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.JobOrders])).Click();
                driver.WaitForPageToLoad();
                return true;
            });
        }

        public BrowserCommandResult<bool> NavigateToNewForm(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            this.Execute("Form", driver =>
            {
                Thread.Sleep(3000);
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.CommandBar.NewButton]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.CommandBar.NewButton])).Click();
                driver.WaitForPageToLoad();
                Browser.ThinkTime(thinkTime);
                return true;
            });
            return true;
        }

        public BrowserCommandResult<bool> NavigateToUMAApp(int thinkTime = Constants.DefaultThinkTime)
        {
            this.Execute("App", driver =>
            {
                Browser.ThinkTime(thinkTime);
                driver.SwitchTo().Frame(driver.FindElement(By.Id("AppLandingPage")));
                driver.FindElement(By.Id("app-search-input")).Click();
                driver.FindElement(By.Id("app-search-input")).SendKeys("UMA");
                driver.FindElement(By.Id("app-search-input")).SendKeys(Keys.Tab);
                Browser.ThinkTime(thinkTime);
                driver.FindElement(By.XPath("//div[text()='UMA']")).Click();
                driver.WaitForPageToLoad();
                Browser.ThinkTime(thinkTime);
                return true;
            });
            return true;
        }

        public String employerName;

        public String FillCADAccountFormAndSave(int thinkTime = Constants.DefaultThinkTime)
        {
            string employerName = string.Empty;
            Browser.ThinkTime(thinkTime);
            Random rand = new Random();
            int num = rand.Next(10000, 100000);
            this.Execute("Employers", driver =>
            {
                Browser.ThinkTime(1000);
                // Fill form data 
                String xpath = Elements.Xpath[Reference.Entity.FormTxtField];
                employerName = "Employer_" + num;
                Thread.Sleep(1000);
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Employers Name")), employerName, TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Phone")), "12312" + num, TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Address 1: Street Address/P.O. Box")), "123 New Ste", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "City")), "San Antonio", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "State")), "Texas", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "ZIP")), "78234", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Country/Region")), "USA", TimeSpan.FromSeconds(2));
                driver.FindElement(By.XPath(xpath)).Click();
                // All Drop Downs
                xpath = Elements.Xpath[Reference.Entity.FormDDField];
                Thread.Sleep(500);
                var e = driver.FindElement(By.XPath(xpath));
                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "Account Type")), "CAD", TimeSpan.FromSeconds(2));
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "CAD Type")), "Premier", TimeSpan.FromSeconds(2));
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "Employment Type")), "Work From Home", TimeSpan.FromSeconds(2));
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "Types of Position the Office Hires For")), "Admin", TimeSpan.FromSeconds(2));
                // LookUp Fields
                driver.FindElement(By.XPath("//input[contains(@aria-label,'National Director')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//input[contains(@aria-label,'National Director')]")).SendKeys("a", true);
                Thread.Sleep(1000);
                driver.Inivisibility(By.XPath("//label[text()='Loading...']"), 30);
                driver.Click(driver.FindElement(By.XPath("(//ul[contains(@aria-label,'Lookup Search Results')]/li)[1]")));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save])).Click();
                Browser.ThinkTime(5000);
                return true;
            });
            return employerName;
        }

        public String FillPBIAccountFormAndSave(int thinkTime = Constants.DefaultThinkTime)
        {
            string employerName = string.Empty;
            Browser.ThinkTime(thinkTime);
            Random rand = new Random();
            int num = rand.Next(10000, 100000);
            this.Execute("Employers", driver =>
            {
                Browser.ThinkTime(1000);
                // Fill form data 
                String xpath = Elements.Xpath[Reference.Entity.FormTxtField];
                employerName = "Employer_" + num;
                Thread.Sleep(1000);
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Employers Name")), employerName, TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Phone")), "12345" + num, TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Address 1: Street Address/P.O. Box")), "123 New St", TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "City")), "San Antonio", TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "State")), "Texas", TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "ZIP")), "78234", TimeSpan.FromSeconds(1));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Country/Region")), "USA", TimeSpan.FromSeconds(1));
                // All Drop Downs
                xpath = Elements.Xpath[Reference.Entity.FormDDField];

                driver.ClickWhenAvailable(By.XPath(xpath.Replace("[NAME]", "Employment Type")));
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "Employment Type")), "Work From Home", TimeSpan.FromSeconds(2));
                driver.ClickWhenAvailable(By.XPath(xpath.Replace("[NAME]", "Types of Position the Office Hires For")));
                driver.SelectDropDownValue(By.XPath(xpath.Replace("[NAME]", "Types of Position the Office Hires For")), "Admin", TimeSpan.FromSeconds(2));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save])).Click();
                Browser.ThinkTime(5000);
                return true;
            });
            return employerName;
        }

        public BrowserCommandResult<bool> Logout()
        {
            this.Execute("Employers", driver =>
            {
                Browser.ThinkTime(3000);
                driver.WaitUntilVisible(By.XPath("//button[contains(@title, 'User Information')]"));
                driver.FindElement(By.XPath("//button[contains(@title, 'User Information')]")).Click();
                Browser.ThinkTime(2000);
                driver.WaitForPageToLoad();
                return true;
            });
            return true;
        }

        public BrowserCommandResult<bool> ValidateTextFromGrid(String textToVerify)
        {
            this.Execute("Grid", driver =>
            {
                Browser.ThinkTime(3000);
                var e = driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Txt_QuickFind]));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", e);
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Txt_QuickFind]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Txt_QuickFind])).Click();
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Txt_QuickFind])).SendKeys(textToVerify);
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Txt_QuickFind])).SendKeys(Keys.Enter);
                Browser.ThinkTime(1000);
                driver.FindElement(By.XPath($"//*[normalize-space(text())='{textToVerify.Trim()}']")).Displayed.Should().BeTrue(textToVerify+" element not displayed");
                //textToVerify.Should().Contain("Pradeep", textToVerify + " is not matched");
                return true;
            });
            return true;
        }

        /// <summary>
        /// Opens the Menu
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        public BrowserCommandResult<Dictionary<string, IWebElement>> OpenMenu(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions("Open Menu Menu"), driver =>
            {
                var dictionary = new Dictionary<string, IWebElement>();

                driver.WaitUntilAvailable(By.ClassName(Elements.CssClass[Reference.Navigation.TopLevelItem]));

                var topItem = driver.FindElements(By.ClassName(Elements.CssClass[Reference.Navigation.TopLevelItem])).FirstOrDefault();
                topItem?.FindElement(By.Name(Elements.Name[Reference.Navigation.HomeTab])).Click();

                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Navigation.Employers]));

                var element = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.Employers]));
                var subItems = element.FindElements(By.ClassName(Elements.CssClass[Reference.Navigation.ActionButtonContainer]));

                foreach (var subItem in subItems)
                {
                    dictionary.Add(subItem.GetAttribute("title").ToLowerString(), subItem);
                }

                return dictionary;
            });
        }

        public BrowserCommandResult<List<Link>> OpenMruMenu(int thinkTime = Constants.DefaultThinkTime)
        {
            return this.Execute(GetOptions("Open MRU Menu"), driver =>
            {
                var list = new List<Link>();

                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.TabGlobalMruNode]));


                var navContainer = driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Navigation.Shuffle]));
                var links = navContainer.FindElements(By.TagName("a"));

                foreach (var link in links)
                {
                    if (!string.IsNullOrEmpty(link.Text))
                    {
                        var newItem = new Link
                        {
                            Uri = new Uri(link.GetAttribute("href"))
                        };
                        newItem.PageType = newItem.Uri.ToPageType();
                        newItem.LinkText = link.Text;

                        list.Add(newItem);
                    }
                }

                return list;
            });
        }

        /// <summary>
        /// Opens the Options
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenOptions();</example>
        public BrowserCommandResult<bool> OpenOptions(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Options"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.Options]);

                return true;
            });
        }

        /// <summary>
        /// Opens OptOut Learning Path
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenOptOutLearningPath();</example>
        public BrowserCommandResult<bool> OpenOptOutLearningPath(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Opt out of Learning Path"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.OptOutLP]);

                return true;
            });
        }

        /// <summary>
        /// Opens the Print Preview
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenPrintPreview();</example>
        public BrowserCommandResult<bool> OpenPrintPreview(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open PrintPreview"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.PrintPreview]);

                return true;
            });
        }

        /// <summary>
        /// Opens the Privacy Statement
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenPrivacyStatement();</example>
        public BrowserCommandResult<bool> OpenPrivacyStatement(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Privacy Statement"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.Privacy]);

                return true;
            });
        }

        /// <summary>
        /// Opens the Related Menu
        /// </summary>
        /// <param name="relatedArea">The Related area</param>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenRelated("Cases");</example>
        public BrowserCommandResult<bool> OpenRelated(string relatedArea, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions("Open Related Menu"), driver =>
            {
                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.TabNode]));

                var element = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.ActionGroup]));
                var subItems = element.FindElements(By.ClassName("nav-rowBody"));

                var related = subItems.Where(x => x.Text == relatedArea).FirstOrDefault();
                if (related == null)
                {
                    throw new InvalidOperationException($"No relatedarea with the name '{relatedArea}' exists.");
                }

                Browser.ActiveFrameId = related.GetAttribute("id").Replace("Node_nav", "area");
                related?.Click();

                return true;
            });
        }

        private static void OpenSettingsOption(IWebDriver driver, string settingPath)
        {
            driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.Settings]));
            Thread.Sleep(1000);

            //Bug: 563823 
            //Issue with CRM Style where the Options menu is not visible in IE. Works in Chrome but going to set the style to Display: Block so that we can click it.  
            driver.SetVisible(By.XPath(settingPath), true);
            //End bug fix

            driver.WaitUntilVisible(By.XPath(settingPath));
            driver.ClickWhenAvailable(By.XPath(settingPath));
        }

        /// <summary>
        /// Opens the Sub Area
        /// </summary>
        /// <param name="area">The area you want to open</param>
        /// <param name="subArea">The subarea you want to open</param>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenSubArea("Sales", "Opportunities");</example>
        public BrowserCommandResult<bool> OpenSubArea(string area, string subArea, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($": {area} > {subArea}"), driver =>
            {
                area = area.ToLower();
                subArea = subArea.ToLower();

                var areas = OpenMenu().Value;

                if (!areas.ContainsKey(area))
                {
                    throw new InvalidOperationException($"No area with the name '{area}' exists.");
                }

                var subAreas = OpenSubMenu(areas[area]).Value;

                if (!subAreas.Any(x => x.Key == subArea))
                {
                    throw new InvalidOperationException($"No subarea with the name '{subArea}' exists inside of '{area}'.");
                }

                subAreas.FirstOrDefault(x => x.Key == subArea).Value.Click(true);

                SwitchToContent();
                driver.WaitForPageToLoad();

                return true;
            });
        }

        internal BrowserCommandResult<List<KeyValuePair<string, IWebElement>>> OpenSubMenu(IWebElement area)
        {
            return this.Execute(GetOptions($"Open Sub Menu: {area}"), driver =>
            {
                var list = new List<KeyValuePair<string, IWebElement>>();

                driver.WaitUntilVisible(By.Id(area.GetAttribute("Id")));

                area.Click();

                Thread.Sleep(1000);

                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.Navigation.SubActionGroupContainer]));

                var subNavElement = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.SubActionGroupContainer]));

                var subItems = subNavElement.FindElements(By.ClassName(Elements.CssClass[Reference.Navigation.SubActionElementClass]));

                foreach (var subItem in subItems)
                {
                    if (!string.IsNullOrEmpty(subItem.Text))
                        list.Add(new KeyValuePair<string, IWebElement>(subItem.Text.ToLowerString(), subItem));
                }

                return list;
            });
        }

        /// <summary>
        /// Opens Welcome Screen from navigation bar
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.OpenWelcomeScreen();</example>
        public BrowserCommandResult<bool> OpenWelcomeScreen(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Welcome Screen"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.WelcomeScreen]);

                return true;
            });
        }

        /// <summary>
        /// Open Quick Create
        /// </summary>
        /// <param name="entity">The entity name</param>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.QuickCreate("Account");</example>
        public BrowserCommandResult<bool> QuickCreate(string entity, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open Quick Create"), driver =>
            {
                driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.GlobalCreate]));

                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.QuickCreate.EntityContainer]), new TimeSpan(0, 0, 2));

                var area = driver.FindElement(By.XPath(Elements.Xpath[Reference.QuickCreate.EntityContainer]));
                var items = area.FindElements(By.TagName("a"));

                var item = items.FirstOrDefault(x => x.Text == entity);

                if (item == null)
                {
                    throw new InvalidOperationException($"No Entity with the name '{entity}' exists inside QuickCreate.");
                }

                item.Click(true);

                driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.QuickCreate.Container]));

                return true;
            });
        }

        /// <summary>
        /// Opens About from navigation bar
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.RetrieveServerVersion();</example>
        public BrowserCommandResult<string> RetrieveServerVersion(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Open About"), driver =>
            {
                OpenSettingsOption(driver, Elements.Xpath[Reference.Navigation.About]);

                driver.LastWindow().SwitchTo().ActiveElement();

                var versionElement = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.AboutVersionText]));
                var listedVersions = versionElement.FindElements(By.TagName("bdo"));

                var serverVersion = listedVersions[1].Text.ToString().TrimStart('(').TrimEnd(')');

                return serverVersion;
            });
        }

        /// <summary>
        /// Retrieves a Dictionary containing all of the Areas on the main menu
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.GetAreas();</example>

        public BrowserCommandResult<Dictionary<string, IWebElement>> GetAreas(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Get Areas"), driver =>
            {
                var areas = OpenMenu().Value;

                driver.WaitForPageToLoad();

                return areas;
            });
        }

        /// <summary>
        /// Retrieves a list of the sub areas within a specified area
        /// </summary>
        /// <param name="area">The area whose subareas you want to check</param>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.GetSubAreas("Sales"); - returns all of the subareas in the Sales area</example>
        public BrowserCommandResult<List<KeyValuePair<string, IWebElement>>> GetSubAreas(string area, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions($"Get SubAreas"), driver =>
            {
                area = area.ToLower();

                var areas = OpenMenu().Value;

                if (!areas.ContainsKey(area))
                {
                    throw new InvalidOperationException($"No area with the name '{area}' exists.");
                }

                var subAreas = OpenSubMenu(areas[area]).Value;

                return subAreas;
            });
        }

        /// <summary>
        /// SignOut
        /// </summary>
        /// <param name="thinkTime">Used to simulate a wait time between human interactions. The Default is 2 seconds.</param>
        /// <example>xrmBrowser.Navigation.SignOut();</example>
        public BrowserCommandResult<bool> SignOut(int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            return this.Execute(GetOptions($"SignOut"), driver =>
            {
                //driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.UserInfo]));
                driver.ClickWhenAvailable(By.Id("mectrl_headerPicture"));
                Browser.ThinkTime(1000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("(//*[normalize-space(text())='Sign out']) | (//span[normalize-space(text())='Sign out']/../..)")));
                Browser.ThinkTime(2000);
                //driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.SignOut]));
                return true;
            });
        }

        public BrowserCommandResult<bool> OpenApp(string appName, int thinkTime = Constants.DefaultThinkTime)
        {
            this.Browser.ThinkTime(thinkTime);

            return this.Execute(GetOptions("Open App"), driver =>
            {
                driver.SwitchTo().DefaultContent();

                if (driver.HasElement(By.XPath(Elements.Xpath[Reference.Navigation.OpenAppTabDivider])))
                {
                    driver.ClickWhenAvailable(By.XPath(Elements.Xpath[Reference.Navigation.OpenAppTabDivider]));

                    var container = driver.FindElement(By.XPath(Elements.Xpath[Reference.Navigation.OpenAppContainer]));

                    var buttons = container.FindElements(By.TagName("button"));

                    var button = buttons.FirstOrDefault(x => x.Text.Trim() == appName);

                    if (button != null)
                        button.Click(true);
                    else
                        throw new InvalidOperationException($"App Name {appName} not found.");

                    driver.WaitUntilVisible(By.XPath(Elements.Xpath[Reference.Login.CrmMainPage]),
                                                TimeSpan.FromSeconds(60),
                                                e =>
                                                {
                                                    driver.WaitForPageToLoad();
                                                    driver.SwitchTo().Frame(0);
                                                    driver.WaitForPageToLoad();
                                                },
                                                "App Load failed."
                                                );
                }

                return true;
            });
        }
    }
}