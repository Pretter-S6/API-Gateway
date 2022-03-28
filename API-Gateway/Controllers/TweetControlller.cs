using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using API_Gateway.Models;
using System.Net.Http;

namespace API_Gateway.Controllers
{
    [ApiController]
    [Route("/test")]
    public class TweetController : ControllerBase
    {

        private readonly ILogger<TweetController> _logger;

        public TweetController(ILogger<TweetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Tweet>> getAll()
        {
            List<Tweet> tweetList = new List<Tweet>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44388/test"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    tweetList = JsonConvert.DeserializeObject<List<Tweet>>(apiResponse);
                }
            }
            return tweetList;
        }
    }
}
