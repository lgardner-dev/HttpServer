﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    public class Request
    {
        public String Type { get; set; }
        public String Url { get; set; }
        public String Host { get; set; }

        private Request(String type, String url, String host) 
        {

        }

        public static Request GetRequest(String request)
        {
            if (String.IsNullOrEmpty(request))
                return null;
            String[] tokens = request.Split(' ');
            return new Request("", "", "");
        }
    }
}
