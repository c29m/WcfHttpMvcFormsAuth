﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace Microsoft.ServiceModel.Http.Test.UnitTests
{
    using System;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Http.Test.Mocks;
    using System.ServiceModel.Http.Test.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HttpMessageEncodingBindingElementTests
    {
        #region Type Tests
        
        [TestMethod]
        [Description("HttpMessageEncodingBindingElement is a non-public, non-abstract class.")]
        public void HttpMessageEncodingBindingElement_Is_A_Non_Public_Non_Abstract_Class()
        {
            Type type = typeof(HttpMessageEncodingBindingElement);
            Assert.IsFalse(type.IsPublic, "HttpMessageEncodingBindingElement should be public.");
            Assert.IsFalse(type.IsVisible, "HttpMessageEncodingBindingElement should be visible.");
            Assert.IsFalse(type.IsAbstract, "HttpMessageEncodingBindingElement should not be abstract.");
            Assert.IsTrue(type.IsClass, "HttpMessageEncodingBindingElement should be a class.");
        }

        #endregion Type Tests

        #region Property Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.MessageVersion is always MessageVersion.None.")]
        public void MessageVersion_Is_Always_None()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            Assert.AreEqual(MessageVersion.None, encoding.MessageVersion, "HttpMessageEncodingBindingElement.MessageVersion should have been MessageVersion.None.");
        }

        [TestMethod]
        [Description("Setting HttpMessageEncodingBindingElement.MessageVersion to null throws.")]
        public void Setting_MessageVersion_To_Null_Throws()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();

            ExceptionAssert.ThrowsArgumentNull(
                "Setting HttpMessageEncodingBindingElement.MessageVersion to null should have thrown.",
                "value",
                () =>
                {
                    encoding.MessageVersion = null;
                });
        }

        [TestMethod]
        [Description("Setting HttpMessageEncodingBindingElement.MessageVersion to something other than MessageVersion.None throws.")]
        public void Setting_MessageVersion_To_Other_Than_None_Throws()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "Setting HttpMessageEncodingBindingElement.MessageVersion to something other than MessageVersion.None should have thrown.",
                () =>
                {
                    encoding.MessageVersion = MessageVersion.Soap11;
                });
        }

        #endregion Property Tests

        #region BuildChannelFactory Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.BuildChannelFactory throws regardless of channel shape.")]
        public void BuildChannelFactory_Throws()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelFactory should have thrown.",
                () =>
                {
                    encoding.BuildChannelFactory<IReplyChannel>(MockBindingContext.Create());
                });
        }

        #endregion BuildChannelFactory Tests

        #region CanBuildChannelFactory Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.CanBuildChannelFactory always returns 'false' regardless of channel shape.")]
        public void CanBuildChannelFactory_Always_Returns_False()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            Assert.IsFalse(encoding.CanBuildChannelFactory<IReplyChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IReplySessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IRequestChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IRequestSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IOutputChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IOutputSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IInputChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IInputSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IDuplexChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
            Assert.IsFalse(encoding.CanBuildChannelFactory<IDuplexSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelFactory should always return 'false'.");
        }

        #endregion CanBuildChannelFactory Tests

        #region BuildChannelListener Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.BuildChannelListener returns an HttpMessageEncodingChannelListener for IReplyChannel.")]
        public void BuildChannelListener_Returns_ChannelListener_For_IReplyChannel()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            IChannelListener<IReplyChannel> listener = encoding.BuildChannelListener<IReplyChannel>(MockBindingContext.Create());
            Assert.IsNotNull(listener, "HttpMessageEncodingBindingElement.BuildChannelListener should have returned an instance.");
            Assert.IsInstanceOfType(listener, typeof(HttpMessageEncodingChannelListener), "HttpMessageEncodingBindingElement.BuildChannelListener should have returned an HttpMessageEncodingChannelListener.");
        }

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.BuildChannelListener returns null if the inner binding element returns null.")]
        public void BuildChannelListener_Returns_Null_If_Inner_BindingElement_Returns_Null()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            MockBindingContext context = MockBindingContext.CreateWithMockTransport();
            IChannelListener<IReplyChannel> listener = encoding.BuildChannelListener<IReplyChannel>(context);
            Assert.IsNull(listener, "HttpMessageEncodingBindingElement.BuildChannelListener should have null since the inner binding element returned null.");
        }

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.BuildChannelListener adds the HttpMessageEncodingBindingElement to the collection of binding parameters.")]
        public void BuildChannelListener_Adds_HttpMessageEncodingBindingElement_To_Binding_Parameters_Collection()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            MockBindingContext context = MockBindingContext.CreateWithMockTransport();
            encoding.BuildChannelListener<IReplyChannel>(context);
            Assert.IsTrue(context.MockTransportBindingElement.FoundHttpMessageEncodingBindingElement, "The HttpMessageEncodingBindingElement should have been added to the collection of binding parameters.");
        }

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.BuildChannelListener throws for non-IReplyChannel.")]
        public void BuildChannelListener_Throws_For_Non_IReplyChannel()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IReplySessionChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IReplySessionChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IRequestChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IRequestChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IRequestSessionChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IRequestSessionChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IOutputChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IOutputChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IOutputSessionChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IOutputSessionChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IInputChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IInputChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IInputSessionChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IInputSessionChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IDuplexChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IDuplexChannel>(MockBindingContext.Create());
                });

            ExceptionAssert.Throws(
                typeof(NotSupportedException),
                "HttpMessageEncodingBindingElement.BuildChannelListener should have thrown for IDuplexSessionChannel.",
                () =>
                {
                    encoding.BuildChannelListener<IDuplexSessionChannel>(MockBindingContext.Create());
                });
        }

        #endregion BuildChannelListener Tests

        #region CanBuildChannelListener Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.CanBuildChannelListener only returns 'true' for IReplyChannel.")]
        public void CanBuildChannelListener_Only_Returns_True_For_IReplyChannel()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            Assert.IsTrue(encoding.CanBuildChannelListener<IReplyChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should have returned 'true'.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IReplySessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IRequestChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IRequestSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IOutputChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IOutputSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IInputChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IInputSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IDuplexChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
            Assert.IsFalse(encoding.CanBuildChannelListener<IDuplexSessionChannel>(MockBindingContext.Create()), "HttpMessageEncodingBindingElement.CanBuildChannelListener should always return 'false' for non IReplyChannel shapes.");
        }

        #endregion CanBuildChannelListener Tests

        #region Clone Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.Clone returns a new instance of HttpMessageEncodingBindingElement.")]
        public void Clone_Returns_New_HttpMessageEncodingBindingElement_Instance()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            HttpMessageEncodingBindingElement encodingCloned = encoding.Clone() as HttpMessageEncodingBindingElement;
            Assert.IsNotNull(encodingCloned, "Clone should have returned a new instance of HttpMessageEncodingBindingElement");
            Assert.AreNotSame(encoding, encodingCloned, "Clone should have returned a new instance of HttpMessageEncodingBindingElement");
        }

        #endregion Clone Tests

        #region CreateMessageEncoderFactory Tests

        [TestMethod]
        [Description("HttpMessageEncodingBindingElement.CreateMessageEncoderFactory returns an instance of a HttpMessageEncoderFactory.")]
        public void CreateMessageEncoderFactory_Returns_An_HttpMessageEncoderFactory()
        {
            HttpMessageEncodingBindingElement encoding = new HttpMessageEncodingBindingElement();
            MessageEncoderFactory encoderFactory = encoding.CreateMessageEncoderFactory();
            Assert.IsNotNull(encoderFactory, "HttpMessageEncodingBindingElement.CreateMessageEncoderFactory should not have returned null.");
            Assert.IsInstanceOfType(encoderFactory, typeof(HttpMessageEncoderFactory), "HttpMessageEncodingBindingElement.CreateMessageEncoderFactory should have returned an instance of a HttpMessageEncoderFactory.");
        }

        #endregion CreateMessageEncoderFactory Tests
    }
}
