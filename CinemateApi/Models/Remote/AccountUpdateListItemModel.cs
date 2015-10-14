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
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class AccountUpdateListItemModel
    {
        [JsonProperty("date")]
        public string DateOrigin { get; set; }

        [JsonIgnore]
        public DateTime? Date
        {
            get
            {
                try
                {
                    return DateTime.ParseExact(DateOrigin, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                }
                catch
                {
                    return null;
                }
            }
        }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("new")]
        public int NewOrigin { get; set; }

        [JsonIgnore]
        public bool? New {
            get { return NewOrigin.Equals(1); } 
        }

        [JsonProperty("for_object")]
        public Dictionary<string, AccountUpdateObjectModel> ForObject { get; set; }

    }
}