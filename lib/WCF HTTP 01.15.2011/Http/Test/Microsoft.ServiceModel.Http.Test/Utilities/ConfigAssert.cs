﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace System.ServiceModel.Http.Test.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Security;
    using System.Security.Permissions;
    using System.Security.Policy;
    using System.Threading;

    /// <summary>
    /// MSTest utility for creating a unit test that executes against a particular configuration file.
    /// </summary>
    public static class ConfigAssert
    {
        private static int testDomainCounter;

        /// <summary>
        /// Executes the <see cref="Action"/> given by the <paramref name="codeUnderTest"/> parameter in a new AppDomain that has 
        /// been setup to use the configuration file with the name given by the  <paramref name="configFileName"/> parameter.
        /// </summary>
        /// <param name="configFileName">The name of the configuration file to use for the test.  The configuration file must
        /// exist somewhere in the directory hierarchy under the location of the executing test assembly.  This is not a relative
        /// or absolute path to the configuration file, but just the name of the configuration file itself.
        /// </param>
        /// <param name="codeUnderTest">The code to execute against the configuration file with the traditional 
        /// MSTest <see cref="Assert"/> logic
        /// </param>
        public static void Execute(string configFileName, Action codeUnderTest)
        {
            if (configFileName == null)
            {
                throw new ArgumentNullException("configFilePath");
            }

            if (codeUnderTest == null)
            {
                throw new ArgumentNullException("codeUnderTest");
            }

            AppDomainSetup setupInfo = CreateAppDomainSetup(configFileName);
            Evidence evidence = new Evidence();
            PermissionSet permissions = new PermissionSet(PermissionState.Unrestricted);
            string domainName = GetTestDomainName();

            AppDomain testDomain = null;
            try
            {
                testDomain = AppDomain.CreateDomain(domainName, evidence, setupInfo, permissions);
                testDomain.DoCallBack(new CrossAppDomainDelegate(codeUnderTest));
            }
            finally
            {
                AppDomain.Unload(testDomain);
            }
        }

        private static string GetTestDomainName()
        {
            return string.Format("TestDomain_{0}", Interlocked.Increment(ref testDomainCounter));
        }

        private static AppDomainSetup CreateAppDomainSetup(string configName)
        {
            if (string.IsNullOrEmpty(configName))
            {
                throw new ArgumentException("The 'configName' parameter can not be null or an empty string.");
            }

            AppDomainSetup setupInfo = new AppDomainSetup();
            setupInfo.ConfigurationFile = GetConfigFilePath(configName);
            setupInfo.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            return setupInfo;
        }

        private static string GetConfigFilePath(string configName)
        {
            if (File.Exists(configName))
            {
                return configName;
            }

            string[] filePaths = Directory.EnumerateFiles(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                configName, 
                SearchOption.AllDirectories).ToArray();

            if (filePaths.Length == 0)
            {
                throw new FileNotFoundException(
                    string.Format(
                        "The config test can not be executed because the config file '{0}' was not found.",
                        configName));
            }
            else if (filePaths.Length > 1)
            {
                string[] distinctConfigFilePaths = filePaths.Distinct(new FileEqualityComparer()).ToArray();
                if (distinctConfigFilePaths.Length > 1)
                {
                    throw new InvalidOperationException(
                        string.Format(
                            "Different versions of the config file '{0}' were found within the directory hierarchy of the executing test assembly : {1}.",
                            configName,
                            string.Join("; ", distinctConfigFilePaths)));
                }
            }
            
            return filePaths[0];    
        }

        private class FileEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string filePath1, string filePath2)
            {
                FileInfo fileInfo1 = new FileInfo(filePath1);
                Debug.Assert(fileInfo1 != null, "The file should exist so the fileInfo creation should not have failed.");
                Debug.Assert(fileInfo1.Exists, "The file should exist.");

                FileInfo fileInfo2 = new FileInfo(filePath2);
                Debug.Assert(fileInfo2 != null, "The file should exist so the fileInfo creation should not have failed.");
                Debug.Assert(fileInfo2.Exists, "The file should exist.");

                return fileInfo1.Length == fileInfo2.Length;
            }

            public int GetHashCode(string filePath)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Debug.Assert(fileInfo != null, "The file should exist so the fileInfo creation should not have failed.");
                Debug.Assert(fileInfo.Exists, "The file should exist.");
                return (int)fileInfo.Length;
            }
        }
    }
}
