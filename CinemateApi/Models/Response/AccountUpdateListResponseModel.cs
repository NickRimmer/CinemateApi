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

using System.Collections.Generic;
using CinemateApi.Models.Remote;
using CinemateApi.Tools;
using Newtonsoft.Json;

namespace CinemateApi.Models.Response
{
    public class AccountUpdateListResponseModel
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("item")]
        [JsonConverter(typeof(FixJsonListsConverter<AccountUpdateListItemModel>))]
        public List<AccountUpdateListItemModel> Item { get; set; }
    }
}