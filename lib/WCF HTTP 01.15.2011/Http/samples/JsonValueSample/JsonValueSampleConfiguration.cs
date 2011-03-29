﻿namespace JsonValueSample
{
    using System.Collections.Generic;
    using System.ServiceModel.Description;
    using System.ServiceModel.Dispatcher;

    using Microsoft.ServiceModel.Description;
    using Microsoft.ServiceModel.Dispatcher;
    using Microsoft.ServiceModel.Http;

    public class JsonValueSampleConfiguration : HttpHostConfiguration, IProcessorProvider
    {
        public JsonValueSampleConfiguration()
        {
            this.SetProcessorProvider(this);
        }

        public void RegisterRequestProcessorsForOperation(HttpOperationDescription operation, IList<Processor> processors, MediaTypeProcessorMode mode)
        {
            processors.Add(new FormUrlEncodedProcessor(operation, mode));
        }

        public void RegisterResponseProcessorsForOperation(HttpOperationDescription operation, IList<Processor> processors, MediaTypeProcessorMode mode)
        {
            processors.ClearMediaTypeProcessors();
            processors.Add(new JsonProcessor(operation, mode));
        }
    }
}