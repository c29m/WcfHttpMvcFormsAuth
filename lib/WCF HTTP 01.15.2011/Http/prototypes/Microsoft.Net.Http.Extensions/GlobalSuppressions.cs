﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Hasn't shipped yet")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Xml.Serialization", Justification = "Compatible with Rest Starter Kit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Xml.Linq", Justification = "Compatible with Rest Starter Kit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Xml", Justification = "Compatible with Rest Starter Kit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Runtime.Serialization.Json", Justification = "Compatible with Rest Starter Kit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Runtime.Serialization", Justification = "Compatible with Rest Starter Kit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Requires DataContractJsonSerializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Requires DataContractJsonSerializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ReadAsDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.DataContractSerializer)", Justification = "Requires DataContractSerializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ToContentUsingDataContractSerializer(System.Object,System.Runtime.Serialization.DataContractSerializer)", Justification ="Requires DataContractSerializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ToContentUsingDataContractJsonSerializer(System.Object,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification ="Requires DataContractJsonSerializer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Net.Http", Justification="Extension methods for classes in System.Net.Http")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Json", Justification="Extension methods for classes in System.Json")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Xml.Linq.XElementContentExtensions.#ToContent(System.Xml.Linq.XElement,System.Xml.Linq.SaveOptions)", Justification = "By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "Microsoft.Xml.XmlNode", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ReadAsXmlDocument(System.Net.Http.HttpContent)", Justification = "By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "Microsoft.Xml.XmlNode", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ToContent(System.Xml.XmlDocument)", Justification="By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ReadAsDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.DataContractSerializer)", Justification="Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ReadAsDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.DataContractSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ToContentUsingDataContractSerializer(System.Object,System.Runtime.Serialization.DataContractSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Runtime.Serialization.DataContractContentExtensions.#ToContentUsingDataContractSerializer(System.Object,System.Type[])", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Net.Http.HttpContentExtensions.#ReadAsObject`1(System.Net.Http.HttpContent,Microsoft.Net.Http.IContentFormatter[])", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ReadAsJsonDataContract`1(System.Net.Http.HttpContent,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ToContentUsingDataContractJsonSerializer(System.Object,System.Runtime.Serialization.Json.DataContractJsonSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Runtime.Serialization.Json.JsonContentExtensions.#ToContentUsingDataContractJsonSerializer(System.Object,System.Type[])", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Json.JsonValueContentExtensions.#ReadAsJsonValue(System.Net.Http.HttpContent)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Json.JsonValueContentExtensions.#ToContent(Microsoft.Json.JsonValue)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Net.Http.Extensions.ObjectExtensions.#ToContent(System.Object,Microsoft.Net.Http.IContentFormatter)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Xml.Linq.XElementContentExtensions.#ToContent(System.Xml.Linq.XElement,System.Xml.Linq.SaveOptions)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ReadAsXmlDocument(System.Net.Http.HttpContent)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ToContent(System.Xml.XmlDocument)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Xml.Serialization.XmlSerializerContentExtensions.#ReadAsXmlSerializable(System.Net.Http.HttpContent,System.Xml.Serialization.XmlSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Xml.Serialization.XmlSerializerContentExtensions.#ReadAsXmlSerializable`1(System.Net.Http.HttpContent,System.Xml.Serialization.XmlSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Xml.Serialization.XmlSerializerContentExtensions.#ToContentUsingXmlSerializer(System.Object)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Xml.Serialization.XmlSerializerContentExtensions.#ToContentUsingXmlSerializer(System.Object,System.Xml.Serialization.XmlSerializer)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Json.JsonValueContentExtensions.#ToContent(System.Json.JsonValue)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Microsoft.Net.Http.HttpContentExtensions.#ToContent(System.Object,Microsoft.Net.Http.IContentFormatter)", Justification = "Arguments validated by ThrowIfNull method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "System.Xml.XmlNode", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ReadAsXmlDocument(System.Net.Http.HttpContent)", Justification="By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "System.Xml.XmlNode", Scope = "member", Target = "Microsoft.Xml.XmlDocumentExtensions.#ToContent(System.Xml.XmlDocument)", Justification="By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Xml.XmlReaderContentExtensions.#ReadAsXmlReader(System.Net.Http.HttpContent,System.Xml.XmlReaderSettings)", Justification = "Arguments validated by ThrowIfNull method")]
