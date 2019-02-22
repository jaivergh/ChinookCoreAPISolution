using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ChinookCoreAPI.IntegrationTests
{
	public class AlbumIntegrationTests
	{
		private readonly HttpClient _client;
		private readonly TestServer _server;

		public AlbumIntegrationTests()
		{
			_server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
			_client = _server.CreateClient();
		}

		[Theory]
		[InlineData("GET")]
		public async Task TestAlbumAsync(string method)
		{
			//Arrange
			var request = new HttpRequestMessage(new HttpMethod(method), "/api/Albums");

			//Act
			var response = await _client.SendAsync(request);

			//Assert
			response.EnsureSuccessStatusCode();
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}

		[Theory]
		[InlineData("GET", 1)]
		public async Task TestOneAlbumAsync(string method, int? id = null)
		{
			//Arrage
			var request = new HttpRequestMessage(new HttpMethod(method), $"/api/Albums/{id}");

			//Act
			var response = await _client.SendAsync(request);

			//Assert
			response.EnsureSuccessStatusCode();
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
		}
	}
}
