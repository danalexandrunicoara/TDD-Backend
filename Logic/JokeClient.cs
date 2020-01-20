using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Logic
{
	public class JokeClient
	{
		private readonly HttpClient _client = new HttpClient {BaseAddress = new Uri("https://api.icndb.com/")};

		public JokeClient()
		{
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public JokeDto GetJoke(string path)
		{
			var joke = string.Empty;
			var response = _client.GetAsync(path).Result;

			if (response.IsSuccessStatusCode) joke = response.Content.ReadAsStringAsync().Result;

			var jsonJoke = JsonConvert.DeserializeObject<JokeDto>(joke);

			return jsonJoke;
		}
	}
}