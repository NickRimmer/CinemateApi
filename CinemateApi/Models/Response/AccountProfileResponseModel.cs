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

using CinemateApi.Models.Remote;
using Newtonsoft.Json;

namespace CinemateApi.Models.Response
{
    public class AccountProfileResponseModel
    {
        [JsonProperty("username")]
        public string UserName;

        [JsonProperty("subscription_count")]
        public int SubscriptionCount;

        [JsonProperty("review_count")]
        public int ReviewCount;

        [JsonProperty("bronze_badges")]
        public int BronzeBadges;

        [JsonProperty("unread_updatelist_count")]
        public int UnreadUpdatelistCount;

        [JsonProperty("movieseen_time")]
        public string MovieseenTime;

        [JsonProperty("unread_pm_count")]
        public int UnreadPmCount;

        [JsonProperty("silver_badges")]
        public int SilverBadges;

        [JsonProperty("gold_badges")]
        public int GoldBadges;

        [JsonProperty("reputation")]
        public int Reputation;

        [JsonProperty("avatar")]
        public Image2Model Avatar;

        [JsonProperty("movieseen_count")]
        public int MovieseenCount;

        [JsonProperty("active")]
        public bool Active;

        [JsonProperty("unread_forum_count")]
        public int UnreadForumCount;
    }
}