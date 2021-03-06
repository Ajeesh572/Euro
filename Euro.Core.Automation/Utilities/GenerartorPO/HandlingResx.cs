﻿// <copyright file="HandlingResx.cs" company="Eurofins">
// Copyright (c) Euro. All rights reserved.
// </copyright>
namespace Euro.Core.Automation.Utilities.GeneratePO
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class to handle the resx files generated by page objects.
    /// </summary>
    public class HandlingResx
    {
        private const string PagesPath = "Main\\\\UI\\\\Pages\\\\";
        private ComponentStorage ListStorage;
        private string FindByDeclarations;
        private string PageMethods;
        private IDictionary ResourceSet;
        private string NameLocator;
        private string NameSpace;

        /// <summary>
        /// Initializes a new instance of the <see cref="HandlingResx"/> class.
        /// </summary>
        /// <param name="nameLocator">name of locator that contains the rex file</param>
        public HandlingResx(string nameLocator)
        {
            this.ListStorage = new ComponentStorage();
            this.NameSpace = string.Format("{0}.Main.Resources.Locators", this.GetProjectNameSpace());
            this.NameLocator = nameLocator;
            this.FindByDeclarations = string.Empty;
            this.PageMethods = string.Empty;
            this.ResourceSet = ResourceReader.GetList(nameLocator);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandlingResx"/> class.
        /// </summary>
        public HandlingResx()
        {
            this.ListStorage = new ComponentStorage();
        }

        /// <summary>
        /// Build the structure of the class with all its components
        /// </summary>
        /// <returns>A string with class information</returns>
        public string GetPage()
        {
            string AddHead = this.BuildHeader();
            string AddClose = BuildFooting();
            string Page = string.Empty;
            foreach (DictionaryEntry entry in this.ResourceSet)
            {
                string prefix = string.Empty;
                string resourceKey = entry.Key.ToString();
                prefix = Regex.Split(resourceKey, "(\\B[A-Z])")[0];
                this.BuildBody(prefix, resourceKey);
            }

            Page = AddHead + this.FindByDeclarations + this.PageMethods + AddClose;
            this.CreateFile(Page);
            return Page;
        }

        /// <summary>
        /// Finish class structure
        /// </summary>
        /// <returns>A string with the end of the class</returns>
        private static string BuildFooting()
        {
            string AddClose = "@  }@}";
            return AddClose.Replace("@", System.Environment.NewLine);
        }

        /// <summary>
        /// Build the header with the respective using
        /// </summary>
        /// <returns>A string with the information of the class header</returns>
        private string BuildHeader()
        {
            string AddUsing = "using Euro.Core.Automation.Utilities.CommonAction;@using Euro.Core.Automation.Selenium;@using OpenQA.Selenium;@";
            string AddNameSpace = string.Format("@namespace {0}.Main.UI.Pages@{{", this.GetProjectNameSpace());
            string AddNameClass = string.Format("@  public class {0}@  {{", this.NameLocator.Replace("Locators", "Page"));
            string file = string.Format("@    const string file = \"{0}\";@", this.NameLocator);
            string AddHead = AddUsing + AddNameSpace + AddNameClass + file;
            return AddHead.Replace("@", System.Environment.NewLine);
        }

        /// <summary>
        /// Create the body of the class with the IWebElement and the methods that handle them
        /// </summary>
        /// <param name="prefix">prefix to operate the name</param>
        /// <param name="resourceKey">to build methods</param>
        private void BuildBody(string prefix, string resourceKey)
        {
            string comment = "@    /// <summary>@    /// To Do...@    /// </summary>@    /// <param name=\"{2}\"></param>";
            string method = "@    public {0} {1}(string {2})@    {{@      CommonActions.{3}({4}, {2});@    }}@";
            string parameter = resourceKey.Remove(0, prefix.Length);
            parameter = parameter.Substring(0, 1).ToLower() + parameter.Remove(0, 1);
            this.FindByDeclarations += string.Format("@    [IDTFindBy(File = file, Locator = \"{0}\")]@    private IWebElement {0};@", resourceKey);
            this.FindByDeclarations = this.FindByDeclarations.Replace("@", System.Environment.NewLine);
            Component comp = this.ListStorage.Components.Single(s => s.Abbreviation == prefix);
            this.PageMethods += string.Format(comment + method, "void", comp.CommonMethod + resourceKey, parameter, comp.CommonAction, resourceKey);
            this.PageMethods = this.PageMethods.Replace("@", System.Environment.NewLine);
        }

        /// <summary>
        /// Replace "Locators" with "Page" and create the file
        /// </summary>
        /// <param name="data">to build the file</param>
        private void CreateFile(string data)
        {
            System.IO.File.WriteAllText(this.GetPathOfPages() + this.NameLocator.Replace("Locators", "Page.cs"), data);
        }

        /// <summary>
        /// Obtains the current address and builds with that the path of the Page Objects
        /// </summary>
        /// <returns>A string with the new path</returns>
        public string GetPathOfPages(string path = PagesPath)
        {
            string commonPath = path;
            string context = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string[] splitContext = context.Split(Path.DirectorySeparatorChar);
            string newPath = string.Empty;
            foreach (string item in splitContext)
            {
                newPath += item + "\\\\";
                if (this.ListStorage.Projects.Any(p => p == item))
                {
                    break;
                }
            }

            return newPath + commonPath;
        }

        /// <summary>
        /// Compares and extracts the NameSpace
        /// </summary>
        /// <returns>A string of the NameSpace</returns>
        public string GetProjectNameSpace()
        {
            string context = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string[] splitContext = context.Split(Path.DirectorySeparatorChar);
            string projectNameSpace = string.Empty;
            foreach (string item in splitContext)
            {
                if (this.ListStorage.Projects.Any(p => p == item))
                {
                    projectNameSpace = item;
                }
            }

            return projectNameSpace;
        }
    }
}
