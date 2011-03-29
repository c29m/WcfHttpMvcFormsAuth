using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using WcfHttpFormsAuth.Dto;

namespace WcfHttpFormsAuth.Client {
	class Program {
		static void Main(string[] args) {
			CookieContainer cookieContainer = new CookieContainer();
			using (HttpClient client = new HttpClient("http://localhost:44857/")) {
				HttpClientChannel clientChannel = new HttpClientChannel();
				clientChannel.CookieContainer = cookieContainer;
				client.Channel = clientChannel;
				HttpContent loginData = new FormUrlEncodedContent(
					new List<KeyValuePair<string, string>>
						{
							new KeyValuePair<string, string>("Username", "foo"),
							new KeyValuePair<string, string>("Password", "bar")
						}
					);
				client.Post("login", loginData);
			}

			string result = string.Empty;
			using (HttpClient client = new HttpClient("http://localhost:44857/contact/")) {
				HttpClientChannel clientChannel = new HttpClientChannel();
				clientChannel.CookieContainer = cookieContainer;
				client.Channel = clientChannel;
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage response = client.Get("1");
				result = response.Content.ReadAsString();
			}

			JavaScriptSerializer jsonDeserializer = new JavaScriptSerializer();
			ContactDto contact = jsonDeserializer.Deserialize<ContactDto>(result);
			Console.WriteLine(contact.Name);
			Console.ReadLine();
		}
	}
}
