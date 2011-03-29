using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Microsoft.ServiceModel.Description;
using Microsoft.ServiceModel.Http;

namespace WcfHttpFormsAuth.Host {
	public class ContactManagerConfiguration : HttpHostConfiguration, IProcessorProvider {
		private readonly CompositionContainer _container;

		public ContactManagerConfiguration(CompositionContainer container) {
			_container = container;
		}

		public void RegisterRequestProcessorsForOperation(HttpOperationDescription operation, IList<Processor> processors, MediaTypeProcessorMode mode) {
			processors.Add(new JsonProcessor(operation,mode));
			processors.Add(new FormUrlEncodedProcessor(operation,mode));
		}

		public void RegisterResponseProcessorsForOperation(HttpOperationDescription operation, IList<Processor> processors, MediaTypeProcessorMode mode) {
			processors.Add(new JsonProcessor(operation,mode));
		}

		public object GetInstance(Type serviceType, InstanceContext instanceContext, Message message) {
			var contract = AttributedModelServices.GetContractName(serviceType);
			var identity = AttributedModelServices.GetTypeIdentity(serviceType);
			var definition = new ContractBasedImportDefinition(contract, identity, null, ImportCardinality.ExactlyOne, false,
																false, CreationPolicy.NonShared);
			return _container.GetExports(definition).First().Value;
		}
	}
}