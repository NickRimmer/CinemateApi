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
using CinemateApi.Enums;
using Newtonsoft.Json;

namespace CinemateApi.Models.Remote
{
    public class AccountVoteModel
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
                    return DateTime.ParseExact(DateOrigin, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                }
                catch
                {
                    return null;
                }
            }
        }

        [JsonProperty("movie")]
        public MovieShort2Model Movie { get; set; }

        [JsonProperty("value")]
        public short ValueOrigin;

        public VoteValueEnum Value
        {
            get { return (VoteValueEnum) ValueOrigin; }
        }

    }
}