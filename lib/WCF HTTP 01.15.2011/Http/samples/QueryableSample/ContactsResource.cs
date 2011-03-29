﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace QueryableSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ContactsResource
    {
        private static int totalContacts = 1;
        private static List<Contact> contacts = new List<Contact>()
        {
            new Contact { Name = "First Contact", Id = totalContacts++ },
            new Contact { Name = "Second Contact", Id = totalContacts++ },
            new Contact { Name = "Third Contact", Id = totalContacts++ },
            new Contact { Name = "Fourth Contact", Id = totalContacts++ },
        };

        [WebGet(UriTemplate="")]
        [QueryComposition]
        public IEnumerable<Contact> Get()
        {
            return contacts.AsQueryable();
        }

        [WebInvoke(UriTemplate = "", Method = "POST")]
        public Contact Post(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("contact");
            }

            contact.Id = totalContacts++;
            contacts.Add(contact);
            return contact;
        }
    }
}