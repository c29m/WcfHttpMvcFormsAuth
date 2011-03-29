using System.ComponentModel.Composition;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using WcfHttpFormsAuth.Dto;

namespace WcfHttpFormsAuth.Host {
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceContract]
	[Export]
	public class ContactResource {
		[ImportingConstructor]
		public ContactResource() {
			
		}

		[WebGet(UriTemplate="{id}")]
		public ContactDto Get(string id, HttpResponseMessage responseMessage) {
			var contact = new ContactDto
			              	{
			              		Name = "Alexander Zeitler"
			              	};
			return contact;
		}
	}
}