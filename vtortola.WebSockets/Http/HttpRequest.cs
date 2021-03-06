﻿using System;
using System.Collections.Generic;
using System.Net;

namespace vtortola.WebSockets
{
    public abstract class HttpRequest
    {
        public IPEndPoint LocalEndpoint { get; private set; }
        public IPEndPoint RemoteEndpoint { get; private set; }
        public Uri RequestUri { get; internal set; }
        public Version HttpVersion { get; internal set; }
        public CookieCollection Cookies { get; private set; }
        public HttpHeadersCollection Headers { get; private set; }
        public IDictionary<String, Object> Items { get; private set; }

        static readonly IPEndPoint _none = new IPEndPoint(IPAddress.None, 0);

        public HttpRequest(IPEndPoint localEndpoint, IPEndPoint remoteEndpoint)
        {
            Headers = new HttpHeadersCollection();
            Cookies = new CookieCollection();
            Items = new Dictionary<String, Object>();
            LocalEndpoint = localEndpoint ?? _none;
            RemoteEndpoint = remoteEndpoint ?? _none;
        }
    }
}
