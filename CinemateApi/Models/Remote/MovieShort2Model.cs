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

using CinemateApi.Enums;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class MovieShort2Model
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("poster")]
        public ImageModel Poster { get; set; }

        [JsonProperty("title_russian")]
        public string TitleRussian { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("type")]
        public string TypeOrigin { get; set; }

        [JsonIgnore]
        public MovieTypeEnum Type {
            get { return MovieEnumsConverter.GetMovieTypeEnum(TypeOrigin); }
        }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}