using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;
using System.Drawing;
using OpenQA.Selenium.Support;

namespace SeleniumTests
{
    class Helpers
    {
        //Debug folder
        public static string FolderName = "Debug";
        //Way to files
        public static string Path = GetPath();

        /// <summary>
        /// Method to find a way to drivers.
        /// </summary>
        /// <returns>
        /// Path of the folder
        /// </returns>
        public static string GetPath()
        {
            var maxParentLevel = 2;
            var dirPath = Directory.GetCurrentDirectory();
            if (Directory.Exists(dirPath + "\\" + FolderName))
            {
                return dirPath + "\\" + FolderName + "\\";
            }
            for (int i = 0; i < maxParentLevel; i++)
            {
                dirPath = Directory.GetParent(dirPath).FullName;
                if (Directory.Exists(dirPath + "\\" + FolderName))
                {
                    return dirPath + "\\" + FolderName + "\\";
                }
            }
            //Folder not found
            return Directory.GetCurrentDirectory() + "\\" + FolderName + "\\";
        }
    }
}
