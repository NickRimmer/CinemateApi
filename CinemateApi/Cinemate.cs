#region Copyright
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

using CinemateApi.Methods;

namespace CinemateApi
{
    public class Cinemate
    {
        public MovieMethod Movie;

        internal string BaseUrl { get; }
        internal string ApiKey { get; }

        public Cinemate(string baseUrl, string apiKey)
        {
            BaseUrl = baseUrl;
            ApiKey = apiKey;

            Movie=new MovieMethod(this);
        }

    }
}
