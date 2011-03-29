﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace Microsoft.ServiceModel.Http.Test.UnitTests
{
    using System;
    using System.ServiceModel.Channels;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HttpMessageEncoderFactoryTests
    {
        #region Type Tests
        
        [TestMethod]
        [Description("HttpMessageEncoderFactory is an internal, non-abstract class.")]
        public void HttpMessageEncoderFactory_Is_An_Internal_Non_Abstract_Class()
        {
            Type type = typeof(HttpMessageEncoderFactory);
            Assert.IsTrue(type.IsNotPublic, "HttpMessageEncoderFactory should not be public.");
            Assert.IsFalse(type.IsVisible, "HttpMessageEncoderFactory should not be visible.");
            Assert.IsFalse(type.IsAbstract, "HttpMessageEncoderFactory should not be abstract.");
            Assert.IsTrue(type.IsClass, "HttpMessageEncoderFactory should be a class.");
        }

        #endregion  Type Tests

        #region Property Tests

        [TestMethod]
        [Description("HttpMessageEncoderFactory.Encoder returns a MessageEncoder.")]
        public void MessageEncoderFactory_Encoder_Returns_A_MessageEncoder()
        {
            HttpMessageEncoderFactory factory = new HttpMessageEncoderFactory();
            MessageEncoder encoder = factory.Encoder;
            Assert.IsNotNull(encoder, "HttpMessageEncoderFactory.Encoder should have returned null.");
        }

        [TestMethod]
        [Description("HttpMessageEncoderFactory.MessageVersion is always MessageVersion.None.")]
        public void MessageVersion_Is_None()
        {
            HttpMessageEncoderFactory factory = new HttpMessageEncoderFactory();
            Assert.AreEqual(MessageVersion.None, factory.MessageVersion, "HttpMessageEncoderFactory.MessageVersion should always be MessageVersion.None.");
        }

        #endregion Property Tests
    }
}
