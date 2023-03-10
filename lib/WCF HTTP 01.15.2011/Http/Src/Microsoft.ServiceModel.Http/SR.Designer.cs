//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.ServiceModel
{


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.ServiceModel.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The output argument with name &apos;{0}&apos; and type &apos;{1}&apos; can not be bound or unbound with the input argument with name &apos;{2}&apos; and type &apos;{3}&apos; because they belong to the same processor..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceBelongToSameProcessor {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceBelongToSameProcessor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The arguments can not be bound or unbound because the argument with name &apos;{0}&apos; has a type &apos;{1}&apos; that is not assignable to the type of the argument with name &apos;{2}&apos; and type &apos;{3}&apos;..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceNotAssignable {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceNotAssignable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument with name &apos;{0}&apos; and type &apos;{1}&apos; can not be bound or unbound because it does not belong to a ProcessorArgumentCollection..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceNotInProcessorArgumentCollection {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceNotInProcessorArgumentCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument with name &apos;{0}&apos; and type &apos;{1}&apos; can not be bound or unbound because it is not an input argument..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceNotInputArgument {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceNotInputArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument with name &apos;{0}&apos; and type &apos;{1}&apos; can not be bound or unbound because it is not an output argument..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceNotOutputArgument {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceNotOutputArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument with name &apos;{0}&apos; and type &apos;{1}&apos; can not be bound or unbound because it&apos;s processor does not belong to the pipeline..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceProcessorNotInPipeline {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceProcessorNotInPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The arguments can not be bound or unbound because the out argument with name &apos;{0}&apos; and type &apos;{1}&apos; belongs to a processor that comes after the processor with the input argument with name &apos;{2}&apos; and type &apos;{3}&apos;..
        /// </summary>
        internal static string ArgumentBindingInvalidSinceProcessorOrderIsWrong {
            get {
                return ResourceManager.GetString("ArgumentBindingInvalidSinceProcessorOrderIsWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InArgument does not belong to a processor in the current pipeline.
        /// </summary>
        internal static string ArgumentDoesNotBelongToProcessorInCurrentPipeline {
            get {
                return ResourceManager.GetString("ArgumentDoesNotBelongToProcessorInCurrentPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments can not be bound after the PipelineProcessor has been initialized..
        /// </summary>
        internal static string ArgumentsCannotBeBoundAfterInitialization {
            get {
                return ResourceManager.GetString("ArgumentsCannotBeBoundAfterInitialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments can not be unbound after the PipelineProcessor has been initialized..
        /// </summary>
        internal static string ArgumentsCannotBeUnboundAfterInitialization {
            get {
                return ResourceManager.GetString("ArgumentsCannotBeUnboundAfterInitialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate-based client authentication is not supported in TransportCredentialOnly security mode. Select the Transport security mode..
        /// </summary>
        internal static string CertificateUnsupportedForHttpTransportCredentialOnly {
            get {
                return ResourceManager.GetString("CertificateUnsupportedForHttpTransportCredentialOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message encoding binding element does not support building ChannelFactory instances..
        /// </summary>
        internal static string ChannelFactoryNotSupportedByHttpMessageEncodingBindingElement {
            get {
                return ResourceManager.GetString("ChannelFactoryNotSupportedByHttpMessageEncodingBindingElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message encoding binding element does not support the &apos;{0}&apos; channel shape..
        /// </summary>
        internal static string ChannelShapeNotSupportedByHttpMessageEncodingBindingElement {
            get {
                return ResourceManager.GetString("ChannelShapeNotSupportedByHttpMessageEncodingBindingElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {1} binding does not have a configured binding named &apos;{0}&apos;..
        /// </summary>
        internal static string ConfigInvalidBindingConfigurationName {
            get {
                return ResourceManager.GetString("ConfigInvalidBindingConfigurationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ContainerProcessor of type &apos;{0}&apos; cannot be included in the collection of processors..
        /// </summary>
        internal static string ContainerProcessorCannotBeInProcessorCollection {
            get {
                return ResourceManager.GetString("ContainerProcessorCannotBeInProcessorCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Any implementation of &apos;{0}&apos; in a derived class must return a non-null value..
        /// </summary>
        internal static string DerivedMethodCannotReturnNull {
            get {
                return ResourceManager.GetString("DerivedMethodCannotReturnNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The error handler of type &apos;{0}&apos; received a null HttpResponseMessage in ProvideFault..
        /// </summary>
        internal static string HttpErrorMessageNullResponse {
            get {
                return ResourceManager.GetString("HttpErrorMessageNullResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The instance provider of type &apos;{0}&apos; received a null HttpRequestMessage in GetInstance..
        /// </summary>
        internal static string HttpInstanceProviderNullRequest {
            get {
                return ResourceManager.GetString("HttpInstanceProviderNullRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatter of type &apos;{0}&apos; only supports bindings that ensure the message version is MessageVersion.None.
        /// </summary>
        internal static string HttpMessageFormatterMessageVersion {
            get {
                return ResourceManager.GetString("HttpMessageFormatterMessageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatter of type &apos;{0}&apos; received a null HttpRequestMessage in DeserializeRequest..
        /// </summary>
        internal static string HttpMessageFormatterNullRequest {
            get {
                return ResourceManager.GetString("HttpMessageFormatterNullRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatter of type &apos;{0}&apos; received a null HttpResponseMessage in SerializeReply..
        /// </summary>
        internal static string HttpMessageFormatterNullResponse {
            get {
                return ResourceManager.GetString("HttpMessageFormatterNullResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The inspector of type &apos;{0}&apos; received a null HttpRequestMessage in AfterReceiveRequest..
        /// </summary>
        internal static string HttpMessageInspectorNullRequest {
            get {
                return ResourceManager.GetString("HttpMessageInspectorNullRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The inspector of type &apos;{0}&apos; received a null HttpResponseMessage in BeforeSendReply..
        /// </summary>
        internal static string HttpMessageInspectorNullResponse {
            get {
                return ResourceManager.GetString("HttpMessageInspectorNullResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Name property cannot be modified on the associated OperationDescription..
        /// </summary>
        internal static string HttpOperationDescriptionNameImmutable {
            get {
                return ResourceManager.GetString("HttpOperationDescriptionNameImmutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OperationDescription is available..
        /// </summary>
        internal static string HttpOperationDescriptionNullOperationDescription {
            get {
                return ResourceManager.GetString("HttpOperationDescriptionNullOperationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation selector of type &apos;{0}&apos; selected a null operation..
        /// </summary>
        internal static string HttpOperationSelectorNullOperation {
            get {
                return ResourceManager.GetString("HttpOperationSelectorNullOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation selector of type &apos;{0}&apos; received a null HttpRequestMessage in SelectOperation..
        /// </summary>
        internal static string HttpOperationSelectorNullRequest {
            get {
                return ResourceManager.GetString("HttpOperationSelectorNullRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only an HttpParameterDescription created from a MessagePartDescription can be used with this operation..
        /// </summary>
        internal static string HttpParameterDescriptionMustBeSynchronized {
            get {
                return ResourceManager.GetString("HttpParameterDescriptionMustBeSynchronized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Name property cannot be modified on the associated MessagePartDescription..
        /// </summary>
        internal static string HttpParameterDescriptionNameImmutable {
            get {
                return ResourceManager.GetString("HttpParameterDescriptionNameImmutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Namespace property cannot be modified on the associated MessagePartDescription..
        /// </summary>
        internal static string HttpParameterDescriptionNamespaceImmutable {
            get {
                return ResourceManager.GetString("HttpParameterDescriptionNamespaceImmutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP request message body with a content length of &apos;{0}&apos; bytes..
        /// </summary>
        internal static string MessageBodyIsHttpRequestMessageWithKnownContentLength {
            get {
                return ResourceManager.GetString("MessageBodyIsHttpRequestMessageWithKnownContentLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP request message body with an undetermined content length..
        /// </summary>
        internal static string MessageBodyIsHttpRequestMessageWithUnknownContentLength {
            get {
                return ResourceManager.GetString("MessageBodyIsHttpRequestMessageWithUnknownContentLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP response message body with a content length of &apos;{0}&apos; bytes..
        /// </summary>
        internal static string MessageBodyIsHttpResponseMessageWithKnownContentLength {
            get {
                return ResourceManager.GetString("MessageBodyIsHttpResponseMessageWithKnownContentLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP response message body with an undetermined content length..
        /// </summary>
        internal static string MessageBodyIsHttpResponseMessageWithUnknownContentLength {
            get {
                return ResourceManager.GetString("MessageBodyIsHttpResponseMessageWithUnknownContentLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message is closed..
        /// </summary>
        internal static string MessageClosed {
            get {
                return ResourceManager.GetString("MessageClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response message is not valid for the encoder used by the &apos;{0}&apos; binding, which requires that the response message have been created with the &apos;{1}&apos; extension method on the &apos;{2}&apos; class..
        /// </summary>
        internal static string MessageInvalidForHttpMessageEncoder {
            get {
                return ResourceManager.GetString("MessageInvalidForHttpMessageEncoder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message instance does not support being read, written out or copied.  Use the &apos;{0}&apos; or &apos;{1}&apos; extension methods on the &apos;{2}&apos; class to access the message content..
        /// </summary>
        internal static string MessageReadWriteCopyNotSupported {
            get {
                return ResourceManager.GetString("MessageReadWriteCopyNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message instance is non-empty but the &apos;{0}&apos; extension method on the &apos;{1}&apos; class returned null.  Message instances that do not support the &apos;{0}&apos; extension method must be empty. .
        /// </summary>
        internal static string NonHttpMessageMustBeEmpty {
            get {
                return ResourceManager.GetString("NonHttpMessageMustBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value at index &apos;{0}&apos; of the &apos;{1}&apos; array parameter is null..
        /// </summary>
        internal static string NullValueInArrayParameter {
            get {
                return ResourceManager.GetString("NullValueInArrayParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message encoding binding element only supports MessageVersion.None. .
        /// </summary>
        internal static string OnlyMessageVersionNoneSupportedOnHttpMessageEncodingBindingElement {
            get {
                return ResourceManager.GetString("OnlyMessageVersionNoneSupportedOnHttpMessageEncodingBindingElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter can not be null, an empty string or only whitespace..
        /// </summary>
        internal static string ParameterCannotBeNullEmptyStringOrWhitespace {
            get {
                return ResourceManager.GetString("ParameterCannotBeNullEmptyStringOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;{0}&apos; parameter must be less than or equal to the value of the &apos;{1}&apos; parameter..
        /// </summary>
        internal static string ParameterMustBeLessThanOrEqualSecondParameter {
            get {
                return ResourceManager.GetString("ParameterMustBeLessThanOrEqualSecondParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PipelineBuilder requires that the Pipeline type parameter &apos;{0}&apos; have a constructor identical to the constructor of the base Pipeline type..
        /// </summary>
        internal static string PipelineBuilderRequiresPipelineConstructorHaveCertainParameters {
            get {
                return ResourceManager.GetString("PipelineBuilderRequiresPipelineConstructorHaveCertainParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pipeline does not have an input argument with the name &apos;{0}&apos;..
        /// </summary>
        internal static string PipelineDoesNotHaveGivenInputArgument {
            get {
                return ResourceManager.GetString("PipelineDoesNotHaveGivenInputArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pipeline does not have an output argument with the name &apos;{0}&apos;..
        /// </summary>
        internal static string PipelineDoesNotHaveGivenOutputArgument {
            get {
                return ResourceManager.GetString("PipelineDoesNotHaveGivenOutputArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Pipeline is not valid because the input ProcessArgument with name &apos;{0}&apos; on the Processor of type &apos;{1}&apos; at index &apos;{2}&apos; will never receive a value because it is not bound to the output of any Processor..
        /// </summary>
        internal static string PipelineInvalidSinceArgumentNotBound {
            get {
                return ResourceManager.GetString("PipelineInvalidSinceArgumentNotBound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Processor of type &apos;{0}&apos; already belongs to a ProcessorCollection and cannot be added to a second ProcessorCollection..
        /// </summary>
        internal static string ProcessorAlreadyBelongsToProcessorCollection {
            get {
                return ResourceManager.GetString("ProcessorAlreadyBelongsToProcessorCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ProcessorArgument with name &apos;{0}&apos; already belongs to ProcessorArgumentCollection and cannot be added to a second ProcessorArgumentCollection..
        /// </summary>
        internal static string ProcessorArgumentAlreadyBelongsToProcessorArgumentCollection {
            get {
                return ResourceManager.GetString("ProcessorArgumentAlreadyBelongsToProcessorArgumentCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ProcessorArgument &apos;{0}&apos; cannot be added to a ProcessorArgumentCollection more than once..
        /// </summary>
        internal static string ProcessorArgumentCannotBeAddedTwice {
            get {
                return ResourceManager.GetString("ProcessorArgumentCannotBeAddedTwice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of a ProcessorArgument can not be an empty string or only whitespace..
        /// </summary>
        internal static string ProcessorArgumentNameCannotBeEmptyStringOrWhitespace {
            get {
                return ResourceManager.GetString("ProcessorArgumentNameCannotBeEmptyStringOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Type property of a ProcessorArgument can not be a generic nullable type.  Set the Type property to type &apos;{0}&apos; directly..
        /// </summary>
        internal static string ProcessorArgumentTypeCannotBeNullable {
            get {
                return ResourceManager.GetString("ProcessorArgumentTypeCannotBeNullable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The containing ProcessorArgumentCollection already has an ProcessorArgument with the name &apos;{0}&apos; at index &apos;{1}&apos;..
        /// </summary>
        internal static string ProcessorArgumentWithSameName {
            get {
                return ResourceManager.GetString("ProcessorArgumentWithSameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Processor of type &apos;{0}&apos; cannot be added to a ProcessorCollection more than once..
        /// </summary>
        internal static string ProcessorCannotBeAddedTwice {
            get {
                return ResourceManager.GetString("ProcessorCannotBeAddedTwice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The processor does not belong to the current pipeline..
        /// </summary>
        internal static string ProcessorDoesNotBelongToCurrentPipeline {
            get {
                return ResourceManager.GetString("ProcessorDoesNotBelongToCurrentPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The processor must be intialized before it can be executed..
        /// </summary>
        internal static string ProcessorMustBeInitializedBeforeExecution {
            get {
                return ResourceManager.GetString("ProcessorMustBeInitializedBeforeExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Processors of types &apos;{0}&apos; and &apos;{1}&apos; have an ordering conflict that can not be resolved..
        /// </summary>
        internal static string ProcessorOrderingConflictCannotBeResolved {
            get {
                return ResourceManager.GetString("ProcessorOrderingConflictCannotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processor &apos;{0}&apos; expected &apos;{1}&apos; argument values but received &apos;{2}&apos; values..
        /// </summary>
        internal static string ProcessorReceivedWrongNumberOfValues {
            get {
                return ResourceManager.GetString("ProcessorReceivedWrongNumberOfValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The processor returned a null ProcessorResult..
        /// </summary>
        internal static string ProcessorReturnedNullProcessorResult {
            get {
                return ResourceManager.GetString("ProcessorReturnedNullProcessorResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming message does not have the required &apos;{0}&apos; property of type &apos;{1}&apos;..
        /// </summary>
        internal static string RequestMissingHttpRequestMessageProperty {
            get {
                return ResourceManager.GetString("RequestMissingHttpRequestMessageProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming message does not have the required &apos;To&apos; header..
        /// </summary>
        internal static string RequestMissingToHeader {
            get {
                return ResourceManager.GetString("RequestMissingToHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; cannot be converted to &apos;{1}&apos;..
        /// </summary>
        internal static string ValueCannotBeConverted {
            get {
                return ResourceManager.GetString("ValueCannotBeConverted", resourceCulture);
            }
        }
    }
}
