﻿#region Copyright
// Library for use www.cinemate.cc API
// Copyright (C) 2015 Nick Rimmer. Contacts: <xan@dipteam.com>
// 
// This file is part of CinemateApi.
// 
// CinemateApi is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// License: http://opensource.org/licenses/GPL-2.0
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace CinemateApi.Tools
{
    /// <summary>
    /// Help with remote requests
    /// </summary>
    public static class RemoteHelper
    {
        public static Encoding BrowserEncoding = Encoding.UTF8;

        /// <summary>
        /// Download JSON string and convert to model
        /// </summary>
        /// <typeparam name="T">type of response model</typeparam>
        /// <param name="baseUrl">host</param>
        /// <param name="path">path</param>
        /// <param name="arguments">some arguments in Dictionary</param>
        /// <returns>parsed and converted json to model</returns>
        public static T DownloadJson<T>(string baseUrl, string path, Dictionary<string, object> arguments)
        {
            //small trick if forgot
            if (!arguments.ContainsKey("format"))
                arguments.Add("format", "json");

            using (var browser = new WebClient())
            {
                browser.Encoding = BrowserEncoding;

                baseUrl = baseUrl.EndsWith("/") ? baseUrl.Substring(0, baseUrl.Length - 1) : baseUrl;
                path = path.StartsWith("/") ? path.Substring(1) : path;

                var uriBuilder = new UriBuilder(baseUrl + "/" + path);

                uriBuilder.Query = (string.IsNullOrWhiteSpace(uriBuilder.Query)?"": uriBuilder.Query+"&")
                    + string.Join("&", arguments.Select(x => string.Format("{0}={1}", x.Key, x.Value)));

                try
                {
                    var jsonString = browser.DownloadString(uriBuilder.Uri);
                    return JsonConvert.DeserializeObject<T>(jsonString);
                }
                catch (Exception ex)
                {
                    throw new Exception("Can't download JSON from url: \""+ uriBuilder.Uri + "\"", ex);
                }
            }
        }
    }
}