﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MuffaloBotNetFramework
{
    static class HttpRequest
    {
        static HttpClient client = new HttpClient();
        public static string Request(string request)
        {
            return client.GetStringAsync(request).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
