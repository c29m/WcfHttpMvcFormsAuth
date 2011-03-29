using System.ComponentModel.Composition;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Security;

namespace WcfHttpFormsAuth.Host {
	[ServiceContract]
	[Export]
	public class LoginResource {
		[ImportingConstructor]
		public LoginResource() {
			
		}

		[WebInvoke(UriTemplate="", Method = "POST")]
		public void Login(Credentials credentials, HttpResponseMessage responseMessage) {
			bool auth = Membership.ValidateUser(credentials.Username, credentials.Password);

			if (auth) {
				FormsAuthentication.SetAuthCookie(credentials.Username,true);
			}
			else {
				responseMessage.StatusCode = HttpStatusCode.Unauthorized;
			}
		}
	}
}