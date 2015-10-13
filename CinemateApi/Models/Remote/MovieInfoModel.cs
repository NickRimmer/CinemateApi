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

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using CinemateApi.Models.Remote;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class MovieInfoModel
    {
        [JsonProperty("kinopoisk")]
        public RatingModel RateKinopoisk { get; set; }

        [JsonProperty("director")]
        public MoviePersonsListModel Director { get; set; }

        [JsonProperty("release_date_world")]
        public string ReleaseDateWorldSource { get; set; }

        [JsonIgnore]
        public DateTime? ReleaseDateWorld
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(ReleaseDateWorldSource, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                catch //(Exception ex)
                {
                    //throw new Exception("release_date_world parse error", ex);
                    return null;
                }
            }
        }

        [JsonProperty("description")]
        public string DescriptionOrigin { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("poster")]
        public ImageModel Poster { get; set; }

        [JsonProperty("release_date_russia")]
        public string ReleaseDateRussiaSource { get; set; }

        [JsonIgnore]
        public DateTime? ReleaseDateRussia
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(ReleaseDateRussiaSource, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                catch //(Exception ex)
                {
                    //throw new Exception("release_date_russia parse error", ex);
                    return null;
                }
            }
        }

        [JsonProperty("title_english")]
        public string TitleEnglish { get; set; }

        [JsonProperty("country")]
        public NamesListModel Country { get; set; }

        [JsonProperty("cast")]
        public MoviePersonsListModel Cast { get; set; }

        [JsonProperty("imdb")]
        public RatingModel Imdb { get; set; }

        [JsonProperty("title_original")]
        public string TitleOriginal { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("genre")]
        public NamesListModel Genre { get; set; }

        [JsonProperty("runtime")]
        public int RunTime { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("trailer")]
        public string Trailer { get; set; }

        [JsonProperty("title_russian")]
        public string TitleRussian { get; set; }

        [JsonIgnore]
        public string UrlInfo { get; set; }

    }
}