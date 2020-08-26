﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public sealed class Hooks : TechTalk.SpecFlow.Steps
    {
        private static ExtentReports _extent;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static string htmlFile;

        private readonly ScenarioContext scenarioContext;
        static new FeatureContext FeatureContext { get; set; }
        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }


        [BeforeTestRun]
        public static void InitializeReport()
        {
            //var HtmlBaseDirectory = Path.Combine((new FileInfo(AppDomain.CurrentDomain.BaseDirectory).Directory.Parent).Parent.FullName, "Reports");
           var  folderLocation = Path.Combine(new FileInfo(AppDomain.CurrentDomain.BaseDirectory).Directory.Parent.FullName, "Reports", "Log_" + DateTime.Now.ToString("MM_dd_yyyy"));
            if (!Directory.Exists(folderLocation))
                Directory.CreateDirectory(folderLocation);          
            htmlFile = Path.Combine(folderLocation, "Reports", "index.html");

            var htmlReporter = new ExtentHtmlReporter(htmlFile);
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Config.JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";
            //Attach report to reporter
            _extent = new ExtentReports();
            _extent.AddSystemInfo("Host Name", Environment.MachineName);
            _extent.AddSystemInfo("User Name", Environment.UserName);
            _extent.AttachReporter(htmlReporter);
         
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            _extent.Flush();
            using (var a = Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", $"file:///{htmlFile}"))
            { }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            FeatureContext = featureContext;
            string title = FeatureContext.FeatureInfo.Title;
            featureName = _extent.CreateTest<Feature>(title);

        }

        [BeforeScenario]
        public void BeforeScenario()
        { 
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);           
        }

        [AfterScenario]
        public void AfterScenario()
        {
           var B =  scenarioContext.Get<Api.Browser>("browser");
            B.Dispose();
        }

        [AfterStep]
        public void LogStepResult()
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepDesc = scenarioContext.StepContext.StepInfo.Text.ToString();
            if(scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(stepDesc);
                else if (stepType == "When")
                    scenario.CreateNode<When>(stepDesc);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(stepDesc);
                else if (stepType == "And")
                    scenario.CreateNode<And>(stepDesc);
            }
            else
            {
                string errorMessage = scenarioContext.TestError.Message;
                    if (stepType == "Given")
                    scenario.CreateNode<Given>(stepDesc).Fail(errorMessage);
                else if (stepType == "When")
                    scenario.CreateNode<When>(stepDesc).Fail(errorMessage);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(stepDesc).Fail(errorMessage);
                else if (stepType == "And")
                    scenario.CreateNode<And>(stepDesc).Fail(errorMessage);
            }
        }
    }
}
