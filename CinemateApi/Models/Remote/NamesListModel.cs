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

using System.Collections.Generic;
using System.Linq;
using CinemateApi.Tools;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class NamesListModel
    {
        [JsonProperty("name")]
        [JsonConverter(typeof(FixJsonListsConverter<string>))]
        public List<string> Names { get; set; }

        public override string ToString()
        {
            if (Names == null) return null;
            if (!Names.Any()) return null;

            return Names.Aggregate(string.Empty, (c, i) => c + (c.Equals(string.Empty) ? string.Empty : ", ") + i);
        }
 
    }
}