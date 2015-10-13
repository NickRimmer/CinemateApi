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

using CinemateApi.Models.Response;
using CinemateApi.Tools;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class PersonMoviesModel
    {
        [JsonProperty("director")]
        public MovieListResponseModel AsDirector { get; set; }

        [JsonProperty("actor")]
        public MovieListResponseModel AsActor { get; set; }
    }
}