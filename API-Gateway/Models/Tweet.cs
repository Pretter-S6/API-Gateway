using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Gateway.Models
{
    public class Tweet
    {
        public Tweet()
        {
            reactions = new List<string>();
        }

        public int tweetID { get; set; }
        public string text { get; set; }
        public DateTime uploadTime { get; set; }
        public List<User> likes { get; set; }
        public List<string> reactions { get; set; }


    }
}
