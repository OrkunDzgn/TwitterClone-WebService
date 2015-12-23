﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws2
{
    public class Tweets
    { 
        public List<Tweet> tweets { get; set; }
    }

    public class Tweet
    {
        public int _id { get; set; }
        public string tweet { get; set; }
        public string datePosted { get; set; }
        public string timePosted { get; set; }
    }

    public class Error
    {
        public string error { get; set; }
    }

    public class Following
    {
        public int _id { get; set; }
        public List<int> following { get; set; }
    }

    public class Followers
    {
        public int _id { get; set; }
        public List<int> followers { get; set; }
    }

    public class UserCredential
    {
        public int _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }


    public class User
    {
        public int _id { get; set; }
        public string username { get; set; }
        public string description { get; set; }
        public double dateJoined { get; set; }
        public string profilePicture { get; set; }
    }
}