﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace Microsoft.ServiceModel.Dispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.Channels;
    using System.Text;
    using System.Net.Http;

    public class SelectedOperation
    {
        public string Name { get; set; }

        public static string Get(HttpRequestMessage request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            object property = request.GetProperties().FirstOrDefault(o => o is SelectedOperation);
            if (property != null)
            {
                SelectedOperation selectedOperation = property as SelectedOperation;
                return selectedOperation.Name;
            }

            return null;
        }

        public static void Set(HttpRequestMessage request, string operationName)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            request.GetProperties().Add(new SelectedOperation() { Name = operationName });
        }
    }
}
